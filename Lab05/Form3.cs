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
    public partial class Form3 : Form
    {
        //MailReader mailReader;
        public Form3()
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
            }
            catch (AuthenticationException)
            {
                label3.Text = "Tài khoản hoặc mật khẩu không đúng!";
            }

            // Lấy danh sách thư từ hòm thư Inbox
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            listView1.Clear();
            listView1.Columns.Add("Email", 400);
            listView1.Columns.Add("From", 250);
            listView1.Columns.Add("Thời gian", 250);
            listView1.View = View.Details;
            for (int i = 0; i < inbox.Count; i++)
            {
                var message = inbox.GetMessage(i);
                ListViewItem name = new ListViewItem(message.Subject);
                
                ListViewItem.ListViewSubItem from = new
                ListViewItem.ListViewSubItem(name, message.From.ToString());
                name.SubItems.Add(from);
                
                ListViewItem.ListViewSubItem date = new
                ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                name.SubItems.Add(date);
                
                listView1.Items.Add(name);
            }


            client.Disconnect(true);
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var index = listView1.FocusedItem.Index;

            var client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 993, true);
            try
            {
                client.Authenticate(textBox1.Text, textBox2.Text);
            }
            catch (AuthenticationException)
            {
                label3.Text = "Tài khoản hoặc mật khẩu không đúng!";
            }

            // Lấy danh sách thư từ hòm thư Inbox
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            // Lấy nội dung của email đã chọn
            var message = inbox.GetMessage(index);
            MessageBox.Show(string.IsNullOrEmpty(message.TextBody) ? message.HtmlBody : message.TextBody);

            client.Disconnect(true);
        }
    }
}
