using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06更新数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionText = "Data Source=(local);database=testDB;Integrated Security=true";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                myConn.Open();
                string updateCmdText = "update student set stuName='"+txtStuName.Text.Trim()+"' where stuNumber='"+txtStuNumber.Text.Trim()+"'";
                SqlCommand cmd = new SqlCommand(updateCmdText,myConn);
                //如果不添加 cmd.ExecuteNonQuery();好像提交不到数据库中，查查为什么！
                string text = cmd.ExecuteNonQuery().ToString();
                MessageBox.Show(text);
            }
            
        }
    }
}
