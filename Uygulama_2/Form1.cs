using System;
using System.Text;
using System.Windows.Forms;

namespace Uygulama_2
{
    public partial class frmUygulama_2 : Form
    {
        private int[] integerArray;

        public frmUygulama_2()
        {
            InitializeComponent();
            integerArray = new int[100];
        }

        private void FrmUygulama_2_Load(object sender, EventArgs e)
        {

        }

        private void BtnDiziyeEkle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxEleman.Text))
            {
                int key = Array.IndexOf(integerArray, 0);
                integerArray[key] = int.Parse(tbxEleman.Text);
            }
            tbxEleman.Clear();
            tbxEleman.Focus();
        }

        private void BtnListeyeAktar_Click(object sender, EventArgs e)
        {
            lstDiziElemanlari.Items.Clear();
            for (int i = 0; i < integerArray.GetUpperBound(0); i++)
            {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (integerArray[i] != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                {
                    lstDiziElemanlari.Items.Add(String.Format("integerArray[{0}] = {1}", i, integerArray[i]));
                }
            }
        }

        private void BtnDiziyiYazdir_Click(object sender, EventArgs e)
        {
            StringBuilder sbd = new StringBuilder();
            for (int i = 0; i < integerArray.GetUpperBound(0); i++)
            {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (integerArray[i] != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                {
                    sbd.AppendLine($"integerArray[{i}] = {integerArray[i]}");
                } else
                {
                    sbd.AppendLine($"integerArray[{i}] = 0");
                }
            }
            MessageBox.Show(sbd.ToString());
        }
    }
}
