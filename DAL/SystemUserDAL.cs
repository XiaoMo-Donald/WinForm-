using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MoGuangYuan.DBUtility;
using MoGuangYuan.Model;
using MoGuangYuan.Common;

namespace MoGuangYuan.DAL
{
    //对系统用户进行操作

    public class SystemUserDAL 
    {
        private SqlCommand cmd;          //创建SqlCommand对象 为了调用方法
        private Encrypt encrypt;
        public SystemUserDAL()            //无参构造函数
        {
            cmd = new SqlCommand();      //实例化
            encrypt = new Encrypt();
            cmd.CommandType = CommandType.StoredProcedure; //cmd 执行的命令为 存储过程
        }

        public List<SystemUser> GetList()   //获取所有的用户ID（员工）
        {
            cmd.CommandText = "user_GelAllSystemUser";
            cmd.Parameters.Clear();

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            //使用泛型集合
            List<SystemUser> list = new List<SystemUser>();
            while (rdr.Read())
            {
                SystemUser u = new SystemUser();
                u.UserID = rdr["UserID"].ToString();
                u.Password = (byte[])rdr["Password"];
                u.BaseFunction = Convert.ToInt16(rdr["BaseFunction"]);
                u.PurchaseFunction = Convert.ToInt16(rdr["PurchaseFunction"]);
                u.SaleFunction = Convert.ToInt16(rdr["SaleFunction"]);
                u.UserFunction = Convert.ToInt16(rdr["UserFunction"]);
                list.Add(u);
            }
            rdr.Close();   //关闭连接
            return list;   //返回值
        }
        public List<string> GetAllUserID()   //获取所有的用户ID
        {

            cmd.CommandText = "user_GelAllSystemUser";
            cmd.Parameters.Clear();
            List<string> list = new List<string>();
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
            while (rdr.Read())
            {
                string userid = rdr["UserID"].ToString().Trim();
                list.Add(userid);
            }
            rdr.Close();
            return list;
        }

        public bool Delete(SystemUser o)          //删除用户（该界面可能用不到）
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            cmd.CommandText = "user_DeleteSystemUser";   //要执行的存储过程
            cmd.Parameters.Clear();                                //清参数

            cmd.Parameters.Add("@userID", SqlDbType.NVarChar, 6).Value = o.UserID;

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

        public bool Update(SystemUser o)    //更新用户权限
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "user_UpdateSystemUser";   //要执行的存储过程
            SetUserParameters(o);                        //设置参数（封装为方法）

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

        public SystemUser FindByID(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            cmd.CommandText = "user_GelAllSystemUserByUserID";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@userID", SqlDbType.NVarChar, 6).Value = id;

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            while (rdr.Read())
            {
                SystemUser u = new SystemUser();
                u.UserID = rdr["UserID"].ToString();
                u.Password = (byte[])rdr["Password"];  //密码加密
                u.BaseFunction = Convert.ToInt16(rdr["BaseFunction"]);
                u.PurchaseFunction = Convert.ToInt16(rdr["PurchaseFunction"]);
                u.SaleFunction = Convert.ToInt16(rdr["SaleFunction"]);
                u.UserFunction = Convert.ToInt16(rdr["UserFunction"]);

                rdr.Close();   //关闭连接
                return u;   //返回值
            }
            rdr.Close();   //关闭连接
            return null;   //返回值
        }
        public bool UserLogin(string userid, string password)
        {
           
            if (userid==null)
            {
                throw new ArgumentNullException("userid");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            cmd.CommandText = "user_UserLogin";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userID", SqlDbType.NChar, 6).Value = userid;
            cmd.Parameters.Add("@password", SqlDbType.Binary, 50).Value = encrypt.encryPassword(password); //密码加密
            try
            {
                object o = DBAccess.GetScalar(cmd);
                if ((int)o == 0)
                {
                    return false;    //登录失败 返回false
                }
                else
                {
                    return true;     //登录成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }
        public bool ChangeUserPassword(string userID, string password)    //修改密码
        {
            cmd.CommandText = "user_ChangeUserPassword";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userID", SqlDbType.NChar, 6).Value = userID;
            cmd.Parameters.Add("@password", SqlDbType.Binary, 50).Value = encrypt.encryPassword(password); //密码加密
            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result == 0)
                {
                    return false;    //修改失败 返回false
                }
                else
                {
                    return true;     //修改成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }

        private void SetUserParameters(SystemUser o)    //设置参数（封装为方法）
        {
            cmd.Parameters.Clear();                      //清参数

            cmd.Parameters.Add("@userID", SqlDbType.NVarChar, 6).Value = o.UserID;
            cmd.Parameters.Add("@password", SqlDbType.Binary,50).Value = o.Password;
            cmd.Parameters.Add("@baseFunction", SqlDbType.Int).Value = o.BaseFunction;
            cmd.Parameters.Add("@purchaseFunction", SqlDbType.Int).Value = o.PurchaseFunction;
            cmd.Parameters.Add("@saleFunction", SqlDbType.Int).Value = o.SaleFunction;
            cmd.Parameters.Add("@userFunction", SqlDbType.Int).Value = o.UserFunction;
        }

    }
}
