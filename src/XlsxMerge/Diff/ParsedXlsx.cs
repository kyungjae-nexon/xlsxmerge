using System;
using System.Collections.Generic;

namespace NexonKorea.XlsxMerge
{
	public class ParsedXlsx
	{
		public List<Worksheet> Worksheets = new List<Worksheet>();

		public class Worksheet
		{
			public string Name = "";
			public List<double> ColumnWidthList = new List<double>();
			public List<List<CellContents>> Cells = new List<List<CellContents>>(); // List<Row>

			public int GetRowCount()
			{
				return Cells.Count;
			}

			public int GetColumnCount()
			{
				if (Cells.Count == 0)
					return 0;
				return Cells[0].Count;
			}

			public CellContents Cell(int rowNumber, int colNumber)
			{
				if (rowNumber <= Cells.Count && colNumber <= Cells[rowNumber - 1].Count)
					return Cells[rowNumber - 1][colNumber - 1];
				return new CellContents();
			}
		}

		public class CellContents
		{
			public CellContents(string _value2String = "", string _formulaString = "")
			{
				Value2String = _value2String;
				FormulaString = _formulaString;
				if (FormulaString == null || FormulaString.StartsWith("=") == false)
					FormulaString = "";
				ContentsForDiff3 = (string.IsNullOrWhiteSpace(FormulaString)) ? Value2String : FormulaString;
			}

			public readonly string Value2String;
			public readonly string FormulaString;
			public readonly string ContentsForDiff3; // '같은 값' 비교에 사용합니다.
		}
	}
}