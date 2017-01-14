using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _16ListView在数据库中的运用01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectText = "select * from student ";
            string connectionText = "Data Source=(local);DataBase=testDB;Integrated Security=true";
            using (SqlConnection myConn = new SqlConnection(connectionText))
            {
                if (myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                }
                try
                {
                    DataSet myDS = new DataSet();
                    SqlCommand myCmd = new SqlCommand(selectText,myConn);
                    SqlDataAdapter mySDA = new SqlDataAdapter(myCmd);
                    mySDA.Fill(myDS);
                    myConn.Close();
                    this.listView1.Columns.Add("学号",60,HorizontalAlignment.Left);
                    this.listView1.Columns.Add("姓名",60,HorizontalAlignment.Left);
                    this.listView1.Columns.Add("年龄",60,HorizontalAlignment.Left);
                    listView1.View = View.Details;
                    listView1.GridLines = true;
                    string[] str = new string[3];
                    foreach (DataRow row in myDS.Tables[0].Rows)
                    {
                        str[0] = row["stuNumber"].ToString();
                        str[1] = row["stuName"].ToString();
                        str[2] = row["stuAge"].ToString();
                        ListViewItem item = new ListViewItem(str,0);
                        listView1.Items.Add(item);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
