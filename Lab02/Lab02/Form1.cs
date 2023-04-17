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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Hãy chọn file cần mở!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
            {
                FileStream fs = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\output.txt", FileMode.OpenOrCreate);

                StreamWriter sw = new StreamWriter(fs);
                //string newText = richTextBox1.Text.ToUpper();
                sw.Write(richTextBox1.Text.ToUpper());
                MessageBox.Show("Đã lưu thông tin vào file output.txt!");

                sw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Không có nội dung để lưu!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
