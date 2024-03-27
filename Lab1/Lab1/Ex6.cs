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
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int day, month;
            string resultMessage = "";

            try
            {
                if (!int.TryParse(textBoxDay.Text, out day) || !int.TryParse(textBoxMonth.Text, out month))
                {
                    MessageBox.Show("Đầu vào không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Tháng không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (day < 1 || day > DateTime.DaysInMonth(DateTime.Now.Year, month))
                {
                    MessageBox.Show("Ngày tháng này không tồn tại. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
                    resultMessage = "Bảo Bình";
                else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
                    resultMessage = "Song Ngư";
                else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                    resultMessage = "Bạch Dương";
                else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
                    resultMessage = "Kim Ngưu";
                else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
                    resultMessage = "Song Tử";
                else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                    resultMessage = "Cự Giải";
                else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                    resultMessage = "Sư Tử";
                else if ((month == 8 && day >= 23) || (month == 9 && day <= 23))
                    resultMessage = "Xử Nữ";
                else if ((month == 9 && day >= 24) || (month == 10 && day <= 23))
                    resultMessage = "Thiên Bình";
                else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
                    resultMessage = "Thần Nông";
                else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
                    resultMessage = "Nhân Mã";
                else
                    resultMessage = "Ma Kết";
            }
            catch (FormatException)
            {
                MessageBox.Show("Đầu vào không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxResult.Text = resultMessage;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDay.Text = string.Empty;
            textBoxMonth.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex6_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void Ex6_Load(object sender, EventArgs e)
        {

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
