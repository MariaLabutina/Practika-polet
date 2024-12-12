using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            buttonScan.BackColor = Color.FromArgb(0, 105, 137);
            buttonScan.ForeColor = Color.FromArgb(234, 235, 237);
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
            createFile.FormClosed += CreateFile_FormClosed;
        }

        private void CreateFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            labelName.Text = DataBase.name;
            if (DataBase.path.Length != 0)
            {
                buttonScan.Enabled = true;
                buttonSave.Enabled = true;
                buttonCreate.Enabled = false;
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            
            listBoxCodes.Items.Add("1");
        }

        private void Start()
        {
            count = 1;
            buttonCreate.Enabled = true;
            buttonSave.Enabled = false;
            buttonScan.Enabled = false;
            listBoxCodes.Items.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void SaveCode(string text)
        {
            using (FileStream fstream = new FileStream(DataBase.path, FileMode.Open))
            {
                Workbook wb = new Workbook(fstream);
                Worksheet sheet = wb.Worksheets[0];
                Cell cell = sheet.Cells[$"A{count}"];
                cell.PutValue(text);
                wb.Save(DataBase.path, SaveFormat.Xlsx);
            }
        }
    }
}
