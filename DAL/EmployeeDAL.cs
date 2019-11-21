using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MoGuangYuan.DBUtility;
using MoGuangYuan.Model;
using MoGuangYuan.Common;

namespace MoGuangYuan.DAL
{
    //对员工进行操作
    public class EmployeeDAL : IDAL<Employee>
    {
        private SqlCommand cmd;         //创建SqlCommand对象 为了调用方法
        private Encrypt encrypt;

        public EmployeeDAL()            //无参构造函数
        {
            cmd = new SqlCommand();     //实例化
            encrypt = new Encrypt();
            cmd.CommandType = CommandType.StoredProcedure; //cmd 执行的命令为 存储过程
        }

        public List<Employee> GetList()
        {
            cmd.CommandText = "empl_GetAllEmployee";
            cmd.Parameters.Clear();

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            //使用泛型集合
            List<Employee> list = new List<Employee>();
            while (rdr.Read())
            {
                Employee e = new Employee();
                e.EmployeeID = rdr["EmployeeID"].ToString();
                e.EmployeeName = rdr["EmployeeName"].ToString();
                e.Sex = Convert.ToInt32(rdr["Sex"]);
                e.Birthday = Convert.ToDateTime(rdr["Birthday"]);
                e.Brief = rdr["Brief"].ToString();

                list.Add(e);
            }
            rdr.Close();   //关闭连接
            return list;   //返回值
        }

        public bool Insert(Employee o)
        {

            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            //事务开始
            SqlTransaction tran = DBAccess.ExecuteSqlTransaction(cmd);
            try
            {
                //插入员工
                cmd.CommandText = "empl_InsertEmployee";   //要执行的存储过程
                cmd.Parameters.Clear();                    //清参数
                cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
                cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = o.EmployeeName;
                cmd.Parameters.Add("@Sex", SqlDbType.Bit).Value = o.Sex;
                cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = o.Birthday;
                cmd.Parameters.Add("@Brief", SqlDbType.NVarChar).Value = o.Brief;

                cmd.ExecuteNonQuery();

                //插入用户
                cmd.CommandText = "user_InsertSystemUser";   //要执行的存储过程
                cmd.Parameters.Clear();                      //清参数
                cmd.Parameters.Add("@userID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
                cmd.Parameters.Add("@password", SqlDbType.Binary, 50).Value = encrypt.encryPassword("666666");
                cmd.Parameters.Add("@baseFunction", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@purchaseFunction", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@saleFunction", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@userFunction", SqlDbType.Int).Value = 1;

                cmd.ExecuteNonQuery();

                tran.Commit();      //提交事务
                return true;
            }
            catch (Exception)
            {
                tran.Rollback(); //事务回滚
                return false;
            }
            finally
            {
                DBAccess.CloseConnection(); //关闭事务连接
            }
        }

        public bool Delete(Employee o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            cmd.CommandText = "empl_DeleteEmployeeByEmployeeID";   //要执行的存储过程
            cmd.Parameters.Clear();                                //清参数
            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;

            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result == 0)
                {
                    return false;    //删除失败 返回false
                }
                else
                {
                    return true;     //删除成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }

        public bool Update(Employee o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "empl_UpdateEmployeeByEmployeeID";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数
            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
            cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = o.EmployeeName;
            cmd.Parameters.Add("@Sex", SqlDbType.Bit).Value = o.Sex;
            cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = o.Birthday;
            cmd.Parameters.Add("@Brief", SqlDbType.NVarChar).Value = o.Brief;

            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result == 0)
                {
                    return false;    //更新失败 返回false
                }
                else
                {
                    return true;     //更新成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }

        public Employee FindByID(string id)
        {

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            cmd.CommandText = "empl_GetAllEmployeeByEmployeeID";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            while (rdr.Read())
            {
                Employee e = new Employee();
                e.EmployeeID = rdr["EmployeeID"].ToString().Trim();
                e.EmployeeName = rdr["EmployeeName"].ToString().Trim();
                e.Sex = Convert.ToInt32(rdr["Sex"]);
                e.Birthday = Convert.ToDateTime(rdr["Birthday"]);
                e.Brief = rdr["Brief"].ToString().Trim();

                rdr.Close();   //关闭连接
                return e;   //返回值
            }
            rdr.Close();   //关闭连接
            return null;   //返回值
        }
    }
}
