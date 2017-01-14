using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace FormClient
{
    public partial class FormClient : Form
    {
        //声明一个Socket
        public Socket newClient;
        //判断是否连接成功
        public bool isConnected;
        //定义一个线程
        public Thread myThread;
        //定义一个委托
        public delegate void MyInvoke(string str);
        public FormClient()
        {
            InitializeComponent();
        }

        private void Connection()
        {
            IPAddress ip=null;
            int port=888;
            byte[]data=new byte[1024];
            //创建一个新的Socket
            newClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //获取IP地址
            #region GetIP
            if (txtIP.Text == string.Empty)
            {
                MessageBox.Show("远程IP不能为空");
            }
            else
            {
                string pattrn = @"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))))";
                if (System.Text.RegularExpressions.Regex.IsMatch(txtIP.Text.Trim(), pattrn))
                {
                    ip = IPAddress.Parse(txtIP.Text.Trim());
                }
                else
                {
                    MessageBox.Show("IP地址格式不正确！");
                }
            } 
            #endregion
            //获取端口号
            #region GetPort
            //if (System.Text.RegularExpressions.Regex.IsMatch(@"^[-]?\d+[.]?\d*$", txtPort.Text.Trim()))
            //{
            //    port = Convert.ToInt32(txtPort.Text.Trim());
            //}
            //else
            //{
            //    MessageBox.Show("端口号格式不正确");
            //} 
            #endregion
            //封装网络端点
            IPEndPoint ie = new IPEndPoint(ip, port);
            #region Connection
            try
            {
                //建立与远程主机之间的连接
                newClient.Connect(ie);
                //设置连接服务器控件的属性
                btnConnection.Enabled = false;
                //设置连接状况
                isConnected = true;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("连接服务器失败" + ex.Message);
                return;
            } 
            #endregion
            ThreadStart myThreadDelegate = new ThreadStart(ReceiveMessage);
            myThread = new Thread(myThreadDelegate);
            myThread.Start();
        }
        /// <summary>
        /// 接收消息
        /// </summary>
        public void ReceiveMessage()
        {
            while (true)
            { 
                //定义字节数组大小
                byte[]data=new byte[1024];
                //获取数组长度
                int recv = newClient.Receive(data);
                string strData = Encoding.UTF8.GetString(data, 0, recv);

            }
        }
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="msg">接收的消息，可能来自Client/也可能来自Server</param>
        public void ShowMessage(string msg)
        {
            //在创建该控件以外的线程调用该控件
            if (lbMessage.InvokeRequired)
            {
                MyInvoke myInvoke = new MyInvoke(ShowMessage);
                lbMessage.Invoke(myInvoke, new object[] { msg });
            }
            else
            {
                lbMessage.Items.Add(msg);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSendMessage.Text == null)
            {
                txtSendMessage.Text = "发送消息不能为空";
                //停留1秒消失
            }
            else
            {
                int myMessLength = txtSendMessage.Text.Length;
                byte[] data = new byte[myMessLength];
                data = Encoding.UTF8.GetBytes(txtSendMessage.Text);
                int i = newClient.Send(data);
                ShowMessage("我说：" + txtSendMessage.Text + "\r\n");
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            Connection();
        }
        
    }
}
