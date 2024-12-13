using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
            }
            else
            {
                MessageBox.Show("Файл не выбран!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
