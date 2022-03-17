using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace NexonKorea.XlsxMerge
{
    public class RowRange
    {
        public int RowNumber = 0;
        public int RowCount = 0;
    }

	public enum Diff3HunkStatus
	{
		BaseDiffers, // base 문서만 다르다.
		MineDiffers, // mine 문서만 다르다.
		TheirsDiffers, // theirs 문서만 다르다.
		Conflict, // mine + theirs 각각 수정점이 있다.
	}

	public enum DocOrigin
    {
        Base,
        Mine, // mine = destination = current
        Theirs, // theirs = source = others
    }

	public enum WorksheetMergeMode
	{
		Unchanged,
		Delete,
		UseBase,
		UseMine,
		UseTheirs,
		Merge
	}

	class ColorScheme
	{
		public static readonly Color BaseHighlight = Color.FromArgb(239, 211, 141);
		public static readonly Color BaseBackground = Color.FromArgb(255, 243, 209);
		public static readonly Color MineHighlight = Color.FromArgb(196, 238, 157);
		public static readonly Color MineBackground = Color.FromArgb(229, 253, 207);
		public static readonly Color TheirsHighlight = Color.FromArgb(182, 202, 223);
		public static readonly Color TheirsBackground = Color.FromArgb(230, 231, 243);
		public static readonly Color DiffHunk = Color.FromArgb(214, 196, 205);
	}

	class HelperFunctions
	{
		public static string GetExcelColumnName(int columnNumber)
		{
			// https://stackoverflow.com/a/182924

			int dividend = columnNumber;
			string columnName = String.Empty;
			int modulo;

			while (dividend > 0)
			{
				modulo = (dividend - 1) % 26;
				columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
				dividend = (int)((dividend - modulo) / 26);
			}

			return columnName;
		}

		// 이 문서의 마지막 행 번호, 마지막 열 번호를 반환합니다.
		public static KeyValuePair<int, int> GetLastRowColumnNumber(Microsoft.Office.Interop.Excel.Worksheet worksheet)
		{
			int rowCount = 0;
			int colCount = 0;

			{
				var a1Cell = worksheet.Cells[1, 1] as Microsoft.Office.Interop.Excel.Range;
				var wsCells = worksheet.Cells;
				var lastRowRange = wsCells.Find("*", a1Cell, Microsoft.Office.Interop.Excel.XlFindLookIn.xlFormulas, Microsoft.Office.Interop.Excel.XlLookAt.xlPart, Microsoft.Office.Interop.Excel.XlSearchOrder.xlByRows, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious, false);
				if (lastRowRange != null)
				{
					var lastColRange = wsCells.Find("*", a1Cell, Microsoft.Office.Interop.Excel.XlFindLookIn.xlFormulas, Microsoft.Office.Interop.Excel.XlLookAt.xlPart, Microsoft.Office.Interop.Excel.XlSearchOrder.xlByColumns, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious, false);

					rowCount = lastRowRange.Row;
					colCount = lastColRange.Column;

					Marshal.ReleaseComObject(lastColRange);
					Marshal.ReleaseComObject(lastRowRange);
				}
				Marshal.ReleaseComObject(wsCells);
				Marshal.ReleaseComObject(a1Cell);
			}

			return new KeyValuePair<int, int>(rowCount, colCount);
		}

        public static bool IsTwoPathEqual(String path1, String path2)
        {
            var fullPath1 = System.IO.Path.GetFullPath(path1);
            var fullPath2 = System.IO.Path.GetFullPath(path2);
            return string.Equals(fullPath1, fullPath2, StringComparison.OrdinalIgnoreCase);
        }
	}

	class FakeBackgroundWorker
	{
		public delegate void UpdateProgressEvent(string title = null, params string[] messages);
		public static UpdateProgressEvent OnUpdateProgress = dummyUpdateProgress;

		public static void dummyUpdateProgress(string title = null, params string[] message)
		{
		}
	}

    class VersionName
    {
        public static Tuple<int, int, int> GetVersionMajorMinorBuild()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return new Tuple<int, int, int>(fvi.ProductMajorPart, fvi.ProductMinorPart, fvi.ProductBuildPart);
        }

        public static String GetVersionTextFromVersionTuple(Tuple<int, int, int> versions)
        {
            return $"v{versions.Item1}.{versions.Item2}.{versions.Item3}";
        }

        public static String GetFormTitleText()
        {
            var versions = GetVersionMajorMinorBuild();
            return "XlsxMerge " + GetVersionTextFromVersionTuple(versions);
        }
    }
}
