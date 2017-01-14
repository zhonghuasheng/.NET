using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _14管理内存数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 使用DataTable实现内存表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAndShow_Click(object sender, EventArgs e)
        {
            //首先声明一个DataTable
            DataTable myDT = new DataTable("StudentInfo");

            //生成学号列，并放入DataTable中
            DataColumn myDCStuNumber = new DataColumn();
            //设置学号列的数据类型Int32
            myDCStuNumber.DataType = System.Type.GetType("System.Int32");
            //设置学号的列名为学号
            myDCStuNumber.ColumnName = "学号";
            myDT.Columns.Add(myDCStuNumber);

            //生成姓名列，并放入DataTable中
            DataColumn myDTStuName = new DataColumn();
            //设置姓名列的数据类型为String类型
            myDTStuName.DataType = System.Type.GetType("System.String");
            //设置姓名列的列名为姓名
            myDTStuName.ColumnName = "姓名";
            myDT.Columns.Add(myDTStuName);

            //设置学号列作为DataTable主键
            DataColumn [] PrimaryKeyColumns=new DataColumn[1];
            PrimaryKeyColumns[0]=myDT.Columns["学号"];
            myDT.PrimaryKey = PrimaryKeyColumns;
            
            //向DataTable中插入数据
            DataRow myDR1 = myDT.NewRow();
            myDR1["学号"] = 2010181001;
            myDR1["姓名"] = "春天";
            myDT.Rows.Add(myDR1);

            DataRow myDR2 = myDT.NewRow();
            myDR2["学号"] = 2010181002;
            myDR2["姓名"] = "夏天";
            myDT.Rows.Add(myDR2);

            DataRow myDR3 = myDT.NewRow();
            myDR3["学号"] = 2010181003;
            myDR3["姓名"] = "秋天天";
            myDT.Rows.Add(myDR3);

            DataRow myDR4 = myDT.NewRow();
            myDR4["学号"] = 2010181004;
            myDR4["姓名"] = "冬天";
            myDT.Rows.Add(myDR4);

            //显示DataTable中的数据
            this.dataGridView1.DataSource = myDT;
        }
    }
}
