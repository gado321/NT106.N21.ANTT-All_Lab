using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static bool IsBinary(string text)
        {
            return Regex.IsMatch(text, "^[01]+$");
        }

        public static bool IsOctal(string text)
        {
            return Regex.IsMatch(text, "^[0-7]+$");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            string messageInput = "Vui lòng nhập số đúng định dạng!";
            string messageSelected = "Vui lòng chọn kiểu dữ liệu cần chuyển!";
            // Check value of list is selected or not
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show(messageSelected);
            }
            else
            {
                string typeFrom = comboBox1.SelectedItem.ToString();
                string typeTo = comboBox2.SelectedItem.ToString();

                //Check input is valid Binary number or not
                bool isBin = IsBinary(textBox1.Text);
                //Check input is valid Octal number or not
                bool isOct = IsOctal(textBox1.Text);
                //Check input is valid Decimal number or not
                bool isDec = int.TryParse(textBox1.Text, out result);
                //Check input is valid Hex number or not (base 0x)
                bool isHex = textBox1.Text.Length > 2 &&
                textBox1.Text.Substring(0, 2).ToLowerInvariant() == "0x" &&
                int.TryParse(textBox1.Text.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);

                //Convert any base to base 2
                if (isBin && typeFrom == "Binary")
                {
                    if (typeTo == "Binary")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (typeTo == "Octal")
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 8);
                    }
                    else if (typeTo == "Decimal")
                    {
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 2).ToString();
                    }
                    else if (typeTo == "Hexadecimal")
                    {
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 2).ToString("X");
                    }
                }
                //Convert any base to base 8
                else if (isOct && typeFrom == "Octal")
                {

                    if (typeTo == "Binary")
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 2);
                    }
                    else if (typeTo == "Octal")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (typeTo == "Decimal")
                    {
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 8).ToString();
                    }
                    else if (typeTo == "Hexadecimal")
                    {
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 8).ToString("X");
                    }
                }
                //Convert any base to base 10
                else if (isDec && typeFrom == "Decimal")
                {
                    if (typeTo == "Binary")
                    {
                        textBox2.Text = Convert.ToString(result, 2);
                    }
                    else if (typeTo == "Octal")
                    {
                        textBox2.Text = Convert.ToString(result, 8);
                    }
                    else if (typeTo == "Decimal")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (typeTo == "Hexadecimal")
                    {
                        textBox2.Text = result.ToString("X");
                    }
                }
                //Convert any base to base 16
                else if (isHex && typeFrom == "Hexadecimal")
                {
                    if (typeTo == "Binary")
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2);
                    }
                    else if (typeTo == "Octal")
                    {
                        textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 8);
                    }
                    else if (typeTo == "Decimal")
                    {
                        textBox2.Text = Convert.ToInt32(textBox1.Text, 16).ToString();
                    }
                    else if (typeTo == "Hexadecimal")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                }
                //Wrong input format
                else
                {
                    MessageBox.Show(messageInput);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}