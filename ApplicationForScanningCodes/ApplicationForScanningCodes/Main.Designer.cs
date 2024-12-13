
namespace ApplicationForScanningCodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBoxCodes = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.timerScan = new System.Windows.Forms.Timer(this.components);
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonStartScan = new System.Windows.Forms.Button();
            this.buttonStopScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxCodes
            // 
            this.listBoxCodes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxCodes.FormattingEnabled = true;
            this.listBoxCodes.ItemHeight = 23;
            this.listBoxCodes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBoxCodes.Location = new System.Drawing.Point(12, 42);
            this.listBoxCodes.Name = "listBoxCodes";
            this.listBoxCodes.Size = new System.Drawing.Size(320, 326);
            this.listBoxCodes.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(532, 30);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Наименование документа";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(381, 55);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(224, 44);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать файл";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(477, 305);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(266, 44);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить и закрыть файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(381, 240);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(458, 45);
            this.textBoxCode.TabIndex = 5;
            // 
            // timerScan
            // 
            this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(615, 55);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(224, 44);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonStartScan
            // 
            this.buttonStartScan.Location = new System.Drawing.Point(381, 178);
            this.buttonStartScan.Name = "buttonStartScan";
            this.buttonStartScan.Size = new System.Drawing.Size(224, 44);
            this.buttonStartScan.TabIndex = 7;
            this.buttonStartScan.Text = "Начать сканирование";
            this.buttonStartScan.UseVisualStyleBackColor = true;
            this.buttonStartScan.Click += new System.EventHandler(this.buttonStartScan_Click);
            // 
            // buttonStopScan
            // 
            this.buttonStopScan.Location = new System.Drawing.Point(615, 178);
            this.buttonStopScan.Name = "buttonStopScan";
            this.buttonStopScan.Size = new System.Drawing.Size(224, 44);
            this.buttonStopScan.TabIndex = 8;
            this.buttonStopScan.Text = "Закончить сканирование";
            this.buttonStopScan.UseVisualStyleBackColor = true;
            this.buttonStopScan.Click += new System.EventHandler(this.buttonStopScan_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(377, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Подразделение:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Не выбрано"});
            this.comboBox1.Location = new System.Drawing.Point(615, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 31);
            this.comboBox1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 399);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStopScan);
            this.Controls.Add(this.buttonStartScan);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxCodes);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Приложение для сканирования";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCodes;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Timer timerScan;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonStartScan;
        private System.Windows.Forms.Button buttonStopScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

