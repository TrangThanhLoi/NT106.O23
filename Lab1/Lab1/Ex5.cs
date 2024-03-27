using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        public static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static long Sum(int a, int b)
        {
            return Enumerable.Range(1, b).Select(i => (long)Math.Pow(a, i)).Sum();
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if (string.IsNullOrEmpty(textBoxInput1.Text) || string.IsNullOrEmpty(textBoxInput2.Text))
            {
                MessageBox.Show("Chưa có dữ liệu, Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Int32.TryParse(textBoxInput1.Text, out num1) || !Int32.TryParse(textBoxInput2.Text, out num2))
            {
                MessageBox.Show("Dữ liệu ở dạng số, Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Chưa lựa chọn loại tính toán, Vui lòng chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Bảng Cửu Chương ( B - A )")
            {
                int multi = int.Parse(textBoxInput2.Text) - int.Parse(textBoxInput1.Text);
                StringBuilder multiplicationTable = new StringBuilder();
                for (int i = 1; i <= 10; i++)
                {
                    multiplicationTable.AppendLine($"{multi} x {i} = {multi * i}");
                }

                textBoxResult.Text = multiplicationTable.ToString();
            }
            else
            {
                int facto = int.Parse(textBoxInput1.Text) - int.Parse(textBoxInput2.Text);
                int A = int.Parse(textBoxInput1.Text);
                int B = int.Parse(textBoxInput2.Text);

                textBoxResult.Text = "(A - B)! = " + Factorial(facto).ToString() + Environment.NewLine
                    + "S = A^1 + A^2 + A^3 + ... + A^B = " + CalculateSumOfPowers(A, B).ToString();

                int Factorial(int n)
                {
                    if (n == 0)
                        return 1;
                    return n * Factorial(n - 1);
                }

                int CalculateSumOfPowers(int baseNum, int power)
                {
                    int sum = 0;
                    int currentPower = 1;
                    for (int i = 1; i <= power; i++)
                    {
                        currentPower *= baseNum;
                        sum += currentPower;
                    }
                    return sum;
                }
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            textBoxInput1.Text = string.Empty;
            textBoxInput2.Text = string.Empty;
            textBoxResult.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex5_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
