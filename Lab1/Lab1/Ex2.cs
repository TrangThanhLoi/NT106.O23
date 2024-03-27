using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            try
            {
                if (string.IsNullOrEmpty(textBoxNum1.Text) || string.IsNullOrEmpty(textBoxNum2.Text) || string.IsNullOrEmpty(textBoxNum3.Text))
                {
                    MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                num1 = double.Parse(textBoxNum1.Text);
                num2 = double.Parse(textBoxNum2.Text);
                num3 = double.Parse(textBoxNum3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] numArray = new double[] { num1, num2, num3 };
            textBoxMin.Text = numArray.Min().ToString();
            textBoxMax.Text = numArray.Max().ToString();

        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            textBoxNum1.Text = string.Empty;
            textBoxNum2.Text = string.Empty;
            textBoxNum3.Text = string.Empty;
            textBoxMax.Text = string.Empty;
            textBoxMin.Text = string.Empty;
        }
        private void Ex2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNum3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ex2_Load(object sender, EventArgs e)
        {

        }
    }
}
