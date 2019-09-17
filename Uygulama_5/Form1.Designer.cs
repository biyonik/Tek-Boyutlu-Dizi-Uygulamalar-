namespace Uygulama_5
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
            this.lstAnaDizi = new System.Windows.Forms.ListBox();
            this.btnDiziyiDoldur = new System.Windows.Forms.Button();
            this.lstYeniDizi = new System.Windows.Forms.ListBox();
            this.btnCarpilacakSayi = new System.Windows.Forms.Button();
            this.tbxCarpilacakSayi = new System.Windows.Forms.TextBox();
            this.lblCarpilacakSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAnaDizi
            // 
            this.lstAnaDizi.FormattingEnabled = true;
            this.lstAnaDizi.Location = new System.Drawing.Point(12, 12);
            this.lstAnaDizi.Name = "lstAnaDizi";
            this.lstAnaDizi.Size = new System.Drawing.Size(212, 381);
            this.lstAnaDizi.TabIndex = 0;
            // 
            // btnDiziyiDoldur
            // 
            this.btnDiziyiDoldur.Location = new System.Drawing.Point(12, 399);
            this.btnDiziyiDoldur.Name = "btnDiziyiDoldur";
            this.btnDiziyiDoldur.Size = new System.Drawing.Size(212, 23);
            this.btnDiziyiDoldur.TabIndex = 1;
            this.btnDiziyiDoldur.Text = "Listeyi Doldur";
            this.btnDiziyiDoldur.UseVisualStyleBackColor = true;
            this.btnDiziyiDoldur.Click += new System.EventHandler(this.BtnDiziyiDoldur_Click);
            // 
            // lstYeniDizi
            // 
            this.lstYeniDizi.FormattingEnabled = true;
            this.lstYeniDizi.Location = new System.Drawing.Point(400, 12);
            this.lstYeniDizi.Name = "lstYeniDizi";
            this.lstYeniDizi.Size = new System.Drawing.Size(212, 381);
            this.lstYeniDizi.TabIndex = 0;
            // 
            // btnCarpilacakSayi
            // 
            this.btnCarpilacakSayi.Location = new System.Drawing.Point(230, 99);
            this.btnCarpilacakSayi.Name = "btnCarpilacakSayi";
            this.btnCarpilacakSayi.Size = new System.Drawing.Size(164, 23);
            this.btnCarpilacakSayi.TabIndex = 2;
            this.btnCarpilacakSayi.Text = "Çarp ve Dizi Oluştur";
            this.btnCarpilacakSayi.UseVisualStyleBackColor = true;
            this.btnCarpilacakSayi.Click += new System.EventHandler(this.BtnCarpilacakSayi_Click);
            // 
            // tbxCarpilacakSayi
            // 
            this.tbxCarpilacakSayi.Location = new System.Drawing.Point(230, 73);
            this.tbxCarpilacakSayi.Name = "tbxCarpilacakSayi";
            this.tbxCarpilacakSayi.Size = new System.Drawing.Size(164, 20);
            this.tbxCarpilacakSayi.TabIndex = 3;
            // 
            // lblCarpilacakSayi
            // 
            this.lblCarpilacakSayi.AutoSize = true;
            this.lblCarpilacakSayi.Location = new System.Drawing.Point(230, 57);
            this.lblCarpilacakSayi.Name = "lblCarpilacakSayi";
            this.lblCarpilacakSayi.Size = new System.Drawing.Size(80, 13);
            this.lblCarpilacakSayi.TabIndex = 4;
            this.lblCarpilacakSayi.Text = "Çarpılacak Sayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblCarpilacakSayi);
            this.Controls.Add(this.tbxCarpilacakSayi);
            this.Controls.Add(this.btnCarpilacakSayi);
            this.Controls.Add(this.btnDiziyiDoldur);
            this.Controls.Add(this.lstYeniDizi);
            this.Controls.Add(this.lstAnaDizi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N Elemanlı Bir Dizinin Elemanlarını K İle Çarpıp, Dizi Oluşturmak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAnaDizi;
        private System.Windows.Forms.Button btnDiziyiDoldur;
        private System.Windows.Forms.ListBox lstYeniDizi;
        private System.Windows.Forms.Button btnCarpilacakSayi;
        private System.Windows.Forms.TextBox tbxCarpilacakSayi;
        private System.Windows.Forms.Label lblCarpilacakSayi;
    }
}

