using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
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
                string szURL = textBox1.Text;
                string fileurl = textBox2.Text;
                if (Path.GetExtension(fileurl).ToLower() != ".html")
                {
                    MessageBox.Show("Vui long nhap dung dinh dang file out la .html");
                    return;
                }
                WebClient client = new WebClient();
                Stream response = client.OpenRead(szURL);
                client.DownloadFile(szURL, fileurl);
                richTextBox1.LoadFile(fileurl, RichTextBoxStreamType.PlainText);
            }
            catch
            {
                MessageBox.Show("Vui long nhap dung URL");
            }
        }
    }
}
