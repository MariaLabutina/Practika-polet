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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(163,186,195);
            buttonCreate.BackColor = Color.FromArgb(0,105,137);
            buttonCreate.ForeColor = Color.FromArgb(234, 235, 237);
            buttonSave.BackColor = Color.FromArgb(0, 105, 137);
            buttonSave.ForeColor = Color.FromArgb(234, 235, 237);
            //buttonScan.BackColor = Color.FromArgb(0, 105, 137);
            //buttonScan.ForeColor = Color.FromArgb(234, 235, 237);
            listBoxCodes.BackColor = Color.FromArgb(234, 235, 237);

        }

       private int count = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateFile createFile = new CreateFile();
            createFile.Show();
            this.Hide();
            createFile.FormClosed += CreateFile_FormClosed;
        }

        private void CreateFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            labelName.Text = DataBase.name;
            if (DataBase.path.Length != 0)
            {
                textBoxCode.Enabled = true;
                buttonSave.Enabled = true;
                buttonCreate.Enabled = false;
                timerScan.Start();
                textBoxCode.Focus();
            }
        }
        


        private void Start()
        {
            DataBase.path = "";
            DataBase.name = "";
            labelName.Text = "";
            count = 1;
            buttonCreate.Enabled = true;
            buttonSave.Enabled = false;
            textBoxCode.Enabled = false;
            timerScan.Stop();
            listBoxCodes.Items.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void SaveCode(string text)
        {
            listBoxCodes.Items.Add(text);
            
                Excel.Application excelApp = new Excel.Application();
        
                excelApp.DisplayAlerts = false;
                Excel.Workbook workbook = excelApp.Workbooks.Open(DataBase.path, Type.Missing, false, Type.Missing,
                Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, true, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Range[$"A{count}"].Value = text;
                workbook.SaveAs(DataBase.path, Excel.XlFileFormat.xlOpenXMLWorkbook, null, null, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);

                excelApp.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(worksheet);
                count += 1;
        }



        private void Scan()
        {

            if (textBoxCode.Text != "")
            {
                string text = textBoxCode.Text;
                if (text[text.Length - 1] == '\n')
                {
                    SaveCode(textBoxCode.Text);
                    textBoxCode.Text = "";
                    textBoxCode.Focus();
                }
            }
            
        }

        private void timerScan_Tick(object sender, EventArgs e)
        {
            Scan();
        }

    }
}
