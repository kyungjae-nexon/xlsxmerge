using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexonKorea.XlsxMerge
{
	class MergeResultPreviewData
	{
		public List<String> RowInfoList = new List<string>();
		public List<int> HunkStartsPosList = new List<int>(); // diff hunk navigate에 사용
		public List<int> HunkEndsPosList = new List<int>(); // diff hunk navigate에 사용

		public int GetHunkIdxByRowNumber(int dataGridRowNumber)
		{
			var candidateHunkIdx = HunkStartsPosList.FindLastIndex(r => r <= dataGridRowNumber);
			if (candidateHunkIdx < 0)
				return -1;
			if (dataGridRowNumber >= HunkEndsPosList[candidateHunkIdx])
				return -1;
			return candidateHunkIdx;
		}

		public static MergeResultPreviewData GeneratePreviewData(XlsxMergeDecision.SheetMergeDecision sheetDecision,
			int worksheetBaseRowCount, bool hideDeletedLines, bool hideEqualLines)
		{
			if (sheetDecision == null)
				return null;

			var sheetResult = sheetDecision.SheetDiffResult;

			var previewData = new MergeResultPreviewData();
			int lastRowBase = 0; // result 안에 이미 들어간 base 의 마지막 줄


			for (var hunkIdx = 0; hunkIdx < sheetResult.HunkList.Count; hunkIdx++)
			{
				var eachHunkInfo = sheetResult.HunkList[hunkIdx];
				var hunkMergeOrderToShow = sheetDecision.HunkMergeDecisionList[hunkIdx].DocMergeOrder;
				if (sheetDecision.MergeModeDecision != WorksheetMergeMode.Merge)
				{
					hunkMergeOrderToShow = new List<DocOrigin>();
					if (sheetDecision.MergeModeDecision == WorksheetMergeMode.UseBase)
						hunkMergeOrderToShow.Add(DocOrigin.Base);
					if (sheetDecision.MergeModeDecision == WorksheetMergeMode.UseMine)
						hunkMergeOrderToShow.Add(DocOrigin.Mine);
					if (sheetDecision.MergeModeDecision == WorksheetMergeMode.UseTheirs)
						hunkMergeOrderToShow.Add(DocOrigin.Theirs);
				}


				var rowRangeBase = eachHunkInfo.rowRangeMap[DocOrigin.Base];
				var rowRangeMine = eachHunkInfo.rowRangeMap[DocOrigin.Mine];
				var rowRangeTheirs = eachHunkInfo.rowRangeMap[DocOrigin.Theirs];

				if (hideEqualLines == false)
					for (int i = lastRowBase + 1; i < rowRangeBase.RowNumber; i++)
						previewData.RowInfoList.Add("=:" + i.ToString());

				previewData.HunkStartsPosList.Add(previewData.RowInfoList.Count);

				if (hunkMergeOrderToShow == null)
				{
					previewData.RowInfoList.Add("vv충돌");
					for (int i = rowRangeBase.RowNumber; i < rowRangeBase.RowNumber + rowRangeBase.RowCount; i++)
						previewData.RowInfoList.Add($"base:{i}");
					for (int i = 0; i < rowRangeMine.RowCount; i++)
					{
						var lineContents = $"mine:{i + rowRangeMine.RowNumber}";
						if (i < rowRangeBase.RowCount)
							lineContents = lineContents + ":" + (rowRangeBase.RowNumber + i).ToString();
						previewData.RowInfoList.Add(lineContents);
					}

					for (int i = 0; i < rowRangeTheirs.RowCount; i++)
					{
						var lineContents = $"theirs:{i + rowRangeTheirs.RowNumber}";
						if (i < rowRangeBase.RowCount)
							lineContents = lineContents + ":" + (rowRangeBase.RowNumber + i).ToString();
						previewData.RowInfoList.Add(lineContents);
					}

					previewData.RowInfoList.Add("^^충돌");
				}
				else
				{
					var docRangeInfoMap = new Dictionary<DocOrigin, Tuple<String, RowRange>>();
					docRangeInfoMap[DocOrigin.Base] = new Tuple<string, RowRange>("base", rowRangeBase);
					docRangeInfoMap[DocOrigin.Mine] = new Tuple<string, RowRange>("mine", rowRangeMine);
					docRangeInfoMap[DocOrigin.Theirs] = new Tuple<string, RowRange>("theirs", rowRangeTheirs);


					var docOriginToShowDeleted = new List<DocOrigin>();
					if (hunkMergeOrderToShow.Contains(DocOrigin.Base) == false)
						docOriginToShowDeleted.Add(DocOrigin.Base);
					if (hunkMergeOrderToShow.Contains(DocOrigin.Mine) == false &&
					    (eachHunkInfo.hunkStatus == Diff3HunkStatus.MineDiffers ||
					     eachHunkInfo.hunkStatus == Diff3HunkStatus.Conflict))
						docOriginToShowDeleted.Add(DocOrigin.Mine);
					if (hunkMergeOrderToShow.Contains(DocOrigin.Theirs) == false &&
					    (eachHunkInfo.hunkStatus == Diff3HunkStatus.TheirsDiffers ||
					     eachHunkInfo.hunkStatus == Diff3HunkStatus.Conflict))
						docOriginToShowDeleted.Add(DocOrigin.Theirs);

					foreach (var deletedDoc in docOriginToShowDeleted)
					{
						string docstr = docRangeInfoMap[deletedDoc].Item1;
						RowRange docrange = docRangeInfoMap[deletedDoc].Item2;
						if (hideDeletedLines == false)
							for (int i = docrange.RowNumber; i < docrange.RowNumber + docrange.RowCount; i++)
								previewData.RowInfoList.Add($"{docstr}:{i}:-1");
					}


					foreach (var currentDoc in hunkMergeOrderToShow)
					{
						string docstr = docRangeInfoMap[currentDoc].Item1;
						RowRange docrange = docRangeInfoMap[currentDoc].Item2;
						for (int i = 0; i < docrange.RowCount; i++)
						{
							string lineContents = $"{docstr}:{docrange.RowNumber + i}";

							// 만약 mine이나 theirs이라면, base의 어느 줄과 비교할 것인지를 알려준다.
							if (currentDoc != DocOrigin.Base && i < rowRangeBase.RowCount)
								lineContents = lineContents + ":" + (rowRangeBase.RowNumber + i).ToString();

							previewData.RowInfoList.Add(lineContents);
						}
					}
				}

				previewData.HunkEndsPosList.Add(previewData.RowInfoList.Count);

				lastRowBase = rowRangeBase.RowNumber + rowRangeBase.RowCount - 1;
			}
			if (hideEqualLines == false)
				for (int i = lastRowBase + 1; i <= worksheetBaseRowCount; i++)
					previewData.RowInfoList.Add("=:" + i.ToString());

			return previewData;
		}
	}
}
