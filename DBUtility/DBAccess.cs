using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace MoGuangYuan.DBUtility
{
    //负责执行 SQL 语句(SqlCommand 命令)。
    public class DBAccess
    {

        static SqlConnection conn = new SqlConnection();

        public static int ExecuteSQL(SqlCommand cmd) //根据传递进来的参数返回影响行数（使用ExecuteNonQuery执行Command命令）的方法
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString;
            cmd.Connection = conn;

            int printLine = 0;
            try
            {
                conn.Open();
                printLine = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return printLine;
        }


        public static object GetScalar(SqlCommand cmd)  //根据传递进来的参数返回一个唯一值（使用ExecuteScalar执行Command命令）的方法
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString;
            cmd.Connection = conn;

            object printResult = new object();
            try
            {
                conn.Open();
                printResult = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return printResult;
        }


        public static DataSet QueryData(SqlCommand cmd)        //根据传递进来的参数返回一个数据集（使用SqlDataAdapter执行Command命令）的方法   非连接状态下进行
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString;
            cmd.Connection = conn;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                sda.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return ds;
        }


        public static SqlDataReader ExcuteReader(SqlCommand cmd)    //根据传递进来的参数返回一个数据集（使用ExecuteReader执行Command命令）的方法   连接状态下进行
        {
            SqlDataReader rdr;
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new DBException(ex);
            }
            return rdr;
        }


        public static SqlTransaction ExecuteSqlTransaction(SqlCommand cmd)             //事务
        {

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString;
            cmd.Connection = conn;
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            cmd.Transaction = tran;
            return tran;

        }

        public static void CloseConnection() //关闭连接的方法 
        {
            if (conn.State==ConnectionState.Open)
            {
                conn.Close();                
            }
        } 
    }
}
