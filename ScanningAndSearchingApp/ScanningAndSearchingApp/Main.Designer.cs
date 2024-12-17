
namespace ScanningAndSearchingApp
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.listBoxCodes = new System.Windows.Forms.ListBox();
            this.textBoxScan = new System.Windows.Forms.TextBox();
            this.buttonStartScan = new System.Windows.Forms.Button();
            this.buttonFinishScan = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.timerScan = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(705, 31);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Выберите файл, в котором будет происходить сканирование:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPath
            // 
            this.labelPath.Location = new System.Drawing.Point(12, 56);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(533, 31);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "Выберите файл, в котором будет происходить сканирование:";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(551, 56);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(150, 31);
            this.buttonPath.TabIndex = 2;
            this.buttonPath.Text = "Обзор";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // listBoxCodes
            // 
            this.listBoxCodes.FormattingEnabled = true;
            this.listBoxCodes.ItemHeight = 23;
            this.listBoxCodes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.listBoxCodes.Location = new System.Drawing.Point(16, 111);
            this.listBoxCodes.Name = "listBoxCodes";
            this.listBoxCodes.Size = new System.Drawing.Size(311, 280);
            this.listBoxCodes.TabIndex = 3;
            // 
            // textBoxScan
            // 
            this.textBoxScan.Location = new System.Drawing.Point(350, 186);
            this.textBoxScan.Multiline = true;
            this.textBoxScan.Name = "textBoxScan";
            this.textBoxScan.Size = new System.Drawing.Size(367, 36);
            this.textBoxScan.TabIndex = 4;
            // 
            // buttonStartScan
            // 
            this.buttonStartScan.Location = new System.Drawing.Point(350, 111);
            this.buttonStartScan.Name = "buttonStartScan";
            this.buttonStartScan.Size = new System.Drawing.Size(367, 37);
            this.buttonStartScan.TabIndex = 5;
            this.buttonStartScan.Text = "Начать сканирование";
            this.buttonStartScan.UseVisualStyleBackColor = true;
            this.buttonStartScan.Click += new System.EventHandler(this.buttonStartScan_Click);
            // 
            // buttonFinishScan
            // 
            this.buttonFinishScan.Location = new System.Drawing.Point(350, 272);
            this.buttonFinishScan.Name = "buttonFinishScan";
            this.buttonFinishScan.Size = new System.Drawing.Size(367, 37);
            this.buttonFinishScan.TabIndex = 6;
            this.buttonFinishScan.Text = "Завершить сканирование";
            this.buttonFinishScan.UseVisualStyleBackColor = true;
            this.buttonFinishScan.Click += new System.EventHandler(this.buttonFinishScan_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(350, 354);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(367, 37);
            this.buttonOpenFile.TabIndex = 7;
            this.buttonOpenFile.Text = "Завершить работу с файлом";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // timerScan
            // 
            this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 414);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonFinishScan);
            this.Controls.Add(this.buttonStartScan);
            this.Controls.Add(this.textBoxScan);
            this.Controls.Add(this.listBoxCodes);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Приложение для сканирования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.ListBox listBoxCodes;
        private System.Windows.Forms.TextBox textBoxScan;
        private System.Windows.Forms.Button buttonStartScan;
        private System.Windows.Forms.Button buttonFinishScan;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Timer timerScan;
    }
}

