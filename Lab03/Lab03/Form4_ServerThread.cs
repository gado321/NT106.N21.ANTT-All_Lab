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

        private void cliThread(NetworkStream netStream)
        {
            while (true)
            {
                Byte[] receivedBytes = new byte[1024];
                int dataSize = netStream.Read(receivedBytes, 0, receivedBytes.Length);
                if (dataSize == 0)
                {
                    break;
                }

                int m;

                lock(nLock)
                {
                    m = n;
                }



                lock(clientsLock) { 
                    // Broadcast to clients
                    for (int i = 0; i < m; i++)
                    {
                        NetworkStream client_i_netstream = Clients[i].GetStream();
                        if (client_i_netstream.CanRead && client_i_netstream.CanWrite)
                        {
                            client_i_netstream.Write(receivedBytes, 0, receivedBytes.Length);
                            //client_i_netstream.Close();
                        }

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

            }

            

            
        }

        private TcpClient[] Clients = new TcpClient[1000];
        private object nLock = new object();
        private object clientsLock = new object();
        private int n = 0;

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


            while (true)
            {
                try
                {
                    TCPserver.Start(10);
                    TcpClient TCPclient = TCPserver.AcceptTcpClient();
                    
                    lock(clientsLock)
                    {
                        Clients[n] = TCPclient;
                    }

                    lock(nLock)
                    {
                        n++;
                    }
                    MessageBox.Show(n.ToString());

                    Thread cli = new Thread(() => cliThread(TCPclient.GetStream()));
                    cli.Start();


                    
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
