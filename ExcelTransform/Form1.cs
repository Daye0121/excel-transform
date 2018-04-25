using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTransform
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SelectPath(object sender, EventArgs e)
		{
			var btn = sender as Button;
			if (btn == null)
				return;

			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Select file";
			dialog.InitialDirectory = ".\\";
			dialog.Filter = "xls files (*.*)|*.xlsx";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var pathType = btn.Name.Remove(0, 10); //ChooseFile & ChooseFile2
				this.Controls.Find("Path" + pathType, false)[0].Text = dialog.FileName;
			}
		}

		private void Transform_Click(object sender, EventArgs e)
		{
			Excel.Application xlApp;
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			Excel.Range range;

			string str;
			var dataSeq = tbSeq.Text.Split('_'); //排序資料
			int rCnt = Int32.Parse(tbRow.Text); //Row
			int cCnt = Int32.Parse(tbCol.Text); //Col
			int rw = 0;
			int cl = 0;

			xlApp = new Excel.Application();
			xlWorkBook = xlApp.Workbooks.Open(this.Path.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
			xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

			range = xlWorkSheet.UsedRange;
			rw = range.Rows.Count;
			cl = range.Columns.Count;

			for (rCnt = 2; rCnt <= rw; rCnt++)
			{
				//初始陣列資料
				var arr = new List<int>();
				for (var i = 0; i < dataSeq.Length; i++)
					arr.Add(0);

				str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;

				if (str != null)
				{
					var strs = str.Split(',');
					foreach (var i in strs)
					{
						var j = i.TrimEnd().TrimStart();

						var index = Array.IndexOf(dataSeq, j);
						if (index >= 0)
							arr[index] = 1;
					}

				}
				var result = "[" + String.Join(",", arr) + "]";
				(range.Cells[rCnt, cCnt]) = result; //回寫資料
			}
			var rootIndex = Path.Text.IndexOf(".xlsx");
			var pathRoot = Path.Text.Substring(0, rootIndex);

			xlWorkBook.SaveAs(pathRoot + "_output.xlsx");
			xlApp.Quit();

			Marshal.ReleaseComObject(xlWorkSheet);
			Marshal.ReleaseComObject(xlWorkBook);
			Marshal.ReleaseComObject(xlApp);

			MessageBox.Show("轉檔成功");
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			this.Path.Text = "";
		}

		private void Transform2_Click(object sender, EventArgs e)
		{
			Excel.Application xlApp;
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			Excel.Range range;

			string str;
			var dataName = tbDataName.Text.Split('_'); //欲計算的資料名稱
			int rCnt = 2; //Row
			int cCnt = Int32.Parse(tbCol2.Text); //Col
			int rw = 0;
			int cl = 0;

			if (Path2.Text == "")
			{
				MessageBox.Show("尚未選擇檔案!");
				return;
			}

			xlApp = new Excel.Application();
			xlWorkBook = xlApp.Workbooks.Open(this.Path2.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
			xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

			range = xlWorkSheet.UsedRange;
			rw = range.Rows.Count;
			cl = range.Columns.Count;

			//回寫資料抬頭
			for (var i = 0; i < dataName.Length; i++)
				(range.Cells[1, cl + i + 1]) = dataName[i];

			for (rCnt = Int32.Parse(tbRow2.Text); rCnt <= rw; rCnt++)
			{
				str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;

				//初始陣列資料
				var arr = new List<int>();
				for (var i = 0; i < dataName.Length; i++)
					arr.Add(0);

				//回寫資料至新的Col
				if (str != null)
				{
					var strs = str.Split(',');
					foreach (var i in strs)
					{
						var j = i.TrimEnd().TrimStart();

						var index = Array.IndexOf(dataName, j);
						if (index >= 0)
							arr[index] = 1;
					}

				}
				for (var cntIndex = 0; cntIndex < arr.Count; cntIndex++)
					(range.Cells[rCnt, cl + cntIndex + 1]) = arr[cntIndex];

			}
				(xlWorkSheet.Cells[rCnt, cCnt] as Excel.Range).EntireColumn.Delete(null);

			var rootIndex = Path2.Text.IndexOf(".xlsx");
			var pathRoot = Path2.Text.Substring(0, rootIndex);

			xlWorkBook.SaveAs(pathRoot + "_output.xlsx");

			xlApp.Quit();

			Marshal.ReleaseComObject(xlWorkSheet);
			Marshal.ReleaseComObject(xlWorkBook);
			Marshal.ReleaseComObject(xlApp);

			MessageBox.Show("轉檔成功");
		}

		private void Clear2_Click(object sender, EventArgs e)
		{
			Path2.Text = "";
		}
	}
}
