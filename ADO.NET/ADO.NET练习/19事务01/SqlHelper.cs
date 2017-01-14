using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _19事务01
{
    class SqlHelper
    {
        public static bool ExecDataBySqls(List<string> strSqls, string strConn)
        {
            SqlConnection sqlConn = new SqlConnection(strConn);
            bool boolIsSucceed = false;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConn;
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            SqlTransaction sqlTran = sqlConn.BeginTransaction();//启动一个事务
            try
            {
                sqlCmd.Transaction = sqlTran;//为事务创建一个命令
                foreach (string item in strSqls)
                {
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = item;
                    sqlCmd.ExecuteNonQuery();
                }
                sqlTran.Commit();//提交事务
                boolIsSucceed = true;
            }
            catch
            {
                sqlTran.Rollback();//回滚事务，恢复数据
                boolIsSucceed = false;
            }
            finally
            {
                sqlConn.Close();
                strSqls.Clear();
            }
            return boolIsSucceed;
        }
        public static DataSet DataBanding(string connStr,string selectCmdText)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter(selectCmdText, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Student");
                return ds;
            }
        }
    }
}
