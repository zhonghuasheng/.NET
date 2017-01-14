using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _12使用DataTable向数据库中添加表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection(connectionText);
            myConn.Open();
            DataTable CustomersTable = new DataTable("Customers");
            //DataRow arow = CustomersTable.NewRow();
        }
    }
}
