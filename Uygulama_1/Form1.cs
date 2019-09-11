using System;
using System.Text;
using System.Windows.Forms;

namespace Uygulama_1
{
    public partial class frmUygulama_1 : Form
    {
        private string[] stringArray;
        public frmUygulama_1()
        {
            InitializeComponent();
            stringArray = new string[100];
        }

        private void FrmUygulama_1_Load(object sender, EventArgs e)
        {
        }

        private void BtnDiziElemanları_Click(object sender, EventArgs e)
        {
            StringBuilder sbd = new StringBuilder();
            for (int i = 0; i < stringArray.Length; i++)
            {
                if(stringArray[i] != null)
                {
                    sbd.AppendLine(String.Format("stringArray[{0}] = {1}", i, stringArray[i]));
                } else {
                    sbd.AppendLine(String.Format("stringArray[{0}] = null", i));
                }
                
            }
            MessageBox.Show(sbd.ToString());
        }

        private void BtnListeyeAktar_Click(object sender, EventArgs e)
        {
            lstDiziElemanları.Items.Clear();

            for (int j = 0; j < stringArray.GetUpperBound(0); j++)
            {
                if(stringArray[j] != null)
                {
                    lstDiziElemanları.Items.Add($"stringArray[{j}] = {stringArray[j]}");
                }
            }
        }

        private void BtnDiziyeEkle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxEleman.Text))
            {
                int key = Array.IndexOf(stringArray, null);
                stringArray[key] = tbxEleman.Text;
            }
            tbxEleman.Clear();
            tbxEleman.Focus();
        }
    }
}
