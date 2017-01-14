using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _18数据读取器SqlDataReader的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection myConn = new SqlConnection("Server=(local);DataBase=testDB;Integrated Security=true");
            SqlCommand myCmd = new SqlCommand("select * from student",myConn);
            myConn.Open();
            SqlDataReader myReader = myCmd.ExecuteReader();
            while(myReader.Read())
            {
                Console.WriteLine("学号：{0}\t\t姓名：{1}\t\t年龄：{2}",myReader["stuNumber"].ToString(),myReader["stuName"].ToString(),myReader["stuAge"].ToString());
            }
            //for (int i = 0; i < myReader.FieldCount;i++ )
            //{
            //    Console.WriteLine(myReader.GetName(i),myReader.GetValue(i).ToString());
            //}
            Console.ReadLine();
        }
    }
}
