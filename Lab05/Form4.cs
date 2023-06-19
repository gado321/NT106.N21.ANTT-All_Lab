using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 993, true);
            try
            {
                client.Authenticate(textBox1.Text, textBox2.Text);
                Properties.Settings.Default.Email = textBox1.Text;
                Properties.Settings.Default.Password = textBox2.Text;
                Properties.Settings.Default.Save();

                // Mở form chính
                var mainForm = new Form5(this);
                mainForm.Show();
                this.Hide();
            }
            catch (AuthenticationException)
            {
                label3.Text = "Tài khoản hoặc mật khẩu không đúng!";
            }
            

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
        }
    }
}
