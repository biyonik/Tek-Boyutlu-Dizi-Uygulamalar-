using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_5
{
    public partial class Form1 : Form
    {
        private const int ARRAY_SIZE = 100;
        private int[] intArray;
        private int[] newArray;
        public Form1()
        {
            InitializeComponent();
            intArray = new int[ARRAY_SIZE];
            newArray = new int[ARRAY_SIZE];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void populate(int[] paramArray)
        {
            Random random = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                int item = random.Next(1, 999);
                intArray[i] = item;
            }
        }

        private void BtnDiziyiDoldur_Click(object sender, EventArgs e)
        {
            lstAnaDizi.Items.Clear();
            populate(intArray);
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                lstAnaDizi.Items.Add(String.Format("intArray[{0}] = {1}", i, intArray[i]));
            }
        }

        private void BtnCarpilacakSayi_Click(object sender, EventArgs e)
        {
            lstYeniDizi.Items.Clear();
            if(!string.IsNullOrEmpty(tbxCarpilacakSayi.Text) && lstAnaDizi.Items.Count > 0)
            {
                int distance;
                if(int.TryParse(tbxCarpilacakSayi.Text, out distance))
                {
                    for (int j = 0; j < ARRAY_SIZE; j++)
                    {
                        int newValue = intArray[j] * distance;
                        newArray[j] = newValue;
                    }
                    for (int k = 0; k < ARRAY_SIZE; k++)
                    {
                        lstYeniDizi.Items.Add(String.Format("newArray[{0}] = {1}", k, newArray[k]));
                    }
                } else
                {
                    MessageBox.Show("Lütfen sadece bir numerik değer giriniz");
                }
            } else
            {
                MessageBox.Show("Lütfen önce listeyi doldurun ve çarpılacak sayıyı giriniz");
            }
        }
    }
}
