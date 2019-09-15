namespace Uygulama_3
{
    partial class frmUygulama_3
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
            this.btnListeyeAktar = new System.Windows.Forms.Button();
            this.lstDiziElemanlari = new System.Windows.Forms.ListBox();
            this.btnElemanlariTopla = new System.Windows.Forms.Button();
            this.btnKaresiniTopla = new System.Windows.Forms.Button();
            this.btnKupunuTopla = new System.Windows.Forms.Button();
            this.btnTekrarOluştur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListeyeAktar
            // 
            this.btnListeyeAktar.Location = new System.Drawing.Point(12, 12);
            this.btnListeyeAktar.Name = "btnListeyeAktar";
            this.btnListeyeAktar.Size = new System.Drawing.Size(130, 37);
            this.btnListeyeAktar.TabIndex = 0;
            this.btnListeyeAktar.Text = "Listeye Aktar";
            this.btnListeyeAktar.UseVisualStyleBackColor = true;
            this.btnListeyeAktar.Click += new System.EventHandler(this.BtnListeyeAktar_Click);
            // 
            // lstDiziElemanlari
            // 
            this.lstDiziElemanlari.FormattingEnabled = true;
            this.lstDiziElemanlari.Location = new System.Drawing.Point(12, 55);
            this.lstDiziElemanlari.Name = "lstDiziElemanlari";
            this.lstDiziElemanlari.Size = new System.Drawing.Size(277, 368);
            this.lstDiziElemanlari.TabIndex = 1;
            // 
            // btnElemanlariTopla
            // 
            this.btnElemanlariTopla.Location = new System.Drawing.Point(313, 12);
            this.btnElemanlariTopla.Name = "btnElemanlariTopla";
            this.btnElemanlariTopla.Size = new System.Drawing.Size(299, 37);
            this.btnElemanlariTopla.TabIndex = 2;
            this.btnElemanlariTopla.Text = "Dizi Elemanlarını Topla";
            this.btnElemanlariTopla.UseVisualStyleBackColor = true;
            this.btnElemanlariTopla.Click += new System.EventHandler(this.BtnElemanlariTopla_Click);
            // 
            // btnKaresiniTopla
            // 
            this.btnKaresiniTopla.Location = new System.Drawing.Point(313, 55);
            this.btnKaresiniTopla.Name = "btnKaresiniTopla";
            this.btnKaresiniTopla.Size = new System.Drawing.Size(299, 37);
            this.btnKaresiniTopla.TabIndex = 2;
            this.btnKaresiniTopla.Text = "Dizi Elemanlarının Karesini Topla";
            this.btnKaresiniTopla.UseVisualStyleBackColor = true;
            this.btnKaresiniTopla.Click += new System.EventHandler(this.BtnKaresiniTopla_Click);
            // 
            // btnKupunuTopla
            // 
            this.btnKupunuTopla.Location = new System.Drawing.Point(313, 98);
            this.btnKupunuTopla.Name = "btnKupunuTopla";
            this.btnKupunuTopla.Size = new System.Drawing.Size(299, 37);
            this.btnKupunuTopla.TabIndex = 2;
            this.btnKupunuTopla.Text = "Dizi Elemanlarının Küpünü Topla";
            this.btnKupunuTopla.UseVisualStyleBackColor = true;
            this.btnKupunuTopla.Click += new System.EventHandler(this.BtnKupunuTopla_Click);
            // 
            // btnTekrarOluştur
            // 
            this.btnTekrarOluştur.Location = new System.Drawing.Point(148, 12);
            this.btnTekrarOluştur.Name = "btnTekrarOluştur";
            this.btnTekrarOluştur.Size = new System.Drawing.Size(141, 37);
            this.btnTekrarOluştur.TabIndex = 0;
            this.btnTekrarOluştur.Text = "Diziyi Tekrar Oluştur";
            this.btnTekrarOluştur.UseVisualStyleBackColor = true;
            this.btnTekrarOluştur.Click += new System.EventHandler(this.BtnTekrarOluştur_Click);
            // 
            // frmUygulama_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnKupunuTopla);
            this.Controls.Add(this.btnKaresiniTopla);
            this.Controls.Add(this.btnElemanlariTopla);
            this.Controls.Add(this.lstDiziElemanlari);
            this.Controls.Add(this.btnTekrarOluştur);
            this.Controls.Add(this.btnListeyeAktar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUygulama_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N Elemanlı Dizinin Elemanlarının Toplamı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListeyeAktar;
        private System.Windows.Forms.ListBox lstDiziElemanlari;
        private System.Windows.Forms.Button btnElemanlariTopla;
        private System.Windows.Forms.Button btnKaresiniTopla;
        private System.Windows.Forms.Button btnKupunuTopla;
        private System.Windows.Forms.Button btnTekrarOluştur;
    }
}

