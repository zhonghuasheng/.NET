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
using System.Reflection;

namespace _02DNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            IPAddress[] ips = Dns.GetHostAddresses(txtIP.Text);
            foreach (var item in ips)
            {
                listBox1.Items.Add(item);
                string name=Dns.GetHostByAddress(item).HostName;
                listBox2.Items.Add(name);
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
