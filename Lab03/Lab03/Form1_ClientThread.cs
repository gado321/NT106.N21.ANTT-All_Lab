using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1_ClientThread : Form
    {
        public Form1_ClientThread()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
                udpClient.Send(sendBytes, sendBytes.Length, textBox1.Text, int.Parse(textBox2.Text));
            }
            catch (SocketException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ IP!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ Port!");
            }
        }
    }
}
