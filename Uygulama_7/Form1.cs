using System;
using System.Threading;
using System.Windows.Forms;

namespace Uygulama_7
{
    public partial class frmUygulama7 : Form
    {
        private const int ARRAY_SIZE = 10;
        private int[] firstArray;
        private int[] secondArray;
        public frmUygulama7()
        {
            InitializeComponent();
            firstArray = new int[ARRAY_SIZE];
            secondArray = new int[ARRAY_SIZE];
        }

        private void FrmUygulama7_Load(object sender, EventArgs e)
        {

        }


        private int[] populate(int[] paramArr)
        {
            Random random = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                int item = random.Next(-5, 5);
                paramArr[i] = item; 
            }
            return paramArr;
        }

        private void clearListView()
        {
            lstFirstArray.Items.Clear();
            lstSecondArray.Items.Clear();
        }

        private void BtnDizileriDoldur_Click(object sender, EventArgs e)
        {
            clearListView();
            for (int i = 0; i < (populate(firstArray) as Array).Length; i++)
            {
                lstFirstArray.Items.Add($"firstArray[{i}] = {firstArray[i]}");
            }
            Thread.Sleep(100);
            for (int k = 0; k < (populate(secondArray) as Array).Length; k++)
            {
                lstSecondArray.Items.Add($"secondArray[{k}] = {secondArray[k]}");
            }
        }

        private void BtnSkalerCarpim_Click(object sender, EventArgs e)
        {
            lstResultArr.Items.Clear();
            int result = 0;
            if(lstFirstArray.Items.Count >0 && lstSecondArray.Items.Count > 0)
            {
                for (int i = 0; i < ARRAY_SIZE; i++)
                {
                    result += firstArray[i] * secondArray[i];
                    lstResultArr.Items.Add($"firstArray[{i}] * secondArray[{i}] = {firstArray[i] * secondArray[i]}");
                }
                lblSonuc.Text = $"Sonuç: {result.ToString()}";
            } else
            {
                MessageBox.Show("Lütfen önce listeleri doldurunuz","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
