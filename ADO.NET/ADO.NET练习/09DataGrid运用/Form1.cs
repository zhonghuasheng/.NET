using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _09DataGrid运用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 连接字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
        private void btnPresent_Click(object sender, EventArgs e)
        {
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                if(myConn.State==ConnectionState.Closed)
                {
                    myConn.Open();
                }
                //查询字符串
                string selectCommandText = "select * from student where stuNumber=' "+txtStuNumber.Text.Trim()+"'";
                //根据连接对象和SQL语句创建SqlCommand对象
                SqlCommand myComd = new SqlCommand(selectCommandText,myConn);
                //使用Command对象创建SqlDataReader对象
                SqlDataAdapter sda = new SqlDataAdapter(selectCommandText,myConn);
                DataSet ds = new DataSet();
                sda.Fill(ds,"student");
                dgvShow.DataSource=ds.Tables[0];
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                if(myConn.State==ConnectionState.Closed)
                {
                    myConn.Open();
                }
                //将数据显示到DataGridView中
                string selectCommandText = "select * from student";
                SqlDataAdapter mySDA = new SqlDataAdapter(selectCommandText,myConn);
                DataSet myDS = new DataSet();
                mySDA.Fill(myDS,"student");
                dgvShow.DataSource=myDS.Tables[0];
                //DataTable myDT = new DataTable();
                //for (int i = 0; i < dgvShow.Rows.Count;i++ )
                //{
                   
                //}
            }
        }
    }
}
