using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 登录与注册
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("Data Directory", dataDir);
            }
            //使用SqlConnection对象连接数据库
            string con = @"Data Source=.\SQLExPRESS;AttachDBFilename=|DataDirectory|\UserInformation.mdf;Integrated Security=True;User Instance=True";
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = con;
            myConn.Open();
           // MessageBox.Show("连接成功");
           //使用SqlCommand执行查询语句
            string cmdText = "select password from user where userName='"+txtUserName.Text.Trim()+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = cmdText;
            string s = cmd.ExecuteScalar().ToString();
            MessageBox.Show(s);
        }
    }
}
