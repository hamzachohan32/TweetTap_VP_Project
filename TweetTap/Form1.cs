using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using ClassLibrary1;
using System.IO;

namespace TweetTap
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epOther;
        public Form1()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textLocalIP.Text = getlocalIP();
            textRemoteIP.Text = getlocalIP();

        }
        private String getlocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epOther);
                if(size>0)
                {
                    byte[] recievedData = new byte[1464];
                    recievedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recievedMessage = eEncoding.GetString(recievedData);
                    Conversation.Items.Add("Friend:" + recievedMessage);

                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epOther, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);
                epOther = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
                sck.Connect(epOther);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epOther, new AsyncCallback(MessageCallBack), buffer);
                buttonConnect.Text = "Enabled";
                buttonConnect.Enabled = false;
                Send.Enabled = true;
                textMessage.Focus();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PortUser1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Users\Hamza\Desktop\MessageInput.txt");
                writer.AutoFlush = true;
                writer.WriteLine(textMessage.Text.ToString());
                writer.Close();
                System.Diagnostics.Process.Start(@"C:\Users\Hamza\source\repos\KeyPhraseExtraction\KeyPhraseExtraction\bin\Debug\KeyPhraseExtraction");
                System.Threading.Thread.Sleep(5000);
                StreamReader reader = new StreamReader(@"C:\Users\Hamza\Desktop\MessageOutput.txt");
                string line = reader.ReadLine();
                reader.Close();
               
                MessageBox.Show(line);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
