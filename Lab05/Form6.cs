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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            label3.Text = Properties.Settings.Default.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MailKit.Net.Smtp.SmtpClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 465, true);
            client.Authenticate(Properties.Settings.Default.Email, Properties.Settings.Default.Password);

            var message = new MimeKit.MimeMessage();
            message.From.Add(new MimeKit.MailboxAddress(Properties.Settings.Default.Email, Properties.Settings.Default.Email));
            message.To.Add(new MimeKit.MailboxAddress(textBox2.Text, textBox2.Text));
            message.Subject = textBox4.Text;
            message.Body = new MimeKit.TextPart("plain") { Text = richTextBox1.Text };

            client.Send(message);
            client.Disconnect(true);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
