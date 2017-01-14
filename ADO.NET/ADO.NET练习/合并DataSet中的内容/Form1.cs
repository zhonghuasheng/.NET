using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 合并DataSet中的内容
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //连接数据库
            string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                //创建两个DataSet对象
                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();
                //创建一个SqlDataReader对象
                string sqlText1 = "select * from student";
                SqlDataAdapter sda1 = new SqlDataAdapter(sqlText1,myConn);
                //使用Fill（）方法填充DataSet对象
                sda1.Fill(ds1);
                //创建第二个SqlDataReader对象
                string sqlText2 = "select * from employee";
                SqlDataAdapter sda2 = new SqlDataAdapter(sqlText2,myConn);
                sda2.Fill(ds2);
                ds1.Merge(ds2,true,MissingSchemaAction.AddWithKey);
                dataGridView1.DataSource=ds1.Tables[0];
            }
        }
    }
}
