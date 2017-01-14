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

namespace _01基本网络通信接收端
{
    public partial class formUdpReceive : Form
    {
        UdpClient udpClient;
        Thread thread;
        public formUdpReceive()
        {
            InitializeComponent();
            //不捕获对错误线程的调用
            CheckForIllegalCrossThreadCalls = false;
            udpClient = new UdpClient(12345);
        }
        //设置监听
        public void Listen()
        {
            IPEndPoint iep = null;
            while (true)
            {
                string data = System.Text.Encoding.UTF8.GetString(udpClient.Receive(ref iep));
                this.lbReceive.Items.Add(data);
            }
        }
        private void btnReceive_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(Listen));
            thread.IsBackground = true;
            thread.Start();
        }

        private void formUdpReceive_Load(object sender, EventArgs e)
        {

        }
    }
}
