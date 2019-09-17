namespace Uygulama_6
{
    partial class frmUygulama6
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
            this.lstTemelDizi = new System.Windows.Forms.ListBox();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.lstSiralanmisDizi = new System.Windows.Forms.ListBox();
            this.btnSirala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTemelDizi
            // 
            this.lstTemelDizi.FormattingEnabled = true;
            this.lstTemelDizi.Location = new System.Drawing.Point(12, 12);
            this.lstTemelDizi.Name = "lstTemelDizi";
            this.lstTemelDizi.Size = new System.Drawing.Size(212, 368);
            this.lstTemelDizi.TabIndex = 0;
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(12, 386);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(212, 43);
            this.btnDoldur.TabIndex = 1;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.BtnDoldur_Click);
            // 
            // lstSiralanmisDizi
            // 
            this.lstSiralanmisDizi.FormattingEnabled = true;
            this.lstSiralanmisDizi.Location = new System.Drawing.Point(400, 12);
            this.lstSiralanmisDizi.Name = "lstSiralanmisDizi";
            this.lstSiralanmisDizi.Size = new System.Drawing.Size(212, 368);
            this.lstSiralanmisDizi.TabIndex = 0;
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(400, 386);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(212, 43);
            this.btnSirala.TabIndex = 1;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.BtnSirala_Click);
            // 
            // frmUygulama6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.lstSiralanmisDizi);
            this.Controls.Add(this.lstTemelDizi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUygulama6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N Elemanlı Bir Diziyi Tersten Sıralayıp Yeni Bir Diziye Aktarma";
            this.Load += new System.EventHandler(this.FrmUygulama6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTemelDizi;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.ListBox lstSiralanmisDizi;
        private System.Windows.Forms.Button btnSirala;
    }
}

