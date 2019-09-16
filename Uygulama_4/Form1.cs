using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_4
{
    public partial class Form1 : Form
    {
        public const int ARRAY_SIZE = 100;
        public int[] firstArray { get; set; }
        public int[] secondArray { get; set; }
        public int[] thirthArray { get; set; }

        public Form1()
        {
            InitializeComponent();
            firstArray = new int[ARRAY_SIZE];
            secondArray = new int[ARRAY_SIZE];
            thirthArray = new int[ARRAY_SIZE];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int[] populateArray()
        {
            int[] paramArray = new int[ARRAY_SIZE];
            Random random = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                paramArray[i] = random.Next(0, 999);
            }
            return paramArray;
        }

        private void populateFirstArray()
        {
            firstArray = populateArray();
        }

        private void populateSecondArray()
        {
            secondArray = populateArray();
        }

        private int[] createArrayFromTotalItemValuesOfOtherArray(int[] firstArr, int[] seconArr)
        {
            int[] resultArr = new int[ARRAY_SIZE];
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                resultArr[i] = firstArr[i] + seconArr[i];
            }
            return resultArr;
        }

        private void BtnPopulateArrays_Click(object sender, EventArgs e)
        {
            lstFirstArray.Items.Clear();
            lstSecondArray.Items.Clear();
            populateFirstArray();

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                lstFirstArray.Items.Add(String.Format("firstArray[{0}] = {1}", i, firstArray[i]));
            }

            populateSecondArray();
            for (int j = 0; j < ARRAY_SIZE; j++)
            {
                lstSecondArray.Items.Add(String.Format("secondArray[{0}] = {1}", j, secondArray[j]));
            }
        }

        private void BtnCreateArray_Click(object sender, EventArgs e)
        {
            thirthArray = createArrayFromTotalItemValuesOfOtherArray(firstArray, secondArray);
            lstThirthArray.Items.Clear();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                lstThirthArray.Items.Add(String.Format("thirthArray[{0}] = {1}", i, thirthArray[i]));
            }
        }
    }
}
