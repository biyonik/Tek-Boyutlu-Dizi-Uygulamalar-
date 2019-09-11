namespace Uygulama_1
{
    partial class frmUygulama_1
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
            this.btnDiziElemanları = new System.Windows.Forms.Button();
            this.lstDiziElemanları = new System.Windows.Forms.ListBox();
            this.btnListeyeAktar = new System.Windows.Forms.Button();
            this.btnDiziyeEkle = new System.Windows.Forms.Button();
            this.tbxEleman = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDiziElemanları
            // 
            this.btnDiziElemanları.Location = new System.Drawing.Point(266, 376);
            this.btnDiziElemanları.Name = "btnDiziElemanları";
            this.btnDiziElemanları.Size = new System.Drawing.Size(248, 33);
            this.btnDiziElemanları.TabIndex = 0;
            this.btnDiziElemanları.Text = "Dizide Saklanan Elemanlar";
            this.btnDiziElemanları.UseVisualStyleBackColor = true;
            this.btnDiziElemanları.Click += new System.EventHandler(this.BtnDiziElemanları_Click);
            // 
            // lstDiziElemanları
            // 
            this.lstDiziElemanları.FormattingEnabled = true;
            this.lstDiziElemanları.Location = new System.Drawing.Point(12, 103);
            this.lstDiziElemanları.Name = "lstDiziElemanları";
            this.lstDiziElemanları.Size = new System.Drawing.Size(248, 264);
            this.lstDiziElemanları.TabIndex = 1;
            // 
            // btnListeyeAktar
            // 
            this.btnListeyeAktar.Location = new System.Drawing.Point(12, 373);
            this.btnListeyeAktar.Name = "btnListeyeAktar";
            this.btnListeyeAktar.Size = new System.Drawing.Size(248, 39);
            this.btnListeyeAktar.TabIndex = 2;
            this.btnListeyeAktar.Text = "Dizi Elemanlarını Listeye Aktar";
            this.btnListeyeAktar.UseVisualStyleBackColor = true;
            this.btnListeyeAktar.Click += new System.EventHandler(this.BtnListeyeAktar_Click);
            // 
            // btnDiziyeEkle
            // 
            this.btnDiziyeEkle.Location = new System.Drawing.Point(12, 64);
            this.btnDiziyeEkle.Name = "btnDiziyeEkle";
            this.btnDiziyeEkle.Size = new System.Drawing.Size(248, 29);
            this.btnDiziyeEkle.TabIndex = 3;
            this.btnDiziyeEkle.Text = "Diziye Ekle";
            this.btnDiziyeEkle.UseVisualStyleBackColor = true;
            this.btnDiziyeEkle.Click += new System.EventHandler(this.BtnDiziyeEkle_Click);
            // 
            // tbxEleman
            // 
            this.tbxEleman.Location = new System.Drawing.Point(12, 24);
            this.tbxEleman.Multiline = true;
            this.tbxEleman.Name = "tbxEleman";
            this.tbxEleman.Size = new System.Drawing.Size(248, 34);
            this.tbxEleman.TabIndex = 4;
            // 
            // frmUygulama_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tbxEleman);
            this.Controls.Add(this.btnDiziyeEkle);
            this.Controls.Add(this.btnListeyeAktar);
            this.Controls.Add(this.lstDiziElemanları);
            this.Controls.Add(this.btnDiziElemanları);
            this.MaximizeBox = false;
            this.Name = "frmUygulama_1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dizi Uygulaması - 1";
            this.Load += new System.EventHandler(this.FrmUygulama_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiziElemanları;
        private System.Windows.Forms.ListBox lstDiziElemanları;
        private System.Windows.Forms.Button btnListeyeAktar;
        private System.Windows.Forms.Button btnDiziyeEkle;
        private System.Windows.Forms.TextBox tbxEleman;
    }
}

