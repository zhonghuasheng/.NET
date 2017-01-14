using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15将数据绑定到ComboxBox中
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestData();
        }
        public void TestData()
        {
            string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
            using(SqlConnection myConn=new SqlConnection(connectionText))
            {
                if(myConn.State==ConnectionState.Closed)
                {
                    myConn.Open();
                }
                //使用SqlCommand提交查询命令
                SqlCommand myCmd = new SqlCommand("select * from student",myConn);
                //获取数据适配器
                SqlDataAdapter mySDA = new SqlDataAdapter();
                mySDA.SelectCommand = myCmd;
                //填充DataSet
                DataSet myDS = new DataSet();
                mySDA.Fill(myDS);
                //将DataSet对象上的数据绑定到ComboxBox
                //cmbDataShow.DisplayMember = "stuNumber";
                cmbDataShow.ValueMember = "stuName";
                cmbDataShow.DataSource = myDS.Tables[0].DefaultView;
                //断开连接
                myConn.Close();
            }
        }

        private void cmbDataShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
             using (SqlConnection myConn = new SqlConnection(connectionText))
             {
                 if (myConn.State == ConnectionState.Closed)
                 {
                     myConn.Open();
                 }
                 //使用SqlCommand提交查询命令
                 SqlCommand myCmd = new SqlCommand("select * from student", myConn);
                 //获取数据适配器
                 SqlDataAdapter mySDA = new SqlDataAdapter();
                 mySDA.SelectCommand = myCmd;
                 SqlDataReader mySDR = myCmd.ExecuteReader();
                 while(mySDR.Read())
                 {
                     listBox1.Items.Add(mySDR[1].ToString());
                 }
                 myConn.Close();
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionText = "Data Source=(local);Database=testDB;Integrated Security=true";
            using (SqlConnection myConn = new SqlConnection(connectionText))
            {
                if (myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                }
                //使用SqlCommand提交查询命令
                SqlCommand myCmd = new SqlCommand("select * from student", myConn);
                SqlDataReader mySDR = myCmd.ExecuteReader();
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                while (mySDR.Read())
                {
                    ListViewItem myLVI = new ListViewItem(mySDR[0].ToString());
                    myLVI.SubItems.Add(mySDR[1].ToString());
                    listView1.Items.Add(myLVI);
                }
                myConn.Close();
            }
        }
    }
}
