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
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03
{
    public partial class Form4_ClientThread : Form
    {
        private TcpClient tcpClient = new TcpClient();

        public Form4_ClientThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                Byte[] data = Encoding.ASCII.GetBytes(yournameTxtBox.Text + ": " + richTextBox1.Text);
                tcpClient.GetStream().Write(data, 0, data.Length);

            }
            catch (SocketException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ port!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ IP!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra ở Client!");
                MessageBox.Show(ex.Message);
            }

        }

        private void Form4_ClientThread_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTextBox(string text)
        {
            // Check if the calling thread is the same as the thread that created the TextBox
            if (richTextBox2.InvokeRequired)
            {
                // If not, use cross-thread invocation to call the UpdateTextBox method on the main UI thread
                richTextBox2.Invoke((MethodInvoker)delegate {
                    UpdateTextBox(text);
                });
            }
            else
            {
                // If so, set the text of the TextBox directly
                richTextBox2.Text += text;
            }
        }

        private void ReceiveResponses(NetworkStream networkStream)
        {
            while (true)
            {
                if (networkStream.DataAvailable)
                {
                    Byte[] receivedBytes = new byte[1024];
                    int dataSize = networkStream.Read(receivedBytes, 0, receivedBytes.Length);
                    UpdateTextBox("\n" + Encoding.ASCII.GetString(receivedBytes, 0, dataSize).ToString());
                }
            }
        }

        private Thread responseThread;
        private void btnInit_Click(object sender, EventArgs e)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));

            tcpClient.Connect(ipep);

            NetworkStream networkStream = tcpClient.GetStream();

            responseThread = new Thread(() => ReceiveResponses(networkStream));
            responseThread.Start();

        }

        private void Form4_ClientThread_FormClosed(object sender, FormClosedEventArgs e)
        {
            responseThread.Abort();
        }
    }
}
