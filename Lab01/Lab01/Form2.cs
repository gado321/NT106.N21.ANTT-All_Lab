using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(textBox1.Text, out int val);
            string message = "Vui lòng nhập số nguyên!";
            if (!success && textBox1.Text != "" && textBox1.Text != "-") 
            {
                MessageBox.Show(message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(textBox2.Text, out int val);
            string message = "Vui lòng nhập số nguyên!";
            if (!success && textBox2.Text != "" && textBox2.Text != "-")
            {
                MessageBox.Show(message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string message = "Vui lòng nhập số nguyên!";
            if (!int.TryParse(textBox1.Text, out int val1) || !int.TryParse(textBox2.Text, out int val2))
            {
                MessageBox.Show(message);
            }
            else
            {
                textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
