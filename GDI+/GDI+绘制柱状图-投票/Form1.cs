using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;

namespace GDI_绘制柱状图_投票
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //数据库连接
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("Data Directory", dataDir);
            }
            //数据库连接字符串
            using (SqlConnection myConn = new SqlConnection(@"Data source=.\SQLEXPRESS;
                  AttachDBFilename=|DataDirectory|\voilet.mdf;Integrated Security=True;User Instance=True"))
            {
                string cmdText = "";      
                try
                { 
                    if(radioButton1.Checked)
                    {
                        cmdText="update vote set Votes=Votes+1 where Name='"+radioButton1.Text+"'";
                    }
                    else if(radioButton2.Checked)
                    {
                        cmdText="update vote set Votes=Votes+1 where Name='"+radioButton2.Text+"'";
                    }
                    else if(radioButton3.Checked)
                    {
                        cmdText="update vote set Votes=Votes+1 where (Name='"+radioButton3.Text+"')";
                    }
                    else if(radioButton4.Checked)
                    {
                        cmdText="update vote set Votes=Votes+1 where Name='"+radioButton4.Text+"'";
                    }
                    if (myConn.State == ConnectionState.Closed)
                    {
                        myConn.Open();
                    }
                    SqlCommand myCmd = new SqlCommand(cmdText,myConn);
                    int result = myCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("投票成功");
                    }                 
                    if(myConn.State==ConnectionState.Open)
                    {
                        myConn.Close();
                        myConn.Dispose();
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
//            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
//            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
//            {
//                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
//                AppDomain.CurrentDomain.SetData("Data Directory", dataDir);
//            }
//            //数据库连接字符串
//            using (SqlConnection myConn = new SqlConnection(@"Data source=.\SQLEXPRESS;
//                  AttachDBFilename=|DataDirectory|\voilet.mdf;Integrated Security=True;User Instance=True"))
//            {
//                myConn.Open();
//                SqlCommand cmd = new SqlCommand("update vote set votes=112 where name='张三'", myConn);
                
//                SqlCommand mycmd = new SqlCommand("select votes from vote where name='张三'",myConn);
//                string s=mycmd.ExecuteScalar().ToString();
//                MessageBox.Show(cmd.ExecuteNonQuery().ToString()+s);
//            }
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("www.tycguanwang.com", dataDir);
            }
            //数据库连接字符串
            using (SqlConnection myConn = new SqlConnection(@"Data source=.\SQLEXPRESS;
                  AttachDBFilename=|DataDirectory|\voilet.mdf;Integrated Security=True;User Instance=True"))
            {
                myConn.Open();
               
                SqlCommand cmd = new SqlCommand("update vote set votes=112 ", myConn);
                SqlCommand mycmd = new SqlCommand("select votes from vote where name='张三'", myConn);
                string a = cmd.ExecuteNonQuery().ToString();
                string s = mycmd.ExecuteScalar().ToString();
                MessageBox.Show(a +"     "+ s);
                myConn.Close();
                myConn.Dispose();
            }
        }
    }
}
