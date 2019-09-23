namespace Uygulama_9
{
    partial class frmUygulama9
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
            this.lstArrayItems = new System.Windows.Forms.ListBox();
            this.btnPopulateArray = new System.Windows.Forms.Button();
            this.lblArrayItemCount = new System.Windows.Forms.Label();
            this.lblMinimumItemOfArray = new System.Windows.Forms.Label();
            this.lblMaximumItemOfArray = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstArrayItems
            // 
            this.lstArrayItems.FormattingEnabled = true;
            this.lstArrayItems.Location = new System.Drawing.Point(12, 12);
            this.lstArrayItems.Name = "lstArrayItems";
            this.lstArrayItems.Size = new System.Drawing.Size(209, 407);
            this.lstArrayItems.TabIndex = 0;
            // 
            // btnPopulateArray
            // 
            this.btnPopulateArray.Location = new System.Drawing.Point(227, 12);
            this.btnPopulateArray.Name = "btnPopulateArray";
            this.btnPopulateArray.Size = new System.Drawing.Size(385, 42);
            this.btnPopulateArray.TabIndex = 1;
            this.btnPopulateArray.Text = "Diziyi Doldur ve Listele";
            this.btnPopulateArray.UseVisualStyleBackColor = true;
            this.btnPopulateArray.Click += new System.EventHandler(this.BtnPopulateArray_Click);
            // 
            // lblArrayItemCount
            // 
            this.lblArrayItemCount.AutoSize = true;
            this.lblArrayItemCount.Location = new System.Drawing.Point(227, 79);
            this.lblArrayItemCount.Name = "lblArrayItemCount";
            this.lblArrayItemCount.Size = new System.Drawing.Size(112, 13);
            this.lblArrayItemCount.TabIndex = 2;
            this.lblArrayItemCount.Text = "Dizinin Eleman Sayısı: ";
            // 
            // lblMinimumItemOfArray
            // 
            this.lblMinimumItemOfArray.AutoSize = true;
            this.lblMinimumItemOfArray.Location = new System.Drawing.Point(227, 106);
            this.lblMinimumItemOfArray.Name = "lblMinimumItemOfArray";
            this.lblMinimumItemOfArray.Size = new System.Drawing.Size(140, 13);
            this.lblMinimumItemOfArray.TabIndex = 2;
            this.lblMinimumItemOfArray.Text = "En Küçük Eleman ve İndisi: ";
            // 
            // lblMaximumItemOfArray
            // 
            this.lblMaximumItemOfArray.AutoSize = true;
            this.lblMaximumItemOfArray.Location = new System.Drawing.Point(227, 134);
            this.lblMaximumItemOfArray.Name = "lblMaximumItemOfArray";
            this.lblMaximumItemOfArray.Size = new System.Drawing.Size(139, 13);
            this.lblMaximumItemOfArray.TabIndex = 2;
            this.lblMaximumItemOfArray.Text = "En Büyük Eleman ve İndisi: ";
            // 
            // frmUygulama9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblMaximumItemOfArray);
            this.Controls.Add(this.lblMinimumItemOfArray);
            this.Controls.Add(this.lblArrayItemCount);
            this.Controls.Add(this.btnPopulateArray);
            this.Controls.Add(this.lstArrayItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUygulama9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N Elemanlı Dizinin En Büyük ve En Küçük Elemanlarının İndislerinin Bulunması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArrayItems;
        private System.Windows.Forms.Button btnPopulateArray;
        private System.Windows.Forms.Label lblArrayItemCount;
        private System.Windows.Forms.Label lblMinimumItemOfArray;
        private System.Windows.Forms.Label lblMaximumItemOfArray;
    }
}

