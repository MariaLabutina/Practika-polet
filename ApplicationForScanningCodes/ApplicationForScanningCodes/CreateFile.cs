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
                labelPath.Text = folderBrowserDialogFile.SelectedPath;
            }
        }
    }
}
