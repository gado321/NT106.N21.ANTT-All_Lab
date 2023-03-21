using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(textBox1.Text, out int val);
            string message = "Vui lòng nhập số nguyên hợp lệ!";
            if (!success && textBox1.Text != "" && textBox1.Text != "-")
            {
                MessageBox.Show(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Vui lòng nhập số nguyên hợp lệ!";
            int num1;
            if (!int.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show(message);
            }
            else
            {
                if (num1 == 0)
                {
                    textBox5.Text = "Không";
                }
                else if (num1 == 1)
                {
                    textBox5.Text = "Một";
                }
                else if (num1 == 2)
                {
                    textBox5.Text = "Hai";
                }
                else if (num1 == 3)
                {
                    textBox5.Text = "Ba";
                }
                else if (num1 == 4)
                {
                    textBox5.Text = "Bốn";
                }
                else if (num1 == 5)
                {
                    textBox5.Text = "Năm";
                }
                else if (num1 == 6)
                {
                    textBox5.Text = "Sáu";
                }
                else if (num1 == 7)
                {
                    textBox5.Text = "Bảy";
                }   
                else if (num1 == 8)
                {
                    textBox5.Text = "Tám";
                }
                else if (num1 == 9)
                {
                    textBox5.Text = "Chín";
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
