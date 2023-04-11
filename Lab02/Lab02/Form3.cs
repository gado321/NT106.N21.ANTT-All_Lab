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

        string ans;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            try
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                while (true)
                {
                    string expression = sr.ReadLine();
                    if (expression == null)
                    {
                        break;
                    }
                    string[] nums = expression.Split(new char[] { '+', '-', '*', '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int operand1 = int.Parse(nums[0]);
                    int operand2 = int.Parse(nums[1]);
                    char op = expression[expression.IndexOfAny(new char[] { '+', '-', '*', '/' })];
                    double result = 0;
                    switch (op)
                    {
                        case '+':
                            result = operand1 + operand2;
                            break;
                        case '-':
                            result = operand1 - operand2;
                            break;
                        case '*':
                            result = operand1 * operand2;
                            break;
                        case '/':
                            result = (float)operand1 / operand2;
                            break;
                    }
                    richTextBox1.Text += $"{operand1} {op}{operand2} = \n";
                    ans += $"{operand1} {op}{operand2} = {result}\n";
                }


                fs.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Chọn file đi em");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            try
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                richTextBox1.Text = ans;
                string newText = richTextBox1.Text;
                sw.Write(newText);
                sw.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Chọn file đi em");
            }
        }
    }
}
