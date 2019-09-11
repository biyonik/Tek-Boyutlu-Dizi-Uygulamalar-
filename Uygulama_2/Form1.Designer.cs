namespace Uygulama_2
{
    partial class frmUygulama_2
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
            this.lstDiziElemanlari = new System.Windows.Forms.ListBox();
            this.tbxEleman = new System.Windows.Forms.TextBox();
            this.btnDiziyeEkle = new System.Windows.Forms.Button();
            this.btnListeyeAktar = new System.Windows.Forms.Button();
            this.btnDiziyiYazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDiziElemanlari
            // 
            this.lstDiziElemanlari.FormattingEnabled = true;
            this.lstDiziElemanlari.Location = new System.Drawing.Point(12, 103);
            this.lstDiziElemanlari.Name = "lstDiziElemanlari";
            this.lstDiziElemanlari.Size = new System.Drawing.Size(365, 615);
            this.lstDiziElemanlari.TabIndex = 0;
            // 
            // tbxEleman
            // 
            this.tbxEleman.Location = new System.Drawing.Point(12, 12);
            this.tbxEleman.Multiline = true;
            this.tbxEleman.Name = "tbxEleman";
            this.tbxEleman.Size = new System.Drawing.Size(365, 35);
            this.tbxEleman.TabIndex = 1;
            // 
            // btnDiziyeEkle
            // 
            this.btnDiziyeEkle.Location = new System.Drawing.Point(12, 53);
            this.btnDiziyeEkle.Name = "btnDiziyeEkle";
            this.btnDiziyeEkle.Size = new System.Drawing.Size(365, 38);
            this.btnDiziyeEkle.TabIndex = 2;
            this.btnDiziyeEkle.Text = "Diziye Ekle";
            this.btnDiziyeEkle.UseVisualStyleBackColor = true;
            this.btnDiziyeEkle.Click += new System.EventHandler(this.BtnDiziyeEkle_Click);
            // 
            // btnListeyeAktar
            // 
            this.btnListeyeAktar.Location = new System.Drawing.Point(383, 12);
            this.btnListeyeAktar.Name = "btnListeyeAktar";
            this.btnListeyeAktar.Size = new System.Drawing.Size(304, 35);
            this.btnListeyeAktar.TabIndex = 3;
            this.btnListeyeAktar.Text = "Listeye Aktar";
            this.btnListeyeAktar.UseVisualStyleBackColor = true;
            this.btnListeyeAktar.Click += new System.EventHandler(this.BtnListeyeAktar_Click);
            // 
            // btnDiziyiYazdir
            // 
            this.btnDiziyiYazdir.Location = new System.Drawing.Point(383, 56);
            this.btnDiziyiYazdir.Name = "btnDiziyiYazdir";
            this.btnDiziyiYazdir.Size = new System.Drawing.Size(304, 35);
            this.btnDiziyiYazdir.TabIndex = 3;
            this.btnDiziyiYazdir.Text = "Dizi Elemanlarını Yazdır";
            this.btnDiziyiYazdir.UseVisualStyleBackColor = true;
            this.btnDiziyiYazdir.Click += new System.EventHandler(this.BtnDiziyiYazdir_Click);
            // 
            // frmUygulama_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 729);
            this.Controls.Add(this.btnDiziyiYazdir);
            this.Controls.Add(this.btnListeyeAktar);
            this.Controls.Add(this.btnDiziyeEkle);
            this.Controls.Add(this.tbxEleman);
            this.Controls.Add(this.lstDiziElemanlari);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUygulama_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama 2";
            this.Load += new System.EventHandler(this.FrmUygulama_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDiziElemanlari;
        private System.Windows.Forms.TextBox tbxEleman;
        private System.Windows.Forms.Button btnDiziyeEkle;
        private System.Windows.Forms.Button btnListeyeAktar;
        private System.Windows.Forms.Button btnDiziyiYazdir;
    }
}

