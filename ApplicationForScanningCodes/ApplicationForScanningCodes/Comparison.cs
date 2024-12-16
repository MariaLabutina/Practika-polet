using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ApplicationForScanningCodes
{
    public partial class Comparison : Form
    {
        public Comparison()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(163, 186, 195);
            buttonSearch.BackColor = Color.FromArgb(0, 105, 137);
            buttonSearch.ForeColor = Color.FromArgb(234, 235, 237);
            buttonSearchFile1.BackColor = Color.FromArgb(0, 105, 137);
            buttonSearchFile1.ForeColor = Color.FromArgb(234, 235, 237);
            buttonSearchFile2.BackColor = Color.FromArgb(0, 105, 137);
            buttonSearchFile2.ForeColor = Color.FromArgb(234, 235, 237);
        }


        private void Comparison_Load(object sender, EventArgs e)
        {
            openFileDialogFile1.Filter = "Файлы Excel(*.xlsx)|*.xlsx|All files(*.*)|*.*";
            openFileDialogFile2.Filter = "Файлы Excel(*.xlsx)|*.xlsx|All files(*.*)|*.*";
        }
        private void buttonSearchFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            labelPath1.Text = openFileDialogFile1.FileName;
            LoadListCodes();
        }

        private void buttonSearchFile2_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile2.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            labelPath2.Text = openFileDialogFile2.FileName;
        }

        private void LoadListCodes()
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.DisplayAlerts = false;
            Excel.Workbook workbook = excelApp.Workbooks.Open(labelPath1.Text, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            int count = workbook.Worksheets[1].Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

            for (int i = 2; i <= count; i++)
            {
                DataBase.codes.Add(new List<string>());
                DataBase.codes[i-2].Add(worksheet.Cells[i, 1].Text.ToString());
                DataBase.codes[i-2].Add(worksheet.Cells[i, 2].Text.ToString());
            }

            excelApp.Quit();
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(worksheet);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataBase.codes.Count; i++)
            {
                FindCode1(DataBase.codes[i][0], DataBase.codes[i][1]);
                //FindCode(DataBase.codes[i][0]);
            }
            MessageBox.Show("Сравнение успешно завершено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //private void FindCode(string textToFind)
        //{
        //    Excel.Application excelApp = new Excel.Application(); //Excel                    
        //    Excel.Range Rng; //диапазон ячеек

        //    Excel.Workbook workbook = excelApp.Workbooks.Open(labelPath2.Text);
        //    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

        //    Rng = worksheet.Cells.Find(textToFind, Type.Missing, Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart); //осуществляем поиск на листе

        //    if (Rng != null)
        //    {
        //        //MessageBox.Show("Текст: '" + textToFind + "' найден в ячейке: " + Rng.Address, "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        Rng.Interior.Color = Excel.XlRgbColor.rgbGreenYellow;
        //        workbook.SaveAs(labelPath2.Text, Excel.XlFileFormat.xlOpenXMLWorkbook, null, null, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
        //        Marshal.ReleaseComObject(Rng);
        //    }

        //    excelApp.Quit();
        //    Marshal.ReleaseComObject(workbook);
        //    Marshal.ReleaseComObject(worksheet);
        //}


        private void FindCode1(string code, string development)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(labelPath2.Text);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

            bool isBreak = false;
            var rowCount = workbook.Worksheets[1].Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            for (int i = 1; i < rowCount; i++)
            {
                if (code.Equals(worksheet.Range[$"A{i}"].Value))
                {
                    if (development.Equals(worksheet.Range[$"B{i}"].Value))
                    {
                        worksheet.Range[$"A{i}"].Interior.Color = Excel.XlRgbColor.rgbYellow;
                        workbook.SaveAs(labelPath2.Text, Excel.XlFileFormat.xlOpenXMLWorkbook, null, null, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
                    }
                    break;
                }

            }

            excelApp.Quit();
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(worksheet);
        }

    }
}
