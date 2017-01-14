using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _05删除方法02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
        private void button1_Click(object sender, EventArgs e)
        {
            string selectCmd = "select * from student where stuNumber='"+txtStuNumber.Text.Trim()+"'";
            string deleteCmd = "delete from student where stuNumber='"+txtStuNumber.Text.Trim()+"'";
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                myConn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectCmd,myConn);
                DataSet ds = new DataSet();
                sda.Fill(ds,"student");
                DataTable dt=ds.Tables["student"];
                if(dt.Rows.Count>0)
                {
                    dt.Rows[0].Delete();
                    sda.DeleteCommand = new SqlCommand(deleteCmd,myConn);
                    sda.Update(ds,"student");
                    MessageBox.Show("学生信息删除成功！");
                }
                else
                {
                    MessageBox.Show("学生信息不存在！","提示",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                }
                if(myConn.State==ConnectionState.Open)
                {
                    myConn.Close();
                    myConn.Dispose();
                }
            }
            
        }
       
    }
}
