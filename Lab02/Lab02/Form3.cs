using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\input3.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                richTextBox1.Text = sr.ReadToEnd();

                fs.Close();
            }
            catch
            {
                MessageBox.Show("Có phép tính nhập vào không đúng!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fsInput = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\input3.txt", FileMode.OpenOrCreate);
            FileStream fsOutput = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\output3.txt", FileMode.OpenOrCreate);
            try
            {
                StreamReader sr = new StreamReader(fsInput);
                StreamWriter sw = new StreamWriter(fsOutput);
                
                richTextBox1.Clear();   
                while (true)
                {
                    string expression = sr.ReadLine();
                    if (expression == null)
                    {
                        break;
                    }
                    var result = new DataTable().Compute(expression, null);
                    richTextBox1.Text += expression + "=" + result.ToString() + "\n";
                }
                sw.Write(richTextBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Có phép tính nhập vào không đúng!");
            }

            fsInput.Close();
            fsOutput.Close();
        }
    }
}
