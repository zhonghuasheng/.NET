using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _17直接在DataGridView控件中修改数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection myConn;
        SqlDataAdapter mySDA;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            myConn = new SqlConnection("server=(local);database=testDB;integrated security=true");
            SqlDataAdapter mysda = new SqlDataAdapter("select * from student", myConn);
            DataSet ds = new DataSet();
            mysda.Fill(ds);
            dgvData.DataSource=ds.Tables[0];
            //dgvData.RowHeadersVisible = false;
            btnAdd.Enabled = false;
            dgvData.Columns[0].ReadOnly = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           if(dbUpdate())
           {
               MessageBox.Show("修改成功");
           }
        }
        private Boolean dbUpdate()
        {
            string strSql = "select * from student";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);
            DataTable dtShow = new DataTable();
            dtShow = (DataTable)this.dgvData.DataSource;
            for (int i = 0; i < dtShow.Rows.Count;i++ )
            {
                dtUpdate.ImportRow(dtShow.Rows[i]);
            }
            try
            {
                myConn.Open();
                SqlCommandBuilder command = new SqlCommandBuilder(this.mySDA);
                mySDA.Update(dtUpdate);
                myConn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;

            }
            dtUpdate.AcceptChanges();
            return true;
        }
        private DataTable dbconn(string strSql)
        {
            myConn.Open();
            this.mySDA = new SqlDataAdapter(strSql,myConn);
            DataTable dtSelect = new DataTable();
            int rtn = this.mySDA.Fill(dtSelect);
            myConn.Close();
            return dtSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgvData.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}
