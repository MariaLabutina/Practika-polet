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
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(163, 186, 195);
            buttonSave.BackColor = Color.FromArgb(0, 105, 137);
            buttonSave.ForeColor = Color.FromArgb(234, 235, 237);
            buttonPath.BackColor = Color.FromArgb(0, 105, 137);
            buttonPath.ForeColor = Color.FromArgb(234, 235, 237);
        }

        private void OpenFile_Load(object sender, EventArgs e)
        {
            openFileDialogExcel.Filter = "Файлы Excel(*.xlsx)|*.xlsx|All files(*.*)|*.*";
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            if (openFileDialogExcel.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            labelPath.Text = openFileDialogExcel.FileName;
            DataBase.path = labelPath.Text;
            DataBase.name = openFileDialogExcel.SafeFileName;


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (DataBase.path != "")
            {
                LoadListCodes();
                this.Close();
            }
            else
            {
                MessageBox.Show("Файл не выбран!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadListCodes()
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.DisplayAlerts = false;
            Excel.Workbook workbook = excelApp.Workbooks.Open(DataBase.path, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            int count = workbook.Worksheets[1].Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

            for (int i = 2; i <= count; i++)
            {
                DataBase.items.Add(worksheet.Cells[i, 1].Text.ToString());
            }

            excelApp.Quit();
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(worksheet);
        }
    }
}
