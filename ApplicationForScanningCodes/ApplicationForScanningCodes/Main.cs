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
            listBoxCodes.BackColor = Color.FromArgb(234, 235, 237);
            buttonOpenFile.BackColor = Color.FromArgb(0, 105, 137);
            buttonOpenFile.ForeColor = Color.FromArgb(234, 235, 237);
            buttonStartScan.BackColor = Color.FromArgb(0, 105, 137);
            buttonStartScan.ForeColor = Color.FromArgb(234, 235, 237);
            buttonStopScan.BackColor = Color.FromArgb(0, 105, 137);
            buttonStopScan.ForeColor = Color.FromArgb(234, 235, 237);
            comboBox1.SelectedIndex = 0;

        }

       private int count = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            GetDivisions();
            Start();
        }

       
        //создание файла
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateFile createFile = new CreateFile();
            createFile.Show();
            this.Hide();
            createFile.FormClosed += CreateFile_FormClosed;
        }


        //событие происходящее после создания файла
        private void CreateFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            labelName.Text = DataBase.name;
            if (DataBase.path.Length != 0)
            {
                Stop();
            }
        }
        

        private void Stop()
        {
            textBoxCode.Enabled = false;
            buttonSave.Enabled = false;
            buttonCreate.Enabled = false;
            buttonOpenFile.Enabled = false;
            buttonStartScan.Enabled = true;
            buttonStopScan.Enabled = false;
            comboBox1.Enabled = true;
            
        }

        //сброс настроек
        private void Start()
        {
            DataBase.path = "";
            DataBase.name = "";
            labelName.Text = "";
            count = 0;
            buttonCreate.Enabled = true;
            buttonOpenFile.Enabled = true;
            buttonStartScan.Enabled = false;
            buttonStopScan.Enabled = false;
            comboBox1.Enabled = false;
            buttonSave.Enabled = false;
            textBoxCode.Enabled = false;
            listBoxCodes.Items.Clear();
            DataBase.items.Clear();
        }


        //сохранение и закрытие документа
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Start();
            comboBox1.SelectedIndex = 0;
            textBoxCode.Text = "";
        }


        //сохранение отсканированного кода
        private void SaveCode(string text)
        {
            listBoxCodes.Items.Add(text);
            DataBase.items.Add(text);
            
                Excel.Application excelApp = new Excel.Application();
        
                excelApp.DisplayAlerts = false;
                Excel.Workbook workbook = excelApp.Workbooks.Open(DataBase.path, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                count = workbook.Worksheets[1].Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row+1;

                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

                worksheet.Range[$"A{count}"].Value = text;
                worksheet.Range[$"B{count}"].Value = comboBox1.Text;
                worksheet.Range[$"C{count}"].Value = DateTime.Now;
                workbook.SaveAs(DataBase.path, Excel.XlFileFormat.xlOpenXMLWorkbook, null, null, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);

                excelApp.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(worksheet);
        }


        //функция сканирования
        private void Scan()
        {
            if (textBoxCode.Text != "")
            {
                string text = textBoxCode.Text;
                
                if (text[text.Length - 1] == '\n')
                {
                    text = text.Remove(text.Length - 1);
                    if (DataBase.items.Contains(text))
                    {
                        textBoxCode.Text = "";
                        MessageBox.Show("Повторное сканирование!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SaveCode(text);
                    }
                    textBoxCode.Text = "";
                    textBoxCode.Focus();
                }
            } 
        }


        //запуск сканирования
        private void timerScan_Tick(object sender, EventArgs e)
        {
            Scan();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile openFile = new OpenFile();
            openFile.Show();
            this.Hide();
            openFile.FormClosed += CreateFile_FormClosed;
        }

        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                timerScan.Start();
                textBoxCode.Enabled = true;
                
                textBoxCode.Focus();
                buttonStartScan.Enabled = false;
                buttonStopScan.Enabled = true;

            }
            else
            {
                MessageBox.Show("Выберите подразделение!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonStopScan_Click(object sender, EventArgs e)
        {
            timerScan.Stop();
            buttonStartScan.Enabled = false;
            buttonStopScan.Enabled = false;
            buttonSave.Enabled = true;
            comboBox1.Enabled = false;
        }

        //получение из текстового файла подразделения
        private void GetDivisions()
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(@"ico\\divisions.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    //Add your conditional logic to add the line to an array
                    if (line==null)
                    {
                        break;
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
            }

            for(int i=1; i<lines.Count; i++)
            {
                comboBox1.Items.Add(lines[i-1]);
            }
        }

    }
}
