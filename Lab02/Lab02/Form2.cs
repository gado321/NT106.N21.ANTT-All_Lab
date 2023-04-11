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
using System.Xml.Linq;

namespace Lab02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

                // Get file name
                string fileName = ofd.SafeFileName.ToString();
                textBox1.Text = fileName;
                
                // get URL of file
                string url = fs.Name.ToString();
                textBox2.Text= url;

                // Count number of line in a file
                content = content.Replace("\r\n", "\r");
                int lineCount = richTextBox1.Lines.Count();
                textBox3.Text = lineCount.ToString();

                // Count number of word in a file //
                content = content.Replace('\r', ' ');
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = source.Count();
                textBox4.Text = wordCount.ToString();

                // Count number of character in a file //
                int charCount = content.Length;
                textBox5.Text = charCount.ToString();

                fs.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Chọn file đi em");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
