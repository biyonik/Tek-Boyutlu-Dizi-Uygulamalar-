namespace Uygulama_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstFirstArray = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSecondArray = new System.Windows.Forms.ListBox();
            this.btnPopulateArrays = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstThirthArray = new System.Windows.Forms.ListBox();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Dizi";
            // 
            // lstFirstArray
            // 
            this.lstFirstArray.FormattingEnabled = true;
            this.lstFirstArray.Location = new System.Drawing.Point(15, 25);
            this.lstFirstArray.Name = "lstFirstArray";
            this.lstFirstArray.Size = new System.Drawing.Size(158, 368);
            this.lstFirstArray.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. Dizi";
            // 
            // lstSecondArray
            // 
            this.lstSecondArray.FormattingEnabled = true;
            this.lstSecondArray.Location = new System.Drawing.Point(212, 26);
            this.lstSecondArray.Name = "lstSecondArray";
            this.lstSecondArray.Size = new System.Drawing.Size(158, 368);
            this.lstSecondArray.TabIndex = 1;
            // 
            // btnPopulateArrays
            // 
            this.btnPopulateArrays.Location = new System.Drawing.Point(15, 400);
            this.btnPopulateArrays.Name = "btnPopulateArrays";
            this.btnPopulateArrays.Size = new System.Drawing.Size(246, 29);
            this.btnPopulateArrays.TabIndex = 2;
            this.btnPopulateArrays.Text = "Dizileri Doldur";
            this.btnPopulateArrays.UseVisualStyleBackColor = true;
            this.btnPopulateArrays.Click += new System.EventHandler(this.BtnPopulateArrays_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oluşan Dizi";
            // 
            // lstThirthArray
            // 
            this.lstThirthArray.FormattingEnabled = true;
            this.lstThirthArray.Location = new System.Drawing.Point(433, 25);
            this.lstThirthArray.Name = "lstThirthArray";
            this.lstThirthArray.Size = new System.Drawing.Size(179, 368);
            this.lstThirthArray.TabIndex = 4;
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(433, 399);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(179, 30);
            this.btnCreateArray.TabIndex = 5;
            this.btnCreateArray.Text = "Diziyi Oluştur";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.BtnCreateArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.lstThirthArray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPopulateArrays);
            this.Controls.Add(this.lstSecondArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstFirstArray);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "N Elemanlı 2 Dizinin Toplanarak 3. Bir Dizi Oluşturmak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFirstArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSecondArray;
        private System.Windows.Forms.Button btnPopulateArrays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstThirthArray;
        private System.Windows.Forms.Button btnCreateArray;
    }
}

