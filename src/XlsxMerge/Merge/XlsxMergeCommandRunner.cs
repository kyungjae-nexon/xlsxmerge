using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace NexonKorea.XlsxMerge
{
    class XlsxMergeCommandRunner : IDisposable
    {
        public Excel.Application _application = null;
	    public Excel.Workbooks _workbooks = null;
		public Dictionary<DocOrigin, String> xlsxPathMap = new Dictionary<DocOrigin, string>();
        public Dictionary<String, Excel.Workbook> workbooksMap = new Dictionary<string, Excel.Workbook>();

	    public void Run(XlsxMergeCommand cmd, String baseFilePath, String mineFilePath, String theirsFilePath, String mergedFilePath)
	    {
		    workbooksMap.Clear();
		    xlsxPathMap.Clear();

		    xlsxPathMap[DocOrigin.Base] = baseFilePath;
		    xlsxPathMap[DocOrigin.Mine] = mineFilePath;
		    xlsxPathMap[DocOrigin.Theirs] = theirsFilePath;

			// 엑셀은 같은 파일명을 가진 워크시트를 동시에 열지 못하므로,
		    // 임시 폴더에 엑셀 파일을 이름을 바꾸어 복사합니다.
			String workingFolderPath = Path.Combine(Path.GetTempPath(), "xlsxmerge_" + Path.GetRandomFileName() + DateTime.Now.Ticks.ToString());
		    Directory.CreateDirectory(workingFolderPath);
		    var docOriginList = xlsxPathMap.Keys.ToList();
			foreach (var docOrigin in docOriginList)
		    {
				if (String.IsNullOrEmpty(xlsxPathMap[docOrigin]))
				    continue;

			    var originalPath = xlsxPathMap[docOrigin];
                var originalExt = Path.GetExtension(originalPath);
				var newPath = Path.Combine(workingFolderPath, $"{docOriginList.IndexOf(docOrigin)}.{originalExt}");
				File.Copy(originalPath, newPath);
			    xlsxPathMap[docOrigin] = newPath;

			    OpenWorkbook(newPath, originalPath);
		    }

		    int cmdItemIdx = 0;
		    foreach (var cmdItem in cmd.CommandList)
		    {
			    ApplyCommand(cmdItem);
			    var progress = (int) (cmdItemIdx * 100 / cmd.CommandList.Count);
			    FakeBackgroundWorker.OnUpdateProgress("xlsx 파일 머지 [4단계 중 3단계]", $"머지 내용 적용 중... {progress}%");
			    cmdItemIdx++;

		    }

			FakeBackgroundWorker.OnUpdateProgress("xlsx 파일 머지 [4단계 중 4단계]", "결과 저장 중...");
            if (File.Exists(mergedFilePath))
                File.Delete(mergedFilePath);
            GetWorkbook(DocOrigin.Mine).SaveCopyAs(Path.GetFullPath(mergedFilePath));

		    FakeBackgroundWorker.OnUpdateProgress("xlsx 파일 머지", "정리 중...");
			Dispose();

		    // https://stackoverflow.com/a/8521573/5694305
			foreach (var tempFile in Directory.GetFiles(workingFolderPath, "*", SearchOption.AllDirectories))
			    File.SetAttributes(tempFile, FileAttributes.Normal);
		    Directory.Delete(workingFolderPath, true);
		    FakeBackgroundWorker.OnUpdateProgress(null);
	    }

		private void OpenWorkbook(String xlsxFilePath, String originalPath)
		{
			if (String.IsNullOrEmpty(xlsxFilePath))
				return;

	        if (workbooksMap.ContainsKey(xlsxFilePath))
		        return;
            
            if (_application == null)
            {
	            FakeBackgroundWorker.OnUpdateProgress("xlsx 파일 머지 [4단계 중 1단계]", "엑셀을 실행하고 있습니다.");
				_application = new Excel.Application();
                _application.DisplayAlerts = false;
                _application.Visible = false;

	            _workbooks = _application.Workbooks;
            }
			FakeBackgroundWorker.OnUpdateProgress("xlsx 파일 머지 [4단계 중 2단계]", "기반 문서를 준비하고 있습니다.", Path.GetFileName(originalPath), originalPath);

			var workbook = _workbooks.Open(Path.GetFullPath(xlsxFilePath));
			if (workbook == null)
				throw new Exception("Error loading Excel file : " + xlsxFilePath);
	        workbooksMap[xlsxFilePath] = workbook;
        }

	    private Excel.Workbook GetWorkbook(DocOrigin docOrigin)
	    {
		    if (xlsxPathMap.ContainsKey(docOrigin) == false)
			    return null;

			return workbooksMap[xlsxPathMap[docOrigin]];
	    }


		public void ApplyCommand(XlsxMergeCommandItem cmdItem)
		{
			long a = DateTime.Now.Ticks;
			if (cmdItem.Cmd == "DELETE_SHEET")
			{
				var wss = GetWorkbook(cmdItem.destOrigin.Value).Sheets;
				var ws = wss[cmdItem.param1] as Excel.Worksheet;
				ws.Delete();

				ReleaseComs(new object [] {ws, wss});
			}
		    if (cmdItem.Cmd == "COPY_SHEET")
		    {
				var wssDest = GetWorkbook(cmdItem.destOrigin.Value).Sheets;
			    var wssSrc = GetWorkbook(cmdItem.sourceOrigin.Value).Sheets;
				var wsSrc = wssSrc[cmdItem.param1] as Excel.Worksheet;
				var wsDestAfter = wssDest[wssDest.Count] as Excel.Worksheet;
			    
				wsSrc.Copy(After: wsDestAfter);
				var wsDest = wssDest[cmdItem.param1] as Excel.Worksheet;

			    var srcRowCol = HelperFunctions.GetLastRowColumnNumber(wsSrc);
			    var srcLastCellName = HelperFunctions.GetExcelColumnName(srcRowCol.Value) + srcRowCol.Key.ToString();

				// 2019-07-23 : 복사 대상 워크시트의 맨 마지막 셀이 비어있거나 ("0"), A1 일 경우 아래 range 복사 기능이 제대로 동작하지 않습니다.
				// 이 경우에는 range를 강제로 A1:B1 으로 맞춰 줍니다.
			    if (srcLastCellName == "0" || srcLastCellName == "A1")
				    srcLastCellName = "B1";

			    Excel.Range oRngToCopyFormula = wsSrc.get_Range($"A1:{srcLastCellName}");
			    object[,] formula = oRngToCopyFormula.FormulaR1C1;
			    Excel.Range oRngToReceieveFormula = wsDest.get_Range($"A1:{srcLastCellName}");
			    oRngToReceieveFormula.FormulaR1C1 = formula;

			    ReleaseComs(new object[] { oRngToReceieveFormula, oRngToCopyFormula, wsDest, wsDestAfter, wsSrc, wssSrc, wssDest });
			}
			if (cmdItem.Cmd == "COPY_ROW")
		    {
				// https://stackoverflow.com/a/17717489
			    var wssDest = GetWorkbook(cmdItem.destOrigin.Value).Sheets;
			    var wssSrc = GetWorkbook(cmdItem.sourceOrigin.Value).Sheets;
			    var wsDest = wssDest[cmdItem.param1] as Excel.Worksheet;
			    var wsSrc = wssSrc[cmdItem.param1] as Excel.Worksheet;

			    var srcRowCol = HelperFunctions.GetLastRowColumnNumber(wsSrc);
			    var srcLastColumnName = HelperFunctions.GetExcelColumnName(srcRowCol.Value);

				Excel.Range oRngToCopyBase = wsSrc.get_Range($"{cmdItem.intParam2}:{cmdItem.intParam2+cmdItem.intParam3-1}");
			    Excel.Range oRngToCopy = oRngToCopyBase.EntireRow;

				// 행 복사 시, named reference가 있을 경우 외부 파일 참조가 걸리는 문제를 해결하기 위해
				// 다음과 같은 식으로 처리를 한다.
				// A. 복사 소스 행의 FormulaR1C1 값을 복사해 둔다.
				// B. 소스 행을 대상 문서로 복사 삽입한다. (외부 파일 참조가 생기게 된다)
				// C. 대상 문서에 새로 생긴 행에, A에서 미리 마련해둔 FormulaR1C1 을 붙여넣는다. (외부 파일 참조가 제거된다)

			    var RngToCopyFormulaFrom = $"A{cmdItem.intParam2}";
			    var RngToCopyFormulaTo = $"{srcLastColumnName}{cmdItem.intParam2 + cmdItem.intParam3 - 1}";

				// range가 An:An 일 경우, 아래의 FormulaR1C1 이 object[,] 가 아닌 string 이 들어와서 형 변환에 실패하고 exception이 발생한다.
				// 이를 피하기 위해 An:An 으로 range가 정해지면, An:Bn 으로 바꿔준다.
				if (RngToCopyFormulaFrom == RngToCopyFormulaTo)
					RngToCopyFormulaTo = "B" + RngToCopyFormulaTo.Substring(1);
				Excel.Range oRngToCopyFormula = wsSrc.get_Range($"{RngToCopyFormulaFrom}:{RngToCopyFormulaTo}");
				object[,] formula = oRngToCopyFormula.FormulaR1C1;

			    Excel.Range oRngToInsertBase = wsDest.get_Range($"{cmdItem.intParam1}:{cmdItem.intParam1}");
			    Excel.Range oRngToInsert = oRngToInsertBase.EntireRow;
				oRngToInsert.Insert(Excel.XlInsertShiftDirection.xlShiftDown, oRngToCopy.Copy(Type.Missing));

			    var RngToInsertFormulaFrom = $"A{cmdItem.intParam1}";
			    var RngToInsertFormulaTo = $"{srcLastColumnName}{cmdItem.intParam1 + cmdItem.intParam3 - 1}";
				// 위쪽 RngToCopyFormulaTo 조정과 같은 이유.
				if (RngToInsertFormulaFrom == RngToInsertFormulaTo)
				    RngToInsertFormulaTo = "B" + RngToInsertFormulaTo.Substring(1);

				Excel.Range oRngToInsertFormula = wsDest.get_Range($"{RngToInsertFormulaFrom}:{RngToInsertFormulaTo}");
                try
                {
                    oRngToInsertFormula.FormulaR1C1 = formula;
                }
                catch (System.Runtime.InteropServices.COMException comEx)
                {
                    if ((uint)comEx.HResult == 0x800a03ec)
                    {
                        // formula 형태가 잘못되었다는 오류.
                        // [==0] 과 같은(대괄호 제외) 텍스트를 셀에 붙여넣기했을 때 발생하는 이슈이다.
                        // 해결책:
                        // A. 미리 복사해뒀던 FormulaR1C1 array (formula) 를 돌면서, = 로 시작하는 셀을 찾아서 HasFormula 를 체크한다.
                        // B. A의 HasFormula가 false인 셀을 찾아서 목록을 만든다.
                        // C. B에서 찾은 셀마다, formula 값을 TO-BE-FILLED 라고 변경
                        // D. 다시 oRngToInsertFormula.FormulaR1C1 = formula; 를 한다. 이 시점에서 exception이 발생하지 않아야 한다.
                        // E. B에서 찾은 셀마다, 대상 셀을 copy/paste 한다. 이 때 '값' 만 복사한다.

                        var rowColToOverwrite = new List<Tuple<long, long>>();
                        long formulaRowSize = formula.GetLowerBound(0);
                        long formulaColSize = formula.GetLongLength(1);
                        for (long formulaRelRow = formula.GetLowerBound(0); formulaRelRow <= formula.GetUpperBound(0); formulaRelRow++)
                        {
                            for (long formulaRelCol = formula.GetLowerBound(1); formulaRelCol <= formula.GetUpperBound(1); formulaRelCol++)
                            {
                                var formulaText = formula[formulaRelRow, formulaRelCol].ToString();
                                if (formulaText.StartsWith("=") == false)
                                    continue;

                                Excel.Range cellToCheck = oRngToCopy.Cells[formulaRelRow, formulaRelCol];
                                object hasFormulaObj = cellToCheck.HasFormula;
                                ReleaseComs(new[] { cellToCheck });
                                if ((hasFormulaObj is bool) && ((bool)hasFormulaObj) == true)
                                    continue;

                                // now this IS the cell.
                                rowColToOverwrite.Add(new Tuple<long, long>(formulaRelRow, formulaRelCol));
                                formula[formulaRelRow, formulaRelCol] = "TO-BE-FILLED";
                            }
                        }

                        oRngToInsertFormula.FormulaR1C1 = formula;

                        foreach (var overwriteInfo in rowColToOverwrite)
                        {
                            Excel.Range cellToCheck = oRngToCopy.Cells[overwriteInfo.Item1, overwriteInfo.Item2];
                            Excel.Range cellToWriteValue = oRngToInsertFormula.Cells[overwriteInfo.Item1, overwriteInfo.Item2];

                            cellToCheck.Copy();
                            cellToWriteValue.PasteSpecial(Excel.XlPasteType.xlPasteValues);
                            ReleaseComs(new[] { cellToCheck, cellToWriteValue });
                        }
                    }
                    else
                    {
                        throw comEx;
                    }
                }

			    ReleaseComs(new object[] { oRngToInsertFormula, oRngToInsert, oRngToInsertBase, wsDest, oRngToCopyFormula });
			    ReleaseComs(new object[] { oRngToCopyFormula, oRngToCopy, oRngToCopyBase, wsSrc, wsDest, wssSrc, wssDest });
		    }
			if (cmdItem.Cmd == "INSERT_TEXT")
		    {
			    var wss = GetWorkbook(cmdItem.destOrigin.Value).Sheets;
			    var ws = wss[cmdItem.param1] as Excel.Worksheet;
			    var rowRange = (ws.Rows[cmdItem.intParam1] as Excel.Range);

				rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove);

			    var insertedRowFirstColumn = (ws.Cells[cmdItem.intParam1, 1] as Excel.Range);
			    insertedRowFirstColumn.Value2 = cmdItem.param2;

			    var insertedRowFirstColumnInterior = insertedRowFirstColumn.Interior;
			    insertedRowFirstColumnInterior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

			    ReleaseComs(new object[] { insertedRowFirstColumnInterior, insertedRowFirstColumn, rowRange, ws, wss });
		    }
			if (cmdItem.Cmd == "DELETE_ROW")
		    {
			    var wss = GetWorkbook(cmdItem.destOrigin.Value).Sheets;
			    var ws = wss[cmdItem.param1] as Excel.Worksheet;
			    Excel.Range oRngToDeleteBase = ws.get_Range($"{cmdItem.intParam1}:{cmdItem.intParam1 + cmdItem.intParam2 - 1}");
			    Excel.Range oRngToDelete = oRngToDeleteBase.EntireRow;
			    oRngToDelete.Delete();
			    ReleaseComs(new object[] { oRngToDelete, oRngToDeleteBase, ws, wss });
		    }
		}

	    private void ReleaseComs(object[] objects)
	    {

			foreach (var o in objects)
			    Marshal.ReleaseComObject(o);
	    }

		public void Dispose()
        {
            if (_application == null)
                return;

	        GC.Collect();
	        GC.WaitForPendingFinalizers();

	        foreach (var workbookItem in workbooksMap)
	        {
		        var workbook = workbookItem.Value;

				// https://stackoverflow.com/a/8813945
				workbook.Close(SaveChanges: false);
		        Marshal.ReleaseComObject(workbook);
	        }
	        workbooksMap.Clear();

			Marshal.ReleaseComObject(_workbooks);

			_application.Quit();
            Marshal.ReleaseComObject(_application);
            _application = null;
            GC.Collect();
	        GC.WaitForPendingFinalizers();
		}
    }
}
