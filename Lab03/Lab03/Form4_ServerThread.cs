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
    public partial class Form4_ServerThread : Form
    {
        public Form4_ServerThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread TCPServer = new Thread(new ThreadStart(ServerThread));
            TCPServer.IsBackground = true;
            TCPServer.Start();
        }

        private void ServerThread()
        {
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            TcpListener TCPserver = new TcpListener(ipepServer);
            string connectInfo = "Server running on " + TCPserver.LocalEndpoint.ToString();
            if (!IsDisposed && InvokeRequired)
            {
                Invoke(new Action(() => richTextBox1.Text = connectInfo));
            }
            else if (!IsDisposed)
            {
                richTextBox1.Text = connectInfo;
            }

            TcpClient[] Clients = new TcpClient[1000];
            int n = 0;

            while (true)
            {
                try
                {
                    TCPserver.Start(10);
                    TcpClient TCPclient = TCPserver.AcceptTcpClient();
                    NetworkStream networkStream = TCPclient.GetStream();
                    Byte[] receivedBytes = new byte[1024];
                    int dataSize = networkStream.Read(receivedBytes, 0, receivedBytes.Length);
                    MessageBox.Show("\n" + Encoding.ASCII.GetString(receivedBytes).ToString());
                    if (dataSize == 0)
                    {
                        break;
                    }
                    
                    Clients[n] = TCPclient;
                    n++;

                    // Broadcast to clients
                    for (int i = 0; i < n; i++)
                    {
                        NetworkStream client_i_netstream = Clients[i].GetStream();
                        if (client_i_netstream.CanRead && client_i_netstream.CanWrite)
                        {
                            client_i_netstream.Write(receivedBytes, 0, receivedBytes.Length);
                            //client_i_netstream.Close();
                        }

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
                    //networkStream.Close();
                    //TCPclient.Close();

                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Đã có lỗi xảy ra ở Server!");
                    MessageBox.Show(e.Message);
                }
            }
            
            
        }
    }
}
