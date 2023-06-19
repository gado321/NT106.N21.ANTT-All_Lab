using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05
{
    public partial class Form5 : Form
    {
        private Form4 loginForm;
        private Timer timer;
        private ImapClient client;
        private bool state = false;

        public Form5(Form4 loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            label1.Text = "Hello, " + Properties.Settings.Default.Email;

            this.timer = new Timer();
            timer.Interval = 5000; // 5 giây
            timer.Tick += Timer_Tick;

            this.client = new MailKit.Net.Imap.ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e_ssl) => true;
            client.Connect("127.0.0.1", 993, true);
            client.Authenticate(Properties.Settings.Default.Email, Properties.Settings.Default.Password);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            UpdateEmailList();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateEmailList();
        }

        private void UpdateEmailList()
        {
            if (!client.IsConnected)
                client.Connect("127.0.0.1", 993, true);
            if (!client.IsAuthenticated)
                client.Authenticate(Properties.Settings.Default.Email, Properties.Settings.Default.Password);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

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
            client.Authenticate(Properties.Settings.Default.Email, Properties.Settings.Default.Password);

            // Lấy danh sách thư từ hòm thư Inbox
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            // Lấy nội dung của email đã chọn
            var message = inbox.GetMessage(index);
            MessageBox.Show(string.IsNullOrEmpty(message.TextBody) ? message.HtmlBody : message.TextBody);

            client.Disconnect(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var send = new Form6();
            send.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state = true;
            loginForm.Show();
            this.Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else if (Application.OpenForms.Count == 1 && Application.OpenForms[0] is Form4 && !state)
            {
                Application.OpenForms[0].Close();
            }
        }
    }
}
