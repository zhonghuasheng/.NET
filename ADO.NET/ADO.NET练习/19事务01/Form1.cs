using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _19事务01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connStr = "Server=(local);DataBase=testDB;Integrated Security=true";
        string selectCmdText = "select * from Student";
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = SqlHelper.DataBanding(connStr, selectCmdText).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> strSqls = new List<string>();
            string strDelete =string.Format("delete from student where stuNumber='{0}'",txtDStuNumber.Text);
            string strInsert = string.Format("insert into student values('{0}','{1}',{2})", txtStuNumber.Text, txtStuName.Text, txtStuAge.Text);
            string strSelect = "select * from student where stuNumber='2010181055'";
            strSqls.Add(strDelete);
            strSqls.Add(strInsert);
            strSqls.Add(strSelect);
            if (SqlHelper.ExecDataBySqls(strSqls, connStr))
            {
                MessageBox.Show("事务执行成功");
            }
            //dataGridView1.DataSource = SqlHelper.DataBanding(connStr, selectCmdText).Tables[0];
            Form1_Load(sender,e);
            MessageBox.Show("加载成功");
        }
    }
}
