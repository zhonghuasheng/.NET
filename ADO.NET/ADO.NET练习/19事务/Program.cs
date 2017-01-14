using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _19事务
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入学号");
            string stuNum = Console.ReadLine();
            string connectionText = "Server=(local);DataBase=testDB;Integrated Security=true";
            string selectCommand = "select * from student where stuNumber='"+stuNum+"'";
            SqlConnection myConn = new SqlConnection(connectionText);
            myConn.Open();
            SqlCommand myCmd = new SqlCommand(selectCommand,myConn);
            using(SqlDataReader dr=myCmd.ExecuteReader())
            {
                while(dr.Read())
                {
                    Console.WriteLine("{0}-{1}-{2}",dr["stuNumber"].ToString(),dr["stuName"].ToString(),dr["stuAge"].ToString());
                }
            }
            SqlCommand myRemove = new SqlCommand(string.Format("delete from student where stuNumber={0}",stuNum),myConn);
            SqlCommand mySelect = new SqlCommand(string.Format("select * from student where stuNumber={0}",stuNum),myConn);
            SqlTransaction tx = null;
            try
            {
                tx = myConn.BeginTransaction();
                myRemove.Transaction = tx;
                mySelect.Transaction = tx;
                myRemove.ExecuteNonQuery();
                mySelect.ExecuteNonQuery();
                tx.Commit();
               
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                tx.Rollback();
            }
            Console.ReadLine();
        }
    }
}