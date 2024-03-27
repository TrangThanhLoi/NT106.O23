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
    public partial class Ex8 : Form
    {
        private List<string> favoriteFoods = new List<string>();


        public Ex8()
        {
            InitializeComponent();
        }

        private void UpdateFoodList()
        {
            listBoxFood.Items.Clear();
            foreach (string food in favoriteFoods)
            {
                listBoxFood.Items.Add(food);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (favoriteFoods.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(0, favoriteFoods.Count);
                textBoxResult.Text = favoriteFoods[index];
            }
            else
            {
                MessageBox.Show("Danh sách món ăn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string newFood = textBoxInput.Text.Trim();
            if (!string.IsNullOrEmpty(newFood))
            {
                favoriteFoods.Add(newFood);
                UpdateFoodList();
                textBoxInput.Clear();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            string targetFood = textBoxInput.Text.Trim();
            if (!string.IsNullOrEmpty(targetFood))
            {
                if (favoriteFoods.Remove(targetFood))
                {
                    UpdateFoodList();
                    textBoxInput.Clear();
                }
                else
                {
                    MessageBox.Show("Món ăn không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Ex8_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}