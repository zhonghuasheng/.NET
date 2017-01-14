using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11复制DataSet中的内容_Copy_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet myDS;
        private void btnShow_Click(object sender, EventArgs e)
        {
            //创建到数据库的连接
            string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                //查询语句
                string selectText = "select * from Employee";
                //创建一个SqlDataAdapter对象
                SqlDataAdapter mySDA = new SqlDataAdapter(selectText,myConn);
                //创建一个DataSet对象
                myDS = new DataSet();
                //使用Fill方法填充DataSet对象
                mySDA.Fill(myDS);
                //设置dataGridView的数据源
                dataGridView1.DataSource=myDS.Tables[0];

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            DataSet myDS2 = myDS.Copy();
            dataGridView2.DataSource=myDS2.Tables[0];
        }
    }
}
