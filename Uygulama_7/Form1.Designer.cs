namespace Uygulama_7
{
    partial class frmUygulama7
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
            this.lstFirstArray = new System.Windows.Forms.ListBox();
            this.lstSecondArray = new System.Windows.Forms.ListBox();
            this.btnDizileriDoldur = new System.Windows.Forms.Button();
            this.btnSkalerCarpim = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lstResultArr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFirstArray
            // 
            this.lstFirstArray.FormattingEnabled = true;
            this.lstFirstArray.Location = new System.Drawing.Point(12, 12);
            this.lstFirstArray.Name = "lstFirstArray";
            this.lstFirstArray.Size = new System.Drawing.Size(177, 381);
            this.lstFirstArray.TabIndex = 0;
            // 
            // lstSecondArray
            // 
            this.lstSecondArray.FormattingEnabled = true;
            this.lstSecondArray.Location = new System.Drawing.Point(195, 12);
            this.lstSecondArray.Name = "lstSecondArray";
            this.lstSecondArray.Size = new System.Drawing.Size(177, 381);
            this.lstSecondArray.TabIndex = 0;
            // 
            // btnDizileriDoldur
            // 
            this.btnDizileriDoldur.Location = new System.Drawing.Point(113, 399);
            this.btnDizileriDoldur.Name = "btnDizileriDoldur";
            this.btnDizileriDoldur.Size = new System.Drawing.Size(177, 37);
            this.btnDizileriDoldur.TabIndex = 1;
            this.btnDizileriDoldur.Text = "Dizileri Doldur";
            this.btnDizileriDoldur.UseVisualStyleBackColor = true;
            this.btnDizileriDoldur.Click += new System.EventHandler(this.BtnDizileriDoldur_Click);
            // 
            // btnSkalerCarpim
            // 
            this.btnSkalerCarpim.Location = new System.Drawing.Point(394, 356);
            this.btnSkalerCarpim.Name = "btnSkalerCarpim";
            this.btnSkalerCarpim.Size = new System.Drawing.Size(177, 37);
            this.btnSkalerCarpim.TabIndex = 2;
            this.btnSkalerCarpim.Text = "Skaler Çarpım Al";
            this.btnSkalerCarpim.UseVisualStyleBackColor = true;
            this.btnSkalerCarpim.Click += new System.EventHandler(this.BtnSkalerCarpim_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(391, 411);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(50, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Sonuç: 0";
            // 
            // lstResultArr
            // 
            this.lstResultArr.FormattingEnabled = true;
            this.lstResultArr.Location = new System.Drawing.Point(394, 12);
            this.lstResultArr.Name = "lstResultArr";
            this.lstResultArr.Size = new System.Drawing.Size(177, 342);
            this.lstResultArr.TabIndex = 0;
            // 
            // frmUygulama7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnSkalerCarpim);
            this.Controls.Add(this.btnDizileriDoldur);
            this.Controls.Add(this.lstResultArr);
            this.Controls.Add(this.lstSecondArray);
            this.Controls.Add(this.lstFirstArray);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUygulama7";
            this.Text = "N Elemanlı 2 Dizinin Elemanlarının Skaler Çarpımının Hesaplanması";
            this.Load += new System.EventHandler(this.FrmUygulama7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFirstArray;
        private System.Windows.Forms.ListBox lstSecondArray;
        private System.Windows.Forms.Button btnDizileriDoldur;
        private System.Windows.Forms.Button btnSkalerCarpim;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ListBox lstResultArr;
    }
}

