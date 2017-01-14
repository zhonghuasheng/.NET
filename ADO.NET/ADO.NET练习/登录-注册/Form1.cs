using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 登录_注册
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Relwase\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.FullName;
                AppDomain.CurrentDomain.SetData("DstaDirectory", dataDir);
            }
            string con = @"Data Source=.\SQLExPRESS;AttachDBFilename=|DataDirectory|\Load.mdf;Integrated Security=True;User Instance=True";
            SqlConnection sql = new SqlConnection(con);
            sql.Open();

            //lblResult.Text = "测试连接数据库成功";
            //使用SqlCommand对象执行查询命令
            string commandText = "select stuName from Students where stuNumber='" + txtStuNumber.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(commandText, sql);
            //cmd.Connection = sql;
            //cmd.CommandText = commandText;
            SqlDataReader myReader = cmd.ExecuteReader();
            try
            {
                if (myReader.Read() == true)
                {
                    string name = myReader["stuName"].ToString();
                    if (name == txtStuName.Text)
                    {
                        lblResult.Text = "是自己人";
                    }
                }
                else
                {
                    lblResult.Text = "用户名或者密码错误！";
                }
            }
            catch(Exception ex)
            {
                lblResult.Text = ex.ToString();
            }
            finally
            {
                if (sql.State == ConnectionState.Open)
                {
                    sql.Close();
                    sql.Dispose();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Relwase\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.FullName;
                AppDomain.CurrentDomain.SetData("DstaDirectory", dataDir);
            }
            string con = @"Data Source=.\SQLExPRESS;AttachDBFilename=|DataDirectory|\Load.mdf;Integrated Security=True;User Instance=True";
            SqlConnection sql = new SqlConnection(con);

            string insertCmd = "insert into students(stuNumber,stuName) values ('" + txtStuNumber.Text + "','" + txtStuName.Text + "')";
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter(insertCmd,sql);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds,"students");
            DataRow dr = ds.Tables["students"].NewRow();
            dr["stuNumber"] = txtStuNumber.Text;
            dr["stuName"] = txtStuName.Text;
            ds.Tables["students"].Rows.Add(dr);
            SqlCommandBuilder sqlscb = new SqlCommandBuilder(da);
            da.Update(ds,"students");
        }
    }
}
