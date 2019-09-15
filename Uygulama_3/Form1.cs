using System;
using System.Windows.Forms;

namespace Uygulama_3
{
    public partial class frmUygulama_3 : Form
    {
        public const int ARRAY_SIZE = 100;
        public int[] intArray { get; set; }
        public enum CalculateType
        {
            ElemanToplamı = 1,
            KaresininToplamı = 2,
            KupununToplamı = 3
        }

        public frmUygulama_3()
        {
            InitializeComponent();

            intArray = new int[ARRAY_SIZE];
            populate();
        }

        private void populate()
        {
            Random random = new Random();

            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(10,100);
            }
        }

        private void BtnListeyeAktar_Click(object sender, EventArgs e)
        {
            lstDiziElemanlari.Items.Clear();
            for (int i = 0; i < intArray.Length; i++)
            {
                lstDiziElemanlari.Items.Add(String.Format("intArray[{0}] = {1}", i, intArray[i]));
            }
        }

        private int totalValueOfArray(int[] param, CalculateType hesaplamaTipi)
        {
            int result = 0;
            switch(hesaplamaTipi)
            {
                case CalculateType.ElemanToplamı:
                    foreach (int item in param)
                    {
                        result += item;
                    }
                    return result;
                case CalculateType.KaresininToplamı:
                    foreach (int item in param)
                    {
                        result += Convert.ToInt32(Math.Pow(item,2));
                    }
                    return result;
                case CalculateType.KupununToplamı:
                    foreach (int item in param)
                    {
                        result += Convert.ToInt32(Math.Pow(item, 3));
                    }
                    return result;
                default:
                    return result;

            }
            
        }

        private void BtnElemanlariTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dizi Elemanlarının Toplamı...: {totalValueOfArray(intArray, CalculateType.ElemanToplamı)}");
        }

        private void BtnKaresiniTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dizi Elemanlarının Toplamı...: {totalValueOfArray(intArray, CalculateType.KaresininToplamı)}");
        }

        private void BtnKupunuTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dizi Elemanlarının Toplamı...: {totalValueOfArray(intArray, CalculateType.KupununToplamı)}");
        }

        private void clearArrayValue(int[] param)
        {
            Array.Clear(param, 0, ARRAY_SIZE);
        }

        private void BtnTekrarOluştur_Click(object sender, EventArgs e)
        {
            clearArrayValue(intArray);
            populate();
            BtnListeyeAktar_Click(sender, e);
        }
    }
}
