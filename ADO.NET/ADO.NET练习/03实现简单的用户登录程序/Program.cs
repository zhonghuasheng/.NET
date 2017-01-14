using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace _03实现简单的用户登录程序
{
    /// <summary>
    /// 在数据库DataBase3中事先存储好用户信息
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Relwase\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.FullName;
                AppDomain.CurrentDomain.SetData("DstaDirectory",dataDir);
            }
            Console.WriteLine("请输入用户名：");
            string userN = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string passW = Console.ReadLine();
         
            string con = @"Data Source=.\SQLExPRESS;AttachDBFilename=|DataDirectory|\Database3.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string cmdText = "select pwd from UserInformation where userName='" + userN + "'";
            SqlCommand cmd = new SqlCommand(cmdText,conn);
            //SqlDataReader myRerader;
           // myRerader=cmd.ExecuteReader();
            
            try
            {
                string s = cmd.ExecuteScalar().ToString();
                // Console.WriteLine(s);
                //Console.ReadLine();
                if (s == passW)
                {
                    Console.WriteLine("欢迎登录！");
                }
             }
            catch(Exception e)
            {
               Console.WriteLine("报错："+ e.Message);
            }
            Console.ReadLine();
            //while(myRerader.Read())
            //{
            //    string returnPwd = myRerader.Read().ToString();
            //    //string returnPwd = myRerader["psw"].ToString();
            //    if(returnPwd==passW)
            //    {
            //        Console.WriteLine("在数据库中有该用户！");
            //    }
            //}
            if (conn.State==ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
            Console.ReadLine();
        }
    }
}
