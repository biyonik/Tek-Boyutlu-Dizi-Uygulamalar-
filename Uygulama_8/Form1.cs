using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_8
{
    
    public partial class Form1 : Form
    {
        private const int ARRAY_SIZE = 50;
        private int[] intArray;
        private enum CalculateType
        {
            Arithmetic = 1,
            Harmonic = 2,
            Geometric = 3
        }
        public Form1()
        {
            InitializeComponent();
            intArray = new int[ARRAY_SIZE];
        }

        private void populate(int[] paramArray)
        {
            Random rnd = new Random();
            for (int i = 0; i < paramArray.Length; i++)
            {
                int item = rnd.Next(1, 99);
                paramArray[i] = item;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int arithmeticAverage(int[] paramArr)
        {
            int sum = 0;
            int count = paramArr.Length;
            for (int i = 0; i < paramArr.Length; i++)
            {
                sum += paramArr[i];
            }
            return sum / count;
        }

        private double geometricAverage(int[] paramArr)
        {
            int multiplication = 0;
            int count = paramArr.Length;
            for (int i = 0; i < paramArr.Length; i++)
            {
                multiplication *= paramArr[i];
            }
            return Math.Pow(multiplication, 1 / count);
        }

        private double harmonicAverage(int[] paramArr)
        {
            double harmonic = 0;
            int count = paramArr.Length;
            for (int i = 0; i < paramArr.Length; i++)
            {
                harmonic += 1/paramArr[i];
            }
            return paramArr.Length / harmonic;
        }

        private double calculateAverage(int[] paramArray, CalculateType calculateType)
        {
            double result = 0;
            if(calculateType == CalculateType.Arithmetic)
            {
                result = arithmeticAverage(paramArr: paramArray);
            } else if(calculateType == CalculateType.Geometric)
            {
                result = geometricAverage(paramArr: paramArray);
            } else if(calculateType == CalculateType.Harmonic)
            {
                result = harmonicAverage(paramArr: paramArray);
            }
            return result;
        }

        private void BtnPopulate_Click(object sender, EventArgs e)
        {
            lstBaseArray.Items.Clear();
            populate(intArray);
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                lstBaseArray.Items.Add(String.Format("intArray[{0}] = {1}", i, intArray[i]));
                sum += intArray[i];
            }
            lblTotalSumOfArrayItems.Text = $"Dizi Elemanlarının Toplamı: {sum}";
            lblTotalCountOfArray.Text = $"Dizinin Eleman Sayısı: {intArray.Length}";
        }

        private void BtnArithmeticAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Dizinin aritmetik ortalaması: {0:0.00}", calculateAverage(intArray, CalculateType.Arithmetic).ToString()));
        }

        private void BtnHarmonicAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Dizinin harmonik ortalaması: {0:0.00}", calculateAverage(intArray, CalculateType.Harmonic).ToString()));
        }

        private void BtnGeometricAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Dizinin geometrik ortalaması: {0:0.00}", calculateAverage(intArray, CalculateType.Geometric).ToString()));
        }
    }
}
