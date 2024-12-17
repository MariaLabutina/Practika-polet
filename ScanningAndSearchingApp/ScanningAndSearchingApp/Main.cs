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

namespace ScanningAndSearchingApp
{
    public partial class Main : Form
    {
        private Color colorFore = Color.FromArgb(226,232,206);
        private Color colorFon = Color.FromArgb(67,75,64);
        private Color colorBack = Color.FromArgb(38,38,38);

        private List<string> items = new List<string>();
        private int count = 0;
        private Excel.Application excelApp;//Excel                    
        private Excel.Range Rng; //диапазон ячеек
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        public Main()
        {
            InitializeComponent();
            this.BackColor = colorFon;
            labelName.ForeColor = colorFore;
            labelPath.ForeColor = colorFore;
            buttonPath.BackColor = colorBack;
            buttonPath.ForeColor = colorFore;
            buttonStartScan.BackColor = colorBack;
            buttonStartScan.ForeColor = colorFore;
            buttonFinishScan.BackColor = colorBack;
            buttonFinishScan.ForeColor = colorFore;
            buttonOpenFile.BackColor = colorBack;
            buttonOpenFile.ForeColor = colorFore;
            listBoxCodes.BackColor = colorFore;
            listBoxCodes.ForeColor = colorBack;
            textBoxScan.BackColor = colorFore;
            textBoxScan.ForeColor = colorBack;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            openFileDialogExcel.Filter = "Файлы Excel(*.xls)|*.xls|Файлы Excel(*.xlsx)|*.xlsx|All files(*.*)|*.*";
        }


        private void Reset()
        {
            listBoxCodes.Items.Clear();
            textBoxScan.Text = "";
            labelPath.Text = "";
            textBoxScan.Enabled = false;
            buttonStartScan.Enabled = false;
            buttonFinishScan.Enabled = false;
            buttonOpenFile.Enabled = false;
            buttonPath.Enabled = true;
            count = 0;
            items.Clear();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            if (openFileDialogExcel.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            labelPath.Text = openFileDialogExcel.FileName;
            buttonStartScan.Enabled = true;
        }

        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            buttonPath.Enabled = false;
            buttonStartScan.Enabled = false;
            textBoxScan.Enabled = true;
            buttonFinishScan.Enabled = true;
            textBoxScan.Focus();
            timerScan.Start();
            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Open(labelPath.Text);
            worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

        }

        private void timerScan_Tick(object sender, EventArgs e)
        {
            Scan();
        }

        //функция сканирования
        private void Scan()
        {
            if (textBoxScan.Text != "")
            {
                string text = textBoxScan.Text;

                if (text[text.Length - 1] == '\n')
                {
                    text = text.Remove(text.Length - 1);
                    if (items.Contains(text))
                    {
                        textBoxScan.Text = "";
                        MessageBox.Show("Повторное сканирование!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        listBoxCodes.Items.Add(text);
                        items.Add(text);
                        FindCode(RemoveR(text));
                    }
                    textBoxScan.Text = "";
                    textBoxScan.Focus();
                }
            }
        }
        //приведение кода к общему виду
        private string RemoveR(string text)
        {
            if (text[text.Length - 1] == '\r')
            {
                text = text.Remove(text.Length - 1);
            }

            return text;
        }

        //функция поиска кода
        private void FindCode(string textToFind)
        {
            
            Rng = worksheet.Cells.Find(textToFind);//осуществляем поиск на лист
            if (Rng != null)
            {
                Rng.Interior.Color = Excel.XlRgbColor.rgbGreenYellow;
                workbook.SaveAs(labelPath.Text, Excel.XlFileFormat.xlOpenXMLWorkbook, null, null, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, null, null, null);
                Marshal.ReleaseComObject(Rng);
                count += 1;
            }

        }

        private void buttonFinishScan_Click(object sender, EventArgs e)
        {
            timerScan.Stop();
            MessageBox.Show($"Сканирование завершено!\nНайдено {count} из {listBoxCodes.Items.Count}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            buttonFinishScan.Enabled = false;
            buttonOpenFile.Enabled = true;
            excelApp.Quit();
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(worksheet);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
