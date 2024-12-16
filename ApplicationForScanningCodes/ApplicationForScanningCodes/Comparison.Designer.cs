
namespace ApplicationForScanningCodes
{
    partial class Comparison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparison));
            this.labelPath1 = new System.Windows.Forms.Label();
            this.buttonSearchFile1 = new System.Windows.Forms.Button();
            this.openFileDialogFile1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogFile2 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSearchFile2 = new System.Windows.Forms.Button();
            this.labelPath2 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPath1
            // 
            this.labelPath1.Location = new System.Drawing.Point(12, 45);
            this.labelPath1.Name = "labelPath1";
            this.labelPath1.Size = new System.Drawing.Size(411, 36);
            this.labelPath1.TabIndex = 0;
            this.labelPath1.Text = "....";
            // 
            // buttonSearchFile1
            // 
            this.buttonSearchFile1.Location = new System.Drawing.Point(456, 45);
            this.buttonSearchFile1.Name = "buttonSearchFile1";
            this.buttonSearchFile1.Size = new System.Drawing.Size(75, 36);
            this.buttonSearchFile1.TabIndex = 1;
            this.buttonSearchFile1.Text = "Обзор";
            this.buttonSearchFile1.UseVisualStyleBackColor = true;
            this.buttonSearchFile1.Click += new System.EventHandler(this.buttonSearchFile1_Click);
            // 
            // openFileDialogFile1
            // 
            this.openFileDialogFile1.FileName = "openFileDialog1";
            // 
            // openFileDialogFile2
            // 
            this.openFileDialogFile2.FileName = "openFileDialog2";
            // 
            // buttonSearchFile2
            // 
            this.buttonSearchFile2.Location = new System.Drawing.Point(456, 138);
            this.buttonSearchFile2.Name = "buttonSearchFile2";
            this.buttonSearchFile2.Size = new System.Drawing.Size(75, 36);
            this.buttonSearchFile2.TabIndex = 3;
            this.buttonSearchFile2.Text = "Обзор";
            this.buttonSearchFile2.UseVisualStyleBackColor = true;
            this.buttonSearchFile2.Click += new System.EventHandler(this.buttonSearchFile2_Click);
            // 
            // labelPath2
            // 
            this.labelPath2.Location = new System.Drawing.Point(12, 138);
            this.labelPath2.Name = "labelPath2";
            this.labelPath2.Size = new System.Drawing.Size(411, 36);
            this.labelPath2.TabIndex = 2;
            this.labelPath2.Text = "....";
            // 
            // labelName1
            // 
            this.labelName1.Location = new System.Drawing.Point(12, 18);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(529, 27);
            this.labelName1.TabIndex = 4;
            this.labelName1.Text = "Файл, с кодами для сравнения:";
            this.labelName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName2
            // 
            this.labelName2.Location = new System.Drawing.Point(12, 102);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(529, 27);
            this.labelName2.TabIndex = 5;
            this.labelName2.Text = "Файл, с которым происходит сравнение:";
            this.labelName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(154, 199);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(269, 36);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Выполнить сравнение";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 247);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.labelName1);
            this.Controls.Add(this.buttonSearchFile2);
            this.Controls.Add(this.labelPath2);
            this.Controls.Add(this.buttonSearchFile1);
            this.Controls.Add(this.labelPath1);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Comparison";
            this.Text = "Проверка на соответствие";
            this.Load += new System.EventHandler(this.Comparison_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPath1;
        private System.Windows.Forms.Button buttonSearchFile1;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile1;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile2;
        private System.Windows.Forms.Button buttonSearchFile2;
        private System.Windows.Forms.Label labelPath2;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Button buttonSearch;
    }
}