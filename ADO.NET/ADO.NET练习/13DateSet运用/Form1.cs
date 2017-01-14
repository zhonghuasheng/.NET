using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13DateSet运用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                if(myConn.State==ConnectionState.Closed)
                {
                    myConn.Open();
                }
                DataSet dsClass = new DataSet();
                DataTable dtClass = new DataTable("Class");
                DataColumn dcClassName = new DataColumn("ClassName", typeof(string));
                dcClassName.MaxLength = 50;
                DataColumn dcGradeID = new DataColumn("GradeID",typeof(int));
                dtClass.Columns.Add(dcClassName);
                dtClass.Columns.Add(dcGradeID);
                DataRow drClass = dtClass.NewRow();
                drClass["ClassName"] = this.txtClassName.Text.Trim();
                drClass["GradeID"] =Convert.ToInt32( this.txtGradeName.Text.Trim());
                dtClass.Rows.Add(drClass);
                dsClass.Tables.Add(dtClass);
            }
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
            using (SqlConnection myConn = new SqlConnection(connectionText))
            {
                if(myConn.State==ConnectionState.Closed)
                {
                    myConn.Open();
                }
                string commandText = "create table ClassInfo (ClassName varchar(50) primary key ,ClassNumber int )";
                SqlCommand myCmd = new SqlCommand(commandText,myConn);
                
                myCmd.ExecuteNonQuery();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
               string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
               using (SqlConnection myConn = new SqlConnection(connectionText))
               {
                   if (myConn.State == ConnectionState.Closed)
                   {
                       myConn.Open();
                   }
                   string insertCommand = "insert into Class values('果冻',1)";
                   SqlCommand myCmd = new SqlCommand(insertCommand,myConn);
                   myCmd.ExecuteNonQuery();
               }
        }
    }
}
