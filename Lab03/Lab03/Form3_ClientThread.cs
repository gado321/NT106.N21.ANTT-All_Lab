using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form3_ClientThread : Form
    {
        public Form3_ClientThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(ipep);

                NetworkStream networkStream = tcpClient.GetStream();
                Byte[] data = Encoding.ASCII.GetBytes(richTextBox1.Text);
                networkStream.Write(data, 0, data.Length);
                networkStream.Close();
                tcpClient.Close();
            }
            catch (SocketException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ port!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ IP!");
            }
            catch
            {
                
            }
            
        }

        private void Form3_ClientThread_Load(object sender, EventArgs e)
        {

        }
    }
}
