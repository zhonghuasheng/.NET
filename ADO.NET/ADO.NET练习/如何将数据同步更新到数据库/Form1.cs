using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 如何将数据同步更新到数据库
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connText = @"Server=(local);DataBase=testDB;Integrated Security=true";
            using(SqlConnection myConn=new SqlConnection(connText))
            {
                myConn.Open();
                string cmdText = "update vote set votes=votes+1 where name='张三'";
                SqlCommand myCMD = new SqlCommand(cmdText,myConn);
                int result = myCMD.ExecuteNonQuery();
                MessageBox.Show(result.ToString());
                myConn.Close();
                myConn.Dispose();

            }
        }
    }
}
