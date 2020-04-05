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

namespace _01基本网络通信
{
    public partial class formUdpSend : Form
    {
        //声明一个UdpClient对象
        UdpClient udpClient;
        public formUdpSend()
        {
            InitializeComponent();
            //实例化UdpClient对象
            udpClient = new UdpClient();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //获取发送信息
            string message = this.txtMessage.Text;
            //获取发送数据
            byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
            udpClient.Connect(IPAddress.Parse(this.txtIP.Text),12345);
            udpClient.Send(data, data.Length);
            this.txtMessage.Text = "";
        }
    }
}
