using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_9
{
    public partial class frmUygulama9 : Form
    {
        private const int ARRAY_SIZE = 100;
        private int[] intArr = null;
        public frmUygulama9()
        {
            InitializeComponent();
            intArr = new int[ARRAY_SIZE];
        }

        private static int[] populate()
        {
            int[] pArr = new int[ARRAY_SIZE];
            Random random = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                int item = random.Next(1, 999);
                pArr[i] = item;
            }
            //Array.Copy(pArr, 0, paramArray, 0, ARRAY_SIZE);
            return pArr;
        } 

        private void BtnPopulateArray_Click(object sender, EventArgs e)
        {
            lstArrayItems.Items.Clear();
            Array.Copy(populate(), 0, intArr, 0, ARRAY_SIZE);
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                lstArrayItems.Items.Add($"intArray[{i}] = {intArr[i]}");
            }
            lblArrayItemCount.Text = $"Dizinin Eleman Sayısı: {ARRAY_SIZE}";
            lblMinimumItemOfArray.Text = $"En Küçük Eleman: {minimumItemOfArray(intArr).value} ve İndisi: {minimumItemOfArray(intArr).index}";
            lblMaximumItemOfArray.Text = $"En Büyük Eleman: {maximumItemOfArray(intArr).value} ve İndisi: {maximumItemOfArray(intArr).index}";
        }

        private ArrayInfo minimumItemOfArray(int[] paramArr)
        {
            int index = 0, value=0;
            int minItem = paramArr[0];
            for (int i = 1; i < paramArr.Length; i++)
            {
                if(paramArr[i] < minItem)
                {
                    minItem = paramArr[i];
                    index = i;
                    value = minItem;
                }
                
            }
            return new ArrayInfo(index, value);
        }

        private ArrayInfo maximumItemOfArray(int[] paramArr)
        {
            int index = 0, value = 0;
            int maxItem = paramArr[0];
            for (int i = 1; i < paramArr.Length; i++)
            {
                if (paramArr[i] > maxItem)
                {
                    maxItem = paramArr[i];
                    index = i;
                    value = maxItem;
                }

            }
            return new ArrayInfo(index, value);
        }
    }

    class ArrayInfo
    {
        public int index { get; set; }
        public int value { get; set; }

        public ArrayInfo()
        {

        }

        public ArrayInfo(int index, int value)
        {
            this.index = index;
            this.value = value;
        }
    }
}
