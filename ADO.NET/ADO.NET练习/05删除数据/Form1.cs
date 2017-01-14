using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _05删除数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblExpression.Text = "该练习是用来测试删除数据库中的数据的，先输入学号，\n在输入姓名。删除前先判断，输入的姓名与数据库中\n对应的姓名是否一致";
        }
        string connectionText = "Data Source=(local);DataBase=testDB;Integrated Security=true";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CheckIsNull();
            string selectCmdText="select stuName from student where stuNumber='"+txtStuNumber.Text+"'";
            string deleteCmdText="delete from student where stuNumber='"+txtStuNumber.Text+"'";
            //首先判断是否存在该学生
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                myConn.Open();
                //执行查询语句
                SqlCommand cmd = new SqlCommand(selectCmdText,myConn);
                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("不存在此学生", "走吧", MessageBoxButtons.RetryCancel);
                }
                else
                {
                    if (cmd.ExecuteScalar().ToString().Equals(txtStuName.Text))
                    {
                        cmd.CommandText = deleteCmdText;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("姓名错误");
                    }
                }
                 if(myConn.State==ConnectionState.Open)
                {
                    myConn.Close();
                    myConn.Dispose();
                }
            }
           
        }
        public void CheckIsNull()
        {
            if (txtStuNumber.Text == "" || txtStuName.Text == "")
            {
                MessageBox.Show("请输入完整的信息");
            }
        }
    }
}
