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

        string[] VNNum = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười" };
        private string NumTrans(int number)
        {

            if (number < 10)
                return VNNum[number];
            else if (number == 15)
                return "Mười Lăm";
            else if (number >= 10 && number < 20)
                return "Mười " + VNNum[number % 10];
            else
            {
                string text = "";

                if ((number / 1000000000) > 0)
                {
                    text += NumTrans(number / 1000000000) + " Tỷ ";
                    number %= 1000000000;
                }

                if ((number / 1000000) > 0)
                {
                    text += NumTrans(number / 1000000) + " Triệu ";
                    number %= 1000000;
                }

                if ((number / 1000) > 0)
                {
                    text += NumTrans(number / 1000) + " Nghìn ";
                    number %= 1000;
                }

                if ((number / 100) > 0)
                {
                    text += NumTrans(number / 100) + " Trăm ";
                    number %= 100;
                }

                if (number > 9 && number < 100 && number % 10 == 0 && number != 10)
                {
                    text += NumTrans(number / 10) + " Mươi ";
                }
                else if (number > 19 && number < 100 && number % 10 != 0 && number % 5 != 0)
                    text += NumTrans(number / 10) + " Mươi " + NumTrans(number % 10);
                else if (number > 19 && number % 10 != 0 && number % 5 == 0)
                    text += NumTrans(number / 10) + " Mươi " + "Lăm";
                else
                    text += NumTrans(number);
                return text;
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
                if (num1 < 0)
                {
                    textBox5.Text = "Âm " + NumTrans(num1 * (-1));
                }
                else
                {
                    textBox5.Text = NumTrans(num1);
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
