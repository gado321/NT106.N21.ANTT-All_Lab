using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form3_ServerThread : Form
    {
        public Form3_ServerThread()
        {
            InitializeComponent();
        }

        Thread TCPServer;
        TcpListener TCPserver;

        private void button1_Click(object sender, EventArgs e)
        {
            TCPServer = new Thread(new ThreadStart(ServerThread));
            TCPServer.IsBackground = true;
            TCPServer.Start();
        }

        private void ServerThread()
        {
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            TCPserver = new TcpListener(ipepServer);
            string connectInfo = "Server running on " + TCPserver.LocalEndpoint.ToString();
            if (!IsDisposed && InvokeRequired)
            {
                Invoke(new Action(() => richTextBox1.Text = connectInfo));
            }
            else if (!IsDisposed)
            {
                richTextBox1.Text = connectInfo;
            }

            while (true)
            {
                try
                {
                    TCPserver.Start(10);
                    TcpClient TCPclient = TCPserver.AcceptTcpClient();
                    NetworkStream networkStream = TCPclient.GetStream();
                    Byte[] receivedBytes = new byte[1024];
                    int dataSize = networkStream.Read(receivedBytes, 0, receivedBytes.Length);
                    if (dataSize == 0)
                    {
                        break;
                    }

                    // why TCPclient.Client.RemoteEndPoint.ToString() is not use port 8080?
                    string message = "\n" + Encoding.ASCII.GetString(receivedBytes).ToString();

                    if (!IsDisposed && InvokeRequired)
                    {
                        Invoke(new Action(() => richTextBox1.Text += message));
                    }
                    else if (!IsDisposed)
                    {
                        richTextBox1.Text += message;
                    }
                    TCPclient.Close();
                }
                catch
                {

                }
            }
        }

        private void Form3_ServerThread_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TCPserver.Stop();
            TCPServer.Abort();
        }
    }
}
