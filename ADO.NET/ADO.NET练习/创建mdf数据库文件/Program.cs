using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace 创建mdf数据库文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("Data Directory", dataDir);
            }
            SqlConnection conn = new SqlConnection(@"Data source=.\SQLEXPRESS;
                  AttachDBFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
            Console.WriteLine("数据库连接成功");
            Console.ReadLine();
        }
    }
}
