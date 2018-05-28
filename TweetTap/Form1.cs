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
using System.IO;
using System.Text.RegularExpressions;
namespace TweetTap
{
    public partial class TweetTap : Form
    {
        Socket sck;
        EndPoint epLocal, epOther;
        public TweetTap()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            LocalIP.Text = getlocalIP();
            RemoteIP.Text = getlocalIP();

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
                    ConversationBox.Items.Add("Friend:" + recievedMessage);

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
                epLocal = new IPEndPoint(IPAddress.Parse(LocalIP.Text), Convert.ToInt32(LocalPort.Text));
                sck.Bind(epLocal);
                epOther = new IPEndPoint(IPAddress.Parse(RemoteIP.Text), Convert.ToInt32(RemotePort.Text));
                sck.Connect(epOther);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epOther, new AsyncCallback(MessageCallBack), buffer);
                SubmitIP_Port.Text = "Enabled";
                SubmitIP_Port.Enabled = false;
                SendMessage.Enabled = true;
                textMessage.Focus();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter all Required Fields Correctly");
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

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TweetTap_MouseDown(object sender, MouseEventArgs e)
        {
            //this.DragOver(); this.DragMove(); 
        }

        private void TweetTap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Users\Hamza\Desktop\MessageInput.txt");
                writer.AutoFlush = true;
                writer.WriteLine(textMessage.Text.ToString());
                writer.Close();
                    //API called
                {
                    System.Diagnostics.Process.Start(@"C:\Users\Hamza\source\repos\KeyPhraseExtraction\KeyPhraseExtraction\bin\Debug\KeyPhraseExtraction");
                    System.Threading.Thread.Sleep(5000);
                }
               //message part

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                Regex RX = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
                StreamReader reader = new StreamReader(@"C:\Users\Hamza\Desktop\MessageOutput.txt");
                string line = reader.ReadLine();
                reader.Close();
                string[] ssize = line.Split(null);
                bool check = false;
                if (RX.IsMatch(textMessage.Text))
                {
                    ConversationBox.Items.Add("You : " + "This Message Can't Be Sent");
                    textMessage.Clear();
                    check = true;
                }
                if(!(RX.IsMatch(textMessage.Text)))
                {
                    for (int i = 0; i < ssize.Length; i++)
                    {

                        if (ssize[i].ToLower() == "mail" || ssize[i].ToLower() == "email" || ssize[i].ToLower() == "e-mail")
                        {
                            ConversationBox.Items.Add("You : " + "This Message Can't Be Sent");
                            textMessage.Clear();
                            check = true;
                            //break;
                        }
                    }             
                    
                }
                string conc = textMessage.Text;
               
                if(RX.IsMatch(conc.Replace(" ", string.Empty)))
                {
                    ConversationBox.Items.Add("You : " + "This Message Can't Be Sent");
                    textMessage.Clear();
                    check = true;
                }
                if (check==false)
                {
                    sck.Send(msg);
                    ConversationBox.Items.Add("You :" + textMessage.Text);
                    textMessage.Clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Connect Local as Well as Remote Chats");
            }
        }
    }
}
