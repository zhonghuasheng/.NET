using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08存储过程
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
        /// <summary>
        /// 检测用户输入的信息是否完整
        /// </summary>
        /// <returns>返回一个布尔值</returns>
        public bool CheckInfo()
        {
            //判断学号是否输入
            if (txtStuNumber.Text.Trim() == "")
            {
                Alert("学号不完整");
                return false;
            }
            else if (txtStuName.Text.Trim() == "")
            {
                Alert("姓名不完整");
                return false;
            }
            else if (txtStuAge.Text.Trim() == "")
            {
                Alert("年龄不完整");
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 返回显示的信息
        /// </summary>
        /// <param name="message">传入一个参数</param>
        public void Alert(string message)
        {
            MessageBox.Show(null, message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 通用数据库连接字符串
        /// </summary>
        string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
        /// <summary>
        /// 使用拼接字符串更新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddString_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConn = new SqlConnection(connectionText))
            {
                if (myConn.State == ConnectionState.Closed)
                {
                    //打开数据库连接
                    myConn.Open();
                }
                //更新操作字符串
                string updateQueryText = "update student set stuName='" + txtStuName.Text.Trim() + "',stuAge='" + txtStuAge.Text.Trim() + "' where stuNumber='" + txtStuNumber.Text.Trim() + "'";
                //新建更新命令对象
                SqlCommand myCmd = new SqlCommand(updateQueryText, myConn);
                //保存执行结果
                int recordAffected = myCmd.ExecuteNonQuery();
                myConn.Close();
                //提示结果
                Alert("更新数据数为" + recordAffected);

            }
        }
        /// <summary>
        /// 使用参数更新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUseParameter_Click(object sender, EventArgs e)
        {
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                if(myConn.State==ConnectionState.Closed)
                {
                    myConn.Open();
                }
                //参数命令字符串
                string updateQueryText = "update student set stuName=@stuName ,stuAge=@stuAge where stuNumber=@stuNumber";
                //新建更新命令对象
                SqlCommand myCmd = new SqlCommand(updateQueryText,myConn);
                //添加参数
                myCmd.Parameters.Add(new SqlParameter("@stuNumber",txtStuNumber.Text.Trim()));
                myCmd.Parameters.Add(new SqlParameter("@stuName", txtStuName.Text.Trim()));
                myCmd.Parameters.Add(new SqlParameter("@stuAge", txtStuAge.Text.Trim()));
                //保存存储结果
                int recordAffected = myCmd.ExecuteNonQuery();
                myConn.Close();
                //提示结果
                Alert("更新数据数为："+recordAffected);
            }
        }

        private void btnUseStoreProduce_Click(object sender, EventArgs e)
        {
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                if(myConn.State==ConnectionState.Closed)
                {
                    myConn.Open();
                }
                //新建命令对象
                SqlCommand myCmd = new SqlCommand("UpdateStudent",myConn);
                //指定命令类型为存储过程
                myCmd.CommandType = CommandType.StoredProcedure;
                //添加参数
                myCmd.Parameters.Add(new SqlParameter("@stuNumber",txtStuNumber.Text.Trim()));
                myCmd.Parameters.Add(new SqlParameter("@stuName",txtStuName.Text.Trim()));
                myCmd.Parameters.Add(new SqlParameter("@stuAge",txtStuAge.Text.Trim()));
                //保存执行结果
                int recordAffected = myCmd.ExecuteNonQuery();
                myConn.Close();
                //提示结果
                Alert("更新数据数为："+recordAffected);
            }
        }
    }
}
