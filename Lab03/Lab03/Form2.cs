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

        private void button1_Click(object sender, EventArgs e)
        {
            Thread TCPServer = new Thread(new ThreadStart(ServerThread));
            TCPServer.IsBackground = true;
            TCPServer.Start();
        }

        private void ServerThread() 
        {
            // hoi thay tai sao cai ipepServer co ip ban dau la 0.0.0.0 ma sao luc bind no lai lang nghe toi dia chi ip cua may
            // Nho check lai cach thuc hoat dong cua IPEndPoint
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);
            Socket clientSocket;
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            try
            {
                serverSocket.Bind(ipepServer);
                serverSocket.Listen(5);
                
                clientSocket = serverSocket.Accept();
                
                string connectInfo = "Server running on " + clientSocket.LocalEndPoint.ToString() + "\n";   
                if (!IsDisposed && InvokeRequired)
                {
                    Invoke(new Action(() => richTextBox1.AppendText(connectInfo)));
                }
                else if (!IsDisposed)
                {
                    richTextBox1.AppendText(connectInfo);
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
                    //1.Tai sao lai raise ObjectDisposedException: 'Cannot access a disposed object. Object name: 'RichTextBox'.' khi thuc hien dong duoi day
                    //richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.Text += returnData + "\n"; }));
                    //2. update in the main thread, not like create a delegate and work in current thread, it makes an action in main thread?? hoi thay coi dung ko    
                    //3. Tai sao doan code nay no lai bi ODE tren Form2, doan code dau thi ODE tren richtextbox? lu qua
                        Invoke(new Action(() => richTextBox1.AppendText(returnData)));
                    }
                    else if (!IsDisposed)
                    {
                        richTextBox1.AppendText(returnData);
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
