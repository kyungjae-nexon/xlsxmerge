using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NexonKorea.XlsxMerge
{
	// XlsxMergeDecision으로부터, 실제 조립 명령어를 만들어 냅니다.
	class XlsxMergeCommand
	{
		public DocOrigin _docOriginMergeInto = DocOrigin.Mine;

		public void Init(XlsxMergeDecision mergeDecision, DocOrigin mergeInto = DocOrigin.Mine)
		{
			_docOriginMergeInto = mergeInto;
			
			CommandList.Clear();
			// MINE 을 기본으로 합니다.
			foreach (var sheetDecision in mergeDecision.SheetMergeDecisionList)
			{
				switch (sheetDecision.MergeModeDecision)
				{
					case WorksheetMergeMode.Unchanged:
						// do nothing
						break;
					case WorksheetMergeMode.Delete:
						if (sheetDecision.SheetDiffResult.DocsContaining.Contains(_docOriginMergeInto))
							CommandList.Add(XlsxMergeCommandItem.DeleteSheet(_docOriginMergeInto, sheetDecision.WorksheetName));
						break;
					case WorksheetMergeMode.UseBase:
						if (_docOriginMergeInto != DocOrigin.Base)
						{
							if (sheetDecision.SheetDiffResult.DocsContaining.Contains(_docOriginMergeInto))
								CommandList.Add(XlsxMergeCommandItem.DeleteSheet(_docOriginMergeInto, sheetDecision.WorksheetName));
							CommandList.Add(XlsxMergeCommandItem.CopySheet(DocOrigin.Base, _docOriginMergeInto, sheetDecision.WorksheetName));
						}
						break;
					case WorksheetMergeMode.UseMine:
						if (_docOriginMergeInto != DocOrigin.Mine)
						{
							if (sheetDecision.SheetDiffResult.DocsContaining.Contains(_docOriginMergeInto))
								CommandList.Add(XlsxMergeCommandItem.DeleteSheet(_docOriginMergeInto, sheetDecision.WorksheetName));
							CommandList.Add(XlsxMergeCommandItem.CopySheet(DocOrigin.Mine, _docOriginMergeInto, sheetDecision.WorksheetName));
						}
						break;
					case WorksheetMergeMode.UseTheirs:
						if (_docOriginMergeInto != DocOrigin.Theirs)
						{
							if (sheetDecision.SheetDiffResult.DocsContaining.Contains(_docOriginMergeInto))
								CommandList.Add(XlsxMergeCommandItem.DeleteSheet(_docOriginMergeInto, sheetDecision.WorksheetName));
							CommandList.Add(XlsxMergeCommandItem.CopySheet(DocOrigin.Theirs, _docOriginMergeInto, sheetDecision.WorksheetName));
						}

						break;
					case WorksheetMergeMode.Merge:
						ProcessMergeDecision(sheetDecision);
						break;
				}
			}
		}

		private int AddRowCopyCommand(DocOrigin docOriginSource, string worksheetName, int rowNumberInsertAt, XlsxMergeDecision.HunkMergeDecision hunk)
		{
			var rowRange = hunk.BaseHunkInfo.rowRangeMap[docOriginSource];
			if (docOriginSource != _docOriginMergeInto && rowRange.RowCount > 0)
				CommandList.Add(XlsxMergeCommandItem.CopyRow(docOriginSource, _docOriginMergeInto, worksheetName, rowRange.RowNumber, rowRange.RowCount, rowNumberInsertAt));
			return rowNumberInsertAt + rowRange.RowCount;
		}

		public void ProcessMergeDecision(XlsxMergeDecision.SheetMergeDecision sheetMergeDecision)
		{
			// 맨 끝 변경사항부터 첫 변경사항으로 적용합니다.
			// 이 방법을 사용할 경우 행 추가/삭제로 인한 줄 번호 재계산을 할 필요가 없어집니다.
			foreach (var hunk in sheetMergeDecision.HunkMergeDecisionList.OrderBy(r=>-r.BaseHunkInfo.rowRangeMap[_docOriginMergeInto].RowNumber))
			{
				int currentRowNumber = hunk.BaseHunkInfo.rowRangeMap[_docOriginMergeInto].RowNumber;
				if (hunk.DocMergeOrder == null)
				{
					CommandList.Add(XlsxMergeCommandItem.InsertText(_docOriginMergeInto, sheetMergeDecision.WorksheetName, "[XlsxMerge충돌] 충돌 지점 시작 >>>", currentRowNumber));
					currentRowNumber++;

					CommandList.Add(XlsxMergeCommandItem.InsertText(_docOriginMergeInto, sheetMergeDecision.WorksheetName, ">Base<", currentRowNumber));
					currentRowNumber++;
					currentRowNumber = AddRowCopyCommand(DocOrigin.Base, sheetMergeDecision.WorksheetName, currentRowNumber, hunk);

					CommandList.Add(XlsxMergeCommandItem.InsertText(_docOriginMergeInto, sheetMergeDecision.WorksheetName, ">Mine(Destination)<", currentRowNumber));
					currentRowNumber++;
					currentRowNumber = AddRowCopyCommand(DocOrigin.Mine, sheetMergeDecision.WorksheetName, currentRowNumber, hunk);

					CommandList.Add(XlsxMergeCommandItem.InsertText(_docOriginMergeInto, sheetMergeDecision.WorksheetName, ">Theirs(Source)<", currentRowNumber));
					currentRowNumber++;
					currentRowNumber = AddRowCopyCommand(DocOrigin.Theirs, sheetMergeDecision.WorksheetName, currentRowNumber, hunk);

					CommandList.Add(XlsxMergeCommandItem.InsertText(_docOriginMergeInto, sheetMergeDecision.WorksheetName, "<<< 충돌 지점 끝", currentRowNumber));
					currentRowNumber++;
				}
				else
				{
					foreach (var docOrigin in hunk.DocMergeOrder)
						currentRowNumber = AddRowCopyCommand(docOrigin, sheetMergeDecision.WorksheetName, currentRowNumber, hunk);

					if (hunk.DocMergeOrder.Contains(_docOriginMergeInto) == false && hunk.BaseHunkInfo.rowRangeMap[_docOriginMergeInto].RowCount > 0)
						CommandList.Add(XlsxMergeCommandItem.DeleteRow(_docOriginMergeInto, sheetMergeDecision.WorksheetName,
							currentRowNumber, hunk.BaseHunkInfo.rowRangeMap[_docOriginMergeInto].RowCount));
				}
			}
		}

		public List<XlsxMergeCommandItem> CommandList =new List<XlsxMergeCommandItem>();

		public string Dump()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var eachCommand in CommandList)
			{
				sb.Append(eachCommand.Cmd);
				sb.Append("\t" + (eachCommand.sourceOrigin.HasValue ? eachCommand.sourceOrigin.Value.ToString() : ""));
				sb.Append("\t" + (eachCommand.destOrigin.HasValue ? eachCommand.destOrigin.Value.ToString() : ""));
				sb.Append("\t" + eachCommand.param1);
				sb.Append("\t" + eachCommand.param2);
				sb.Append("\t" + (eachCommand.intParam1 == -1 ? "" : eachCommand.intParam1.ToString()));
				sb.Append("\t" + (eachCommand.intParam2 == -1 ? "" : eachCommand.intParam2.ToString()));
				sb.Append("\t" + (eachCommand.intParam3 == -1 ? "" : eachCommand.intParam3.ToString()));
				sb.AppendLine();
			}

			return sb.ToString();
		}
	}

	public class XlsxMergeCommandItem
	{
		public string Cmd;
		public DocOrigin? sourceOrigin;
		public DocOrigin? destOrigin;
		public string param1 = "";
		public string param2 = "";
		public int intParam1 = -1;
		public int intParam2 = -1;
		public int intParam3 = -1;

		public static XlsxMergeCommandItem DeleteSheet(DocOrigin docOrigin, String worksheetName)
		{
			return new XlsxMergeCommandItem()
			{
				Cmd = "DELETE_SHEET",
				destOrigin = docOrigin,
				param1 = worksheetName
			};
		}

		public static XlsxMergeCommandItem CopySheet(DocOrigin docOriginFrom, DocOrigin docOriginTo, String worksheetNameFrom)
		{
			return new XlsxMergeCommandItem()
			{
				Cmd = "COPY_SHEET",
				sourceOrigin = docOriginFrom,
				destOrigin = docOriginTo,
				param1 = worksheetNameFrom,
			};
		}

		public static XlsxMergeCommandItem CopyRow(DocOrigin docOriginFrom, DocOrigin docOriginTo, String worksheetName, int rowNumberFrom, int rowCountFrom, int rowNumberInsertAt)
		{
			return new XlsxMergeCommandItem()
			{
				Cmd = "COPY_ROW",
				sourceOrigin = docOriginFrom,
				destOrigin = docOriginTo,
				param1 = worksheetName,
				intParam1 = rowNumberInsertAt,
				intParam2 = rowNumberFrom,
				intParam3 = rowCountFrom,
			};
		}

		public static XlsxMergeCommandItem InsertText(DocOrigin docOrigin, String worksheetName, String text, int rowNumberInsertAt)
		{
			return new XlsxMergeCommandItem()
			{
				Cmd = "INSERT_TEXT",
				destOrigin = docOrigin,
				param1 = worksheetName,
				param2 = text,
				intParam1 = rowNumberInsertAt
			};
		}

		public static XlsxMergeCommandItem DeleteRow(DocOrigin docOrigin, String worksheetName, int rowNumberDeleteAt, int rowCount)
		{
			return new XlsxMergeCommandItem()
			{
				Cmd = "DELETE_ROW",
				destOrigin = docOrigin,
				param1 = worksheetName,
				intParam1 = rowNumberDeleteAt,
				intParam2 = rowCount,
			};
		}
	}
}
