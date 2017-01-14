using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07查询操作
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

        private void rbtExecuteNoneQuery_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtExecuteNoneQuery.Checked)
            {
                string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
                string commandText = "update student set stuName='魏' where stuNumber='"+txtStuNumber.Text+"'";
                using (SqlConnection myConn = new SqlConnection(connectionText))
                {
                    if (myConn.State == ConnectionState.Closed)
                    {
                        myConn.Open();
                    }
                    SqlCommand myCmd = new SqlCommand(commandText, myConn);
                    int i = myCmd.ExecuteNonQuery();
                    lblResult.Text = i.ToString();
                }
            }
        }
    
    }
}

