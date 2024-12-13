
namespace ApplicationForScanningCodes
{
    partial class OpenFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFile));
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPath = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.Location = new System.Drawing.Point(22, 58);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(411, 37);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "...";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(245, 126);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 39);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Открыть";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(452, 58);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(129, 37);
            this.buttonPath.TabIndex = 5;
            this.buttonPath.Text = "Обзор";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialogExcel";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(151, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(312, 31);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Выберите файл";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 177);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPath);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpenFile";
            this.Text = "Открытие файла";
            this.Load += new System.EventHandler(this.OpenFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Label labelName;
    }
}