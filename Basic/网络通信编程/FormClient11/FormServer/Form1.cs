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
using System.Collections;

namespace FormServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Thread myThread;//声明一个线程实例
        public Socket newSocket;//声明一个Socket实例
        public Socket serverSocket;//声明服务端Socket实例
        public Socket clientSocket;//声明客户端Socket
        public delegate void MyInvoke(string str);//声明一个委托
        public IPEndPoint localEP;//声明本地网络端点
        public EndPoint remote;//声明网络地址
        public int localPort;//声明本地端口号
        public Boolean isListening;//声明服务端是否监听
        public Hashtable _sessionTable;//用于记录用户信息
        public bool btnState=true;
        //设置服务端监听的端口号属性
        public int SetPort
        {
            get { return localPort; }
            set { localPort = value; }
        }
        //设置监听
        public void Listening()
        {
            SetPort = int.Parse(txtPort.Text.Trim());//设置端口号
            newSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//初始化Socket实例
            newSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);//允许Socket被绑定在已使用的地址上
            localEP = new IPEndPoint(IPAddress.Any, SetPort);//初始化网络端点信息
            try
            {
                _sessionTable = new Hashtable( 50 );
                newSocket.Bind(localEP);//绑定端口
                newSocket.Listen(10);//开始监听
                newSocket.BeginAccept(new AsyncCallback(OnConnectRequest),newSocket);//开始异步接受连接
            }
            catch(Exception ex)
            {
                ShowMessage(ex.ToString());
            }
            
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            ThreadStart myThreadDelegate = new ThreadStart(Listening);//新建一个线程用于委托
            myThread = new Thread(myThreadDelegate);
            if (btnState)
            {
                myThread.Start();
                stateBar.Text = "服务已经启动，等待客户端连接";
                btnState = false;
                btnStartServer.Text = "停止服务";
            }
            else
            {
                myThread.Interrupt();
                myThread.Abort();
                btnState = true;
                btnStartServer.Text = "开始服务";
                stateBar.Text = "服务已停止";
            }
        }
        //显示信息
        public void ShowMessage(string msg)
        {
            if (rtbMessage.InvokeRequired)
            {
                MyInvoke myInvoke = new MyInvoke(ShowMessage);
                rtbMessage.Invoke(myInvoke, new object[] { msg });
            }
            else
            {
                rtbMessage.AppendText(msg);
            }
        }
        public void OnConnectRequest(IAsyncResult ar)
        {
            serverSocket = (Socket)ar.AsyncState;
            clientSocket = serverSocket.EndAccept(ar);//异步接收连接
            string welcomeStr = "欢迎登陆到服务器";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(welcomeStr);
            remote = clientSocket.RemoteEndPoint;//获取远程终点信息
            ShowMessage(remote.ToString()+" 连接成功 "+DateTime.Now.ToString()+"\r\n");
            clientSocket.Send(data,data.Length,0);
            UserListOperate(clientSocket.RemoteEndPoint.ToString());
            _sessionTable.Add(clientSocket.RemoteEndPoint,null);//将连接成功的客户端实例添加到哈希表中
            serverSocket.BeginAccept(new AsyncCallback(OnConnectRequest), serverSocket);//等待新的客户端连接
            //接收数据
            ReceiveMessage();
        }
        //接收数据
        public void ReceiveMessage ()
        {
            while (true)
            { 
                byte[]data=new byte[1024];
                int recv = clientSocket.Receive( data );
                string message = Encoding.UTF8.GetString(data,0,recv);
                ShowMessage(clientSocket.RemoteEndPoint.ToString()+":"+message+"\r\n");
            }
        }
        //添加用户列表
        public void UserListOperate(string msg)
        {
            //在线程里以安全的方式调用控件
            if (lbUserList.InvokeRequired)
            {
                MyInvoke myInvoke = new MyInvoke(UserListOperate);
                lblUserList.Invoke(myInvoke, new object[] { msg });
            }
            else
            {
                lbUserList.Items.Add(msg);
            }
        }
        //删除用户列表
        public void UserListOperateRemove(string msg)
        {
            if (lbUserList.InvokeRequired)
            {
                MyInvoke myInvoke = new MyInvoke(UserListOperateRemove);
                lbUserList.Invoke(myInvoke, new object[] { msg });
            }
            else
            {
                lbUserList.Items.Remove(msg);
            }
        }
        //发送广播
        public void BroadCast()
        {
            string strMessage = txtMessage.Text;
            Byte[] data = Encoding.UTF8.GetBytes(strMessage);
            foreach (DictionaryEntry item in _sessionTable)
            {
                EndPoint temp = (EndPoint)item.Key;
                clientSocket.SendTo(data, temp);
                ShowMessage("我："+strMessage+"\r\n");
            }
            txtMessage.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //获取本机IP
            IPAddress[] ip = Dns.GetHostByName( Dns.GetHostName() ).AddressList;
            lblIP.Text+=ip[0].ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //窗体关闭时判断线程是否为空
            if (myThread != null)
            {
                myThread.Abort();
            }
            throw new Exception();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            BroadCast();
        }
    }
}
