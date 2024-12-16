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

        private int count = 0;
        private void Comparison_Load(object sender, EventArgs e)
        {
            openFileDialogFile1.Filter = "Файлы Excel(*.xlsx)|*.xlsx|All files(*.*)|*.*";
            openFileDialogFile2.Filter = "Файлы Excel(*.xls)|*.xls|Файлы Excel(*.xlsx)|*.xlsx|All files(*.*)|*.*";
            DataBase.codes.Clear();
        }
        private void buttonSearchFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            labelPath1.Text = openFileDialogFile1.FileName;
            DataBase.codes.Clear();
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
                DataBase.codes.Add(worksheet.Cells[i, 1].Text.ToString());
            }

            excelApp.Quit();
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(worksheet);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = "";
            if (labelPath1.Text != "...." && labelPath2.Text != "....")
            {
                MessageBox.Show("Сравнение запущено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < DataBase.codes.Count; i++)
                {
                    text = RemoveR(DataBase.codes[i]);
                    FindCode(text);
                }

                MessageBox.Show($"Сравнение успешно завершено!\n Найдено {count} из {DataBase.codes.Count} !", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase.codes.Clear();
                count = 0;
            }
            else if (labelPath1.Text != "...." && labelPath2.Text == "....")
            {
                MessageBox.Show("Отсутствует путь файла, с которым происходит сравнение!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (labelPath2.Text != "...." && labelPath1.Text == "....")
            {
                MessageBox.Show("Отсутствует путь файла, с кодами для сравнения!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Отсутствуют выбранные пути файлов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private string RemoveR(string text)
        {
            if (text[text.Length - 1] == '\r')
            {
                text = text.Remove(text.Length - 1);
            }

            return text;
        }

        private void FindCode(string textToFind)
        {
            Excel.Application excelApp = new Excel.Application(); //Excel                    
            Excel.Range Rng; //диапазон ячеек
            Excel.Workbook workbook = excelApp.Workbooks.Open(labelPath2.Text);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

            

           
            Rng = worksheet.Cells.Find(textToFind, Type.Missing, Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false, Type.Missing, Type.Missing);//осуществляем поиск на лист
            if (Rng != null)
            {
                Rng.Interior.Color = Excel.XlRgbColor.rgbGreenYellow;
                workbook.SaveAs(labelPath2.Text, Excel.XlFileFormat.xlOpenXMLWorkbook, null, null, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
                Marshal.ReleaseComObject(Rng);
                count += 1;
            }

            excelApp.Quit();
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(worksheet);
        }


       

    }
}
