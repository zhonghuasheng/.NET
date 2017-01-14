using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace _19事务_TransactionScope
{
    class SqlHelper
    {
        public static DataSet DataBinding(string strConn, string cmdText,string tableName)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(cmdText,conn);
                DataSet ds = new DataSet();
                sda.Fill(ds,tableName);
                return ds;
            }
        }
        public static bool IsSucceed(List<string> sqls, string strConn)
        {
            bool isSucceed = false;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                try
                {
                    using (TransactionScope tran = new TransactionScope())
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        foreach (string sql in sqls)
                        {
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }
                        isSucceed = true;
                    }
                }
                catch
                {
                    //MessageBox.Show("事务执行失败");
                    isSucceed = false;
                }
            }
            return isSucceed;
        }
    }
}
