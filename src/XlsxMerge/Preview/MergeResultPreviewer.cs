using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NexonKorea.XlsxMerge
{
	class MergeResultPreviewer
	{

		public static void RefreshDataGridViewContents(XlsxMergeDecision xlsxMergeDecision,
			XlsxMergeDecision.SheetMergeDecision sheetMergeDecision,
			DataGridView dataGridView,
			MergeResultPreviewData previewData)
		{
			if (sheetMergeDecision == null)
				return;

			var sheetResult = sheetMergeDecision.SheetDiffResult;
			var parsedWorksheetData = xlsxMergeDecision.DiffResult.GetParsedWorksheetData(sheetResult.WorksheetName);

			// 열 생성

			dataGridView.Rows.Clear();
			dataGridView.Columns.Clear();

			// 기본 열
			dataGridView.Columns.Add("hunk_no", "변경 위치");
			dataGridView.Columns["hunk_no"].Width = 80;
			dataGridView.Columns.Add("source_line", "소스(행)");
			dataGridView.Columns["source_line"].Width = 80;

			// C1, C2, ... 
			var unifiedColumnWidthList = new List<double>();
			foreach (var eachWorksheet in parsedWorksheetData.Values)
			{
				if (eachWorksheet == null || eachWorksheet.GetRowCount() == 0)
					continue;

				int elemToCopy = eachWorksheet.ColumnWidthList.Count - unifiedColumnWidthList.Count;
				if (elemToCopy < 1)
					continue;

				unifiedColumnWidthList.AddRange(eachWorksheet.ColumnWidthList.GetRange(unifiedColumnWidthList.Count, elemToCopy));
			}

			if (unifiedColumnWidthList.Count == 0)
			{
				// 모두 빈 워크시트입니다.
				dataGridView.Columns.Add("C1", "정보");
				dataGridView.Columns["C1"].Width = 400;
				int rowIndex = dataGridView.Rows.Add();
				dataGridView.Rows[rowIndex].Cells["C1"].Value = "(빈 워크시트입니다.)";
				return;
			}

			for (int i = 1; i <= unifiedColumnWidthList.Count; i++)
			{
				string columnName = HelperFunctions.GetExcelColumnName(i);
				int columnWidth = (int)(unifiedColumnWidthList[i - 1]);
				dataGridView.Columns.Add("C" + i.ToString(), columnName + "::[]");
				dataGridView.Columns["C" + i.ToString()].Width = columnWidth;
			}

			foreach (DataGridViewColumn eachCol in dataGridView.Columns)
				eachCol.SortMode = DataGridViewColumnSortMode.NotSortable;


			var cachedTempPreviewLines = previewData.RowInfoList;

			Font strikeoutFont = new Font(SystemFonts.DefaultFont, FontStyle.Strikeout);
			dataGridView.RowCount = cachedTempPreviewLines.Count();
			for (int currentRowIdx = 0; currentRowIdx < cachedTempPreviewLines.Count(); currentRowIdx++)
			{
				var eachRow = cachedTempPreviewLines[currentRowIdx];
				var dgvRow = dataGridView.Rows[currentRowIdx];

				string[] token = eachRow.Split(new char[] { ':' });
				dgvRow.Cells["hunk_no"].Value = "";
				{
					var candidateHunkIdx = previewData.GetHunkIdxByRowNumber(currentRowIdx);
                    if (candidateHunkIdx >= 0)
                    {
                        if (sheetMergeDecision.HunkMergeDecisionList[candidateHunkIdx].DocMergeOrder == null)
                            dgvRow.Cells["hunk_no"].Style.SelectionBackColor = Color.Red;
                        else
                            dgvRow.Cells["hunk_no"].Style.SelectionBackColor = Color.LightSlateGray;
                        dgvRow.Cells["hunk_no"].Value = $"#{candidateHunkIdx + 1}";
                    }
				}

				string sourceLineText = token[0];
				if (token.Length == 1)
				{
					dgvRow.DefaultCellStyle.BackColor = Color.Yellow;
					dgvRow.Cells["source_line"].Value = sourceLineText;
					continue;
				}

				if (token.Length > 1)
					sourceLineText = sourceLineText + $": {token[1]}";

				bool isRemovedLine = token.Length > 2 && token[2].EndsWith("-1");
                if (isRemovedLine)
                    sourceLineText = sourceLineText + " [-]";
                int refBaseRowNumber = int.MinValue;
				if (token.Length > 2)
					refBaseRowNumber = int.Parse(token[2]);

				Color backColor = Color.White;
				int rowNumber = int.Parse(token[1]);
				var refWorksheet = parsedWorksheetData[DocOrigin.Base];
				if (token[0].StartsWith("base"))
				{
					refWorksheet = parsedWorksheetData[DocOrigin.Base];
					backColor = ColorScheme.BaseBackground;
				}
				else if (token[0].StartsWith("mine"))
				{
					refWorksheet = parsedWorksheetData[DocOrigin.Mine];
					backColor = ColorScheme.MineBackground;
				}
				else if (token[0].StartsWith("theirs"))
				{
					refWorksheet = parsedWorksheetData[DocOrigin.Theirs];
					backColor = ColorScheme.TheirsBackground;
				}
				else
				{
					sourceLineText = "=";
				}

				dgvRow.DefaultCellStyle.BackColor = backColor;
				if (isRemovedLine)
					dgvRow.DefaultCellStyle.Font = strikeoutFont;
				dgvRow.Cells["source_line"].Value = sourceLineText;

				if (refWorksheet.GetRowCount() == 0)
					continue;


				int maxColumn = refWorksheet.GetColumnCount();
				for (int cellNumber = 1; cellNumber <= maxColumn; cellNumber++)
				{
					var currentCell = refWorksheet.Cell(rowNumber, cellNumber);
					var currentCellDgv = dgvRow.Cells["C" + cellNumber.ToString()];
					currentCellDgv.Value = currentCell.Value2String;

					if (refBaseRowNumber <= 0 || parsedWorksheetData[DocOrigin.Base] == null)
						continue;

					var baseCell = parsedWorksheetData[DocOrigin.Base].Cell(refBaseRowNumber, cellNumber);
					if (currentCell.ContentsForDiff3 == baseCell.ContentsForDiff3)
						continue;

					if (dgvRow.DefaultCellStyle.BackColor == ColorScheme.MineBackground)
						currentCellDgv.Style.BackColor = ColorScheme.MineHighlight;
					if (dgvRow.DefaultCellStyle.BackColor == ColorScheme.TheirsBackground)
						currentCellDgv.Style.BackColor = ColorScheme.TheirsHighlight;
				}
			}
		}
	}
}
