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
    public partial class Ex3_1 : Form
    {
        public Ex3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = textBoxInput.Text.Trim();
                if (!string.IsNullOrEmpty(inputText))
                {
                    long num = long.Parse(inputText);
                    string vietnameseText = ConvertToVietnamese(num);
                    textBoxResult.Text = vietnameseText;
                }
                else
                {
                    MessageBox.Show("Chưa nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số quá lớn. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConvertToVietnamese(long num)
        {
            if (num == 0)
            {
                return "Không";
            }

            string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] units = { "", "Nghìn", "Triệu", "Tỷ" };

            StringBuilder result = new StringBuilder();
            int unitIndex = 0;
            bool firstGroup = true;

            while (num > 0)
            {
                long currentGroup = num % 1000;
                if (currentGroup > 0)
                {
                    if (!firstGroup)
                    {
                        result.Insert(0, " ");
                    }
                    if (unitIndex > 0)
                    {
                        result.Insert(0, ConvertGroup(currentGroup, ones) + " " + units[unitIndex]);
                    }
                    else
                    {
                        result.Insert(0, ConvertGroup(currentGroup, ones));
                    }
                    firstGroup = false;
                }
                num /= 1000;
                unitIndex++;
            }

            return result.ToString().Trim();
        }




        private string ConvertGroup(long num, string[] ones)
        {
            StringBuilder result = new StringBuilder();

            int hundreds = (int)(num / 100);
            int tens = (int)((num % 100) / 10);
            int onesDigit = (int)(num % 10);

            if (hundreds > 0)
            {
                result.Append(ones[hundreds]).Append(" Trăm");
            }

            if (tens == 0)
            {
                if (onesDigit > 0)
                {
                    result.Append(" Không Trăm Lẻ ").Append(ones[onesDigit]);
                }
            }
            else
            {
                if (result.Length > 0)
                {
                    result.Append(" ");
                }
                if (tens == 1)
                {
                    result.Append("Mười");
                }
                else
                {
                    result.Append(ones[tens]).Append(" Mươi");
                }

                if (onesDigit > 0)
                {
                    result.Append(" ");
                    if (onesDigit == 1)
                    {
                        result.Append("Một");
                    }
                    else
                    {
                        result.Append(ones[onesDigit]);
                    }
                }
            }

            return result.ToString().Trim();
        }






        private void btn_Restore_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex3_1_FormClosed(object sender, FormClosedEventArgs e)
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

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
