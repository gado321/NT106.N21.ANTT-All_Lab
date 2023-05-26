using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Thread TCPServer;

        private void button1_Click(object sender, EventArgs e)
        {
            TCPServer = new Thread(new ThreadStart(ServerThread));
            TCPServer.IsBackground = true;
            TCPServer.Start();
        }

        private void ServerThread() 
        {
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);
            Socket clientSocket;
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            while (true)
            {
                try
                {
                    serverSocket.Bind(ipepServer);
                    serverSocket.Listen(5);

                    clientSocket = serverSocket.Accept();
                    string connectInfo = "Server running on " + clientSocket.LocalEndPoint.ToString() + "\n";

                    if (!IsDisposed && InvokeRequired)
                    {
                        Invoke(new Action(() => richTextBox1.Text = connectInfo));
                    }
                    else if (!IsDisposed)
                    {
                        richTextBox1.Text = connectInfo;
                    }

                    while (clientSocket.Connected)
                    {
                        string returnData = "";
                        do
                        {
                            bytesReceived = clientSocket.Receive(recv);
                            if (bytesReceived == 0)
                            {
                                break;
                            }
                            returnData += Encoding.ASCII.GetString(recv);
                        } while (returnData[returnData.Length - 1] != '\n');
                        if (!IsDisposed && InvokeRequired)
                        {
                            Invoke(new Action(() => richTextBox1.Text += returnData));
                        }
                        else if (!IsDisposed)
                        {
                            richTextBox1.Text += returnData;
                        }
                    }
                    serverSocket.Close();
                    clientSocket.Close();
                }
                catch
                {

                }
            }
        }


    }
}
