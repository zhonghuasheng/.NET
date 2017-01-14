using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 投票测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("Data Directory", dataDir);
            }
            SqlConnection myConn = new SqlConnection(@"Data source=.\SQLEXPRESS;
                  AttachDBFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            myConn.Open();
            SqlCommand cmd = new SqlCommand("update vote set votes=12 ",myConn);
            string a = cmd.ExecuteNonQuery().ToString();
            SqlCommand myCmd = new SqlCommand("select votes from vote where name='张三'",myConn);
            string b = myCmd.ExecuteScalar().ToString();
            label1.Text = a + "     " + b;
            myConn.Close();
            myConn.Dispose();
        }
    }
}
