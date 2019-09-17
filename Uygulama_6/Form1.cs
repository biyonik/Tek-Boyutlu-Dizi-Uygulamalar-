using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_6
{
    public partial class frmUygulama6 : Form
    {
        private const int ARRAY_SIZE = 100;
        private int[] intArray;
        private int[] newArray;
        public frmUygulama6()
        {
            InitializeComponent();
            intArray = new int[ARRAY_SIZE];
            newArray = new int[ARRAY_SIZE];
        }

        private void FrmUygulama6_Load(object sender, EventArgs e)
        {

        }

        private void populate(int[] paramArray)
        {
            Random random = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                int item = random.Next(1, 999);
                paramArray[i] = item;
            }
        }

        private void BtnDoldur_Click(object sender, EventArgs e)
        {
            lstTemelDizi.Items.Clear();
            populate(intArray);
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                lstTemelDizi.Items.Add($"intArray[{i}] = {intArray[i]}");
            }
        }

        private void BtnSirala_Click(object sender, EventArgs e)
        {
            lstSiralanmisDizi.Items.Clear();
            if(lstTemelDizi.Items.Count > 0)
            {
                newArray = sortArray(intArray);
                for (int i = 0; i < ARRAY_SIZE; i++)
                {
                    lstSiralanmisDizi.Items.Add($"newArray[{i}] = {newArray[i]}");
                }
            } else
            {
                MessageBox.Show("Lütfen önce temel listeyi doldurun!");
            }
        }

        private int[] sortArray(int[] paramArray)
        {

            int itemCount = paramArray.Length;
            for (int i = 0; i < itemCount/2; i++)
            {
                int tempItem = paramArray[i];
                paramArray[i] = paramArray[itemCount - i - 1];
                paramArray[itemCount - i - 1] = tempItem;
            }
            return paramArray;
        }
    }
}
