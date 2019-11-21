using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MoGuangYuan.DBUtility;
using MoGuangYuan.Model;


namespace MoGuangYuan.DAL
{
    //对供应商进行操作
    public class SupplierDAL : IDAL<Supplier>
    {
        private SqlCommand cmd;         //创建SqlCommand对象 为了调用方法
        public SupplierDAL()            //无参构造函数
        {
            cmd = new SqlCommand();     //实例化
            cmd.CommandType = CommandType.StoredProcedure; //cmd 执行的命令为 存储过程
        }

        public List<Supplier> GetList()
        {
            cmd.CommandText = "supp_GetAllSupplier";
            cmd.Parameters.Clear();

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            //使用泛型集合
            List<Supplier> list = new List<Supplier>();
            while (rdr.Read())
            {
                Supplier s = new Supplier();
                s.SupplierID = rdr["SupplierID"].ToString().Trim();

                ContactInfo ci = new ContactInfo();
                ci.Name = rdr["SupplierName"].ToString().Trim();
                ci.SpellingCode = rdr["SpellingCode"].ToString().Trim();
                ci.Address = rdr["Address"].ToString().Trim();
                ci.ZipCode = rdr["ZipCode"].ToString().Trim();
                ci.Tel = rdr["Tel"].ToString().Trim();
                ci.Fax = rdr["Fax"].ToString().Trim();
                ci.BankName = rdr["BankName"].ToString().Trim();
                ci.BankAccount = rdr["BankAccount"].ToString().Trim();
                ci.Contacter = rdr["Contacter"].ToString().Trim();
                ci.Email = rdr["Email"].ToString().Trim();

                s.SupplierContact = ci;

                list.Add(s);
            }
            rdr.Close();   //关闭连接
            return list;   //返回值
        }

        public bool Insert(Supplier o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "supp_InsertSupplier";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数

            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
            cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 80).Value = o.SupplierContact.Name;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 20).Value = o.SupplierContact.SpellingCode;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 80).Value = o.SupplierContact.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Char, 6).Value = o.SupplierContact.ZipCode;
            cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 20).Value = o.SupplierContact.Tel;
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar, 20).Value = o.SupplierContact.Fax;
            cmd.Parameters.Add("@BankName", SqlDbType.NVarChar, 40).Value = o.SupplierContact.BankName;
            cmd.Parameters.Add("@BankAccount", SqlDbType.NVarChar, 50).Value = o.SupplierContact.BankAccount;
            cmd.Parameters.Add("@Contacter", SqlDbType.NVarChar, 20).Value = o.SupplierContact.Contacter;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 30).Value = o.SupplierContact.Email;

            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result == 0)
                {
                    return false;    //插入失败 返回false
                }
                else
                {
                    return true;     //插入成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }

        public bool Delete(Supplier o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            cmd.CommandText = "supp_DeleteSupplierBySupplierID";   //要执行的存储过程
            cmd.Parameters.Clear();                                //清参数

            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;

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

        public bool Update(Supplier o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "supp_UpdateSupplierBySupplierID";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数

            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
            cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar, 80).Value = o.SupplierContact.Name;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 20).Value = o.SupplierContact.SpellingCode;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 80).Value = o.SupplierContact.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Char, 6).Value = o.SupplierContact.ZipCode;
            cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 20).Value = o.SupplierContact.Tel;
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar, 20).Value = o.SupplierContact.Fax;
            cmd.Parameters.Add("@BankName", SqlDbType.NVarChar, 40).Value = o.SupplierContact.BankName;
            cmd.Parameters.Add("@BankAccount", SqlDbType.NVarChar, 50).Value = o.SupplierContact.BankAccount;
            cmd.Parameters.Add("@Contacter", SqlDbType.NVarChar, 20).Value = o.SupplierContact.Contacter;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 30).Value = o.SupplierContact.Email;

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

        public Supplier FindByID(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            cmd.CommandText = "supp_GetAllSupplierBySupplierID";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = id;    //参数1

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            while (rdr.Read())
            {
                Supplier s = new Supplier();
                s.SupplierID = rdr["SupplierID"].ToString().Trim();

                ContactInfo ci = new ContactInfo();
                ci.Name = rdr["SupplierName"].ToString().Trim();
                ci.SpellingCode = rdr["SpellingCode"].ToString().Trim();
                ci.Address = rdr["Address"].ToString().Trim();
                ci.ZipCode = rdr["ZipCode"].ToString().Trim();
                ci.Tel = rdr["Tel"].ToString().Trim();
                ci.Fax = rdr["Fax"].ToString().Trim();
                ci.BankName = rdr["BankName"].ToString().Trim();
                ci.BankAccount = rdr["BankAccount"].ToString().Trim();
                ci.Contacter = rdr["Contacter"].ToString().Trim();
                ci.Email = rdr["Email"].ToString().Trim();

                s.SupplierContact = ci;

                rdr.Close();   //关闭连接
                return s;   //返回值
            }
            rdr.Close();   //关闭连接
            return null;   //返回值
        }
    }
}
