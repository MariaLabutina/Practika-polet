using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ApplicationForScanningCodes
{
    public partial class CreateFile : Form
    {
        public CreateFile()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(163, 186, 195);
            buttonSave.BackColor = Color.FromArgb(0, 105, 137);
            buttonSave.ForeColor = Color.FromArgb(234, 235, 237);
            buttonPath.BackColor = Color.FromArgb(0, 105, 137);
            buttonPath.ForeColor = Color.FromArgb(234, 235, 237);
            textBoxName.BackColor = Color.FromArgb(234, 235, 237);
        }
        private string path = @"C:\Документы для практики";

        private void CreateFile_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
           
         DialogResult result = folderBrowserDialogFile.ShowDialog();
            // если папка выбрана и нажата клавиша `OK` — значит можно получить путь к папке
            if (result == DialogResult.OK)
            {
                // запишем в переменную путь к папке
                path = folderBrowserDialogFile.SelectedPath;
                labelPath.Text = path;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (path.Length != 0 && textBoxName.Text.Length != 0)
            {
                
                DataBase.path=Path.Combine(path, $"{textBoxName.Text}.xlsx");
                DataBase.name = textBoxName.Text;

                Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
                ex.SheetsInNewWorkbook = 1;
                Excel.Workbook workBook = ex.Workbooks.Add();
                
               workBook.SaveAs(DataBase.path);//посмотреть на что можно заменить и как лучше с ним работать
                
                ex.Quit();
                Marshal.ReleaseComObject(workBook);
                this.Close();
               
            }
        }
    }
}
