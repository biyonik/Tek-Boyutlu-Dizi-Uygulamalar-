namespace Uygulama_8
{
    partial class Form1
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnArithmeticAverage = new System.Windows.Forms.Button();
            this.btnHarmonicAverage = new System.Windows.Forms.Button();
            this.btnGeometricAverage = new System.Windows.Forms.Button();
            this.lstBaseArray = new System.Windows.Forms.ListBox();
            this.lblTotalSumOfArrayItems = new System.Windows.Forms.Label();
            this.lblTotalCountOfArray = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(12, 386);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(186, 43);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Doldur";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.BtnPopulate_Click);
            // 
            // btnArithmeticAverage
            // 
            this.btnArithmeticAverage.Location = new System.Drawing.Point(204, 12);
            this.btnArithmeticAverage.Name = "btnArithmeticAverage";
            this.btnArithmeticAverage.Size = new System.Drawing.Size(188, 41);
            this.btnArithmeticAverage.TabIndex = 2;
            this.btnArithmeticAverage.Text = "Aritmetik Ortalama Hesapla";
            this.btnArithmeticAverage.UseVisualStyleBackColor = true;
            this.btnArithmeticAverage.Click += new System.EventHandler(this.BtnArithmeticAverage_Click);
            // 
            // btnHarmonicAverage
            // 
            this.btnHarmonicAverage.Location = new System.Drawing.Point(204, 59);
            this.btnHarmonicAverage.Name = "btnHarmonicAverage";
            this.btnHarmonicAverage.Size = new System.Drawing.Size(188, 41);
            this.btnHarmonicAverage.TabIndex = 2;
            this.btnHarmonicAverage.Text = "Harmonik Ortalama Hesapla";
            this.btnHarmonicAverage.UseVisualStyleBackColor = true;
            this.btnHarmonicAverage.Click += new System.EventHandler(this.BtnHarmonicAverage_Click);
            // 
            // btnGeometricAverage
            // 
            this.btnGeometricAverage.Location = new System.Drawing.Point(204, 106);
            this.btnGeometricAverage.Name = "btnGeometricAverage";
            this.btnGeometricAverage.Size = new System.Drawing.Size(188, 41);
            this.btnGeometricAverage.TabIndex = 2;
            this.btnGeometricAverage.Text = "Geomterik Ortalama Hesapla";
            this.btnGeometricAverage.UseVisualStyleBackColor = true;
            this.btnGeometricAverage.Click += new System.EventHandler(this.BtnGeometricAverage_Click);
            // 
            // lstBaseArray
            // 
            this.lstBaseArray.FormattingEnabled = true;
            this.lstBaseArray.Location = new System.Drawing.Point(12, 12);
            this.lstBaseArray.Name = "lstBaseArray";
            this.lstBaseArray.Size = new System.Drawing.Size(186, 368);
            this.lstBaseArray.TabIndex = 3;
            // 
            // lblTotalSumOfArrayItems
            // 
            this.lblTotalSumOfArrayItems.AutoSize = true;
            this.lblTotalSumOfArrayItems.Location = new System.Drawing.Point(204, 170);
            this.lblTotalSumOfArrayItems.Name = "lblTotalSumOfArrayItems";
            this.lblTotalSumOfArrayItems.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSumOfArrayItems.TabIndex = 4;
            // 
            // lblTotalCountOfArray
            // 
            this.lblTotalCountOfArray.AutoSize = true;
            this.lblTotalCountOfArray.Location = new System.Drawing.Point(204, 183);
            this.lblTotalCountOfArray.Name = "lblTotalCountOfArray";
            this.lblTotalCountOfArray.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCountOfArray.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblTotalCountOfArray);
            this.Controls.Add(this.lblTotalSumOfArrayItems);
            this.Controls.Add(this.lstBaseArray);
            this.Controls.Add(this.btnGeometricAverage);
            this.Controls.Add(this.btnHarmonicAverage);
            this.Controls.Add(this.btnArithmeticAverage);
            this.Controls.Add(this.btnPopulate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dizi Elemanlarının Aritmetik, Geometrik, Harmonik Ortalamasını";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnArithmeticAverage;
        private System.Windows.Forms.Button btnHarmonicAverage;
        private System.Windows.Forms.Button btnGeometricAverage;
        private System.Windows.Forms.ListBox lstBaseArray;
        private System.Windows.Forms.Label lblTotalSumOfArrayItems;
        private System.Windows.Forms.Label lblTotalCountOfArray;
    }
}

