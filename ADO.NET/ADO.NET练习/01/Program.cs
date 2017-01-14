using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _001-连接
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory",dataDir);
            }
            string conText = @"Data source=.\SQLEXPRESS;
                  AttachDBFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True";
            SqlConnection sql = new SqlConnection(conText);
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
                Console.WriteLine("测试连接成功！");
            }
            Console.ReadLine();
        }
    }
}
