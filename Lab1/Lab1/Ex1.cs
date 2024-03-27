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
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            int num1, num2;

            try
            {
                if (string.IsNullOrEmpty(textBoxNum1.Text) || string.IsNullOrEmpty(textBoxNum2.Text))
                {
                    MessageBox.Show("Chưa có dữ liệu ,vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                num1 = int.Parse(textBoxNum1.Text);
                num2 = int.Parse(textBoxNum2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxSum.Text = (num1 + num2).ToString();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            textBoxNum1.Text = string.Empty;
            textBoxNum2.Text = string.Empty;
            textBoxSum.Text = string.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Ex1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void lb_res_Click(object sender, EventArgs e)
        {

        }

        private void lb_enterNum1_Click(object sender, EventArgs e)
        {

        }

        private void lb_EnterNum2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
