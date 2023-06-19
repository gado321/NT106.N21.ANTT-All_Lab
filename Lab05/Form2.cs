using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text= string.Empty;
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = textBox1.Text.ToString().Trim();
                string mailto = textBox2.Text.ToString().Trim();
                string password = textBox3.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = textBox4.Text.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = richTextBox1.Text.ToString();
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                        label6.Text = "Đã gởi mail thành công!";
                    }
                    catch (SmtpException)
                    {
                        label6.Text = "Tài khoản hoặc mật khẩu không đúng!";
                    }
                }
            }
        }
    }
}
