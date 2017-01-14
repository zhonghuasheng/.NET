using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _19事务_TransactionScope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strConn = "Server=(local);DataBase=testDB;Integrated Security=true";
        string cmdText = "select * from Student";
        private void Form1_Load(object sender, EventArgs e)
        {
            string tableName="Studnet";
            dataGridView1.DataSource=SqlHelper.DataBinding(strConn,cmdText,tableName).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> sqls = new List<string>();
            string insertText = string.Format("insert into Student values('{0}','{1}',{2})",txtStuNumber.Text,txtStuName.Text,txtStuAge.Text);
            string deleteText = string.Format("delete from Sudent where stuNumber='{0}'",txtDStuNumber.Text);
            string selectText = "select * from Student";
            sqls.Add(insertText);
            sqls.Add(deleteText);
            sqls.Add(selectText);
            if (SqlHelper.IsSucceed(sqls, strConn))
            {
                MessageBox.Show("事务执行成功");
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("事务执行失败");
            }
        }
    }
}
