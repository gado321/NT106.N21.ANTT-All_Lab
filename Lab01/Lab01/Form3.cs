using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool success = float.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float val);
            string message = "Vui lòng nhập số hợp lệ!";
            if (!success && textBox1.Text != "" && textBox1.Text != "-")
            {
                MessageBox.Show(message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool success = float.TryParse(textBox2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float val);
            string message = "Vui lòng nhập số hợp lệ!";
            if (!success && textBox2.Text != "" && textBox2.Text != "-")
            {
                MessageBox.Show(message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool success = float.TryParse(textBox3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float val);
            string message = "Vui lòng nhập số hợp lệ!";
            if (!success && textBox3.Text != "" && textBox3.Text != "-")
            {
                MessageBox.Show(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Vui lòng nhập số hợp lệ!";
            float num1, num2, num3;
            
            if (!float.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out num1) || !float.TryParse(textBox2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out num2) || !float.TryParse(textBox3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out num3))
            {
                MessageBox.Show(message);
            }
            else
            {
                float maxi = Math.Max(num1, Math.Max(num2, num3));
                float mini = Math.Min(num1, Math.Min(num2, num3));
                textBox5.Text = maxi.ToString(CultureInfo.InvariantCulture);
                textBox4.Text = mini.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
