using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace NexonKorea.XlsxMerge
{
    class ParsedXlsxGenerator : IDisposable
    {
        private Excel.Application _application = null;

        public ParsedXlsx ParseXlsx(string xlsxFilePath)
        {
            var result = new ParsedXlsx();

            if (_application == null)
            {
	            FakeBackgroundWorker.OnUpdateProgress("xlsx 파일 비교 [3단계 중 1단계]", "엑셀을 실행하고 있습니다.");
                _application = new Excel.Application();
                _application.DisplayAlerts = false;
                _application.Visible = false;
            }

	        FakeBackgroundWorker.OnUpdateProgress("xlsx 파일 비교 [3단계 중 2단계]", "문서를 읽고 있습니다.", Path.GetFileName(xlsxFilePath), xlsxFilePath);
            var workbooks = _application.Workbooks;
            var workbook = workbooks.Open(Path.GetFullPath(xlsxFilePath));
            var worksheets = workbook.Worksheets;

            // Change links to simple notation : [1] [2] ...
	        if (workbook.LinkSources(Excel.XlLink.xlExcelLinks) is Array links)
                for (int i = 1; i <= links.Length; i++)
                    workbook.ChangeLink(links.GetValue(i).ToString(), $"{i}", Excel.XlLinkType.xlLinkTypeExcelLinks);

            for (int worksheetIndex = 1; worksheetIndex <= worksheets.Count; worksheetIndex++)
            {
                Excel.Worksheet worksheet = worksheets.Item[worksheetIndex] as Excel.Worksheet;
                worksheet.Activate();
                var parsedWorksheet = new ParsedXlsx.Worksheet();
                result.Worksheets.Add(parsedWorksheet);
                parsedWorksheet.Name = worksheet.Name;
                parsedWorksheet.Cells = new List<List<ParsedXlsx.CellContents>>();

                var lastRowColNumber = HelperFunctions.GetLastRowColumnNumber(worksheet);
                int lastRowNumber = lastRowColNumber.Key;
                int lastColNumber = lastRowColNumber.Value;


                if (lastRowNumber != 0 && lastColNumber != 0)
                {
                    Excel.Range allCells = null;
                    {
                        // endCell에는 행/열 번호에 1씩 더해줘서, Value2 / Value / Formula 가 single value / 0-based array로 동작하는 것을 막는다.
                        // https://stackoverflow.com/a/37176162
                        var startCell = worksheet.Cells[1, 1] as Excel.Range;
                        var endCell = worksheet.Cells[lastRowNumber + 1, lastColNumber + 1] as Excel.Range;
                        allCells = worksheet.Range[startCell.Address, endCell.Address] as Excel.Range;
                        Marshal.ReleaseComObject(endCell);
                        Marshal.ReleaseComObject(startCell);
                    }

                    // classic : https://fastexcel.wordpress.com/2011/11/30/text-vs-value-vs-value2-slow-text-and-how-to-avoid-it/
                    var value2Array = allCells.Value2 as object[,];
                    var formulaArray = allCells.FormulaR1C1 as object[,];

                    for(int c = 1; c <= lastColNumber; c++)
                    {
                        var headerCell = allCells[1, c] as Excel.Range;
                        var columnWidth = headerCell.Width;
                        parsedWorksheet.ColumnWidthList.Add((double)columnWidth);
                        Marshal.ReleaseComObject(headerCell);
                    }

                    Marshal.ReleaseComObject(allCells);
                    allCells = null; // to prevent future use

                    for (int i = 1; i <= lastRowNumber; i++)
                    {
                        var currentRow = new List<ParsedXlsx.CellContents>();
                        parsedWorksheet.Cells.Add(currentRow);
                        for (int j = 1; j <= lastColNumber; j++)
                        {
	                        var newCell =
		                        new ParsedXlsx.CellContents($"{value2Array[i, j]}", $"{formulaArray[i, j]}");
                            currentRow.Add(newCell);
                        }
                    }
                }

                Marshal.ReleaseComObject(worksheet);
            }

            Marshal.ReleaseComObject(worksheets);

            // https://stackoverflow.com/a/8813945
            workbook.Close(SaveChanges: false);

            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(workbooks);

            return result;
        }

        public void Dispose()
        {
            if (_application == null)
                return;

            _application.Quit();
            Marshal.ReleaseComObject(_application);
            _application = null;
            GC.Collect();
        }
    }
}
