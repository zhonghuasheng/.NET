using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04插入数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            //连接数据库
            string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = connectionText;
            myConn.Open();
            //if(myConn.State==ConnectionState.Open)
            //{
            //    lblResult.Text = "连接数据库成功";
            //}
            //向数据库中插入数据
            //方法一
            //string insertCmd = "insert into student values('" + txtStuNumber.Text + "','" + txtStuName.Text + "','" + txtStuAge.Text + "')";
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = insertCmd;
            //cmd.Connection = myConn;
            //lblResult.Text=cmd.ExecuteNonQuery().ToString();
            //方法二
            //创建DataAdapter对象
           string selectCmd = "select * from student";
 //           string insertCmd = "insert into student values('"+txtStuNumber.Text+"','"+txtStuName.Text+"','"+txtStuAge.Text+"')";
            SqlDataAdapter sda = new SqlDataAdapter(selectCmd,myConn);
            //创建并填充DataSet对象
            DataSet ds = new DataSet();
            sda.Fill(ds,"student");
            DataTable dt=ds.Tables["student"];

            //通过DataRow添加一条记录
           // DataRow dr = dt.NewRow();（可以使用）
            //在表student中添加一个用于描述行记录的DataRow对象
            DataRow dr = ds.Tables["student"].NewRow();
            dr["stuNumber"] = txtStuNumber.Text;
            dr["stuName"] = txtStuName.Text;
            dr["stuAge"] = txtStuAge.Text;
            dt.Rows.Add(dr);
            //更新到数据库中
            //sda.InsertCommand = new SqlCommand(insertCmd,myConn);（可以使用）
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(ds,"student");
          
        }
    }
}
