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
    //对客户进行操作
    public class CustomerDAL : IDAL<Customer>
    {
        private SqlCommand cmd;         //创建SqlCommand对象 为了调用方法
        public CustomerDAL()
        {
            cmd = new SqlCommand();     //实例化
            cmd.CommandType = CommandType.StoredProcedure; //cmd 执行的命令为 存储过程
        }


        public List<Customer> GetList()
        {
            cmd.CommandText = "cust_GetAllCustomer";
            cmd.Parameters.Clear();

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            //使用泛型集合
            List<Customer> list = new List<Customer>();
            while (rdr.Read())
            {
                Customer cust = new Customer();
                cust.CustomerID = rdr["CustomerID"].ToString().Trim();

                ContactInfo ci = new ContactInfo();

                ci.Name = rdr["CustomerName"].ToString().Trim();
                ci.SpellingCode = rdr["SpellingCode"].ToString().Trim();
                ci.Address = rdr["Address"].ToString().Trim();
                ci.ZipCode = rdr["ZipCode"].ToString().Trim();
                ci.Tel = rdr["Tel"].ToString().Trim();
                ci.Fax = rdr["Fax"].ToString().Trim();
                ci.BankName = rdr["BankName"].ToString().Trim();
                ci.BankAccount = rdr["BankAccount"].ToString().Trim();
                ci.Contacter = rdr["Contacter"].ToString().Trim();
                ci.Email = rdr["Email"].ToString().Trim();

                cust.CustomerContact = ci;

                list.Add(cust);
            }
            rdr.Close();   //关闭连接
            return list;   //返回值
        }

        public bool Insert(Customer o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "cust_InsertCustomer";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数

            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 80).Value = o.CustomerContact.Name;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 20).Value = o.CustomerContact.SpellingCode;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 80).Value = o.CustomerContact.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Char, 6).Value = o.CustomerContact.ZipCode;
            cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 20).Value = o.CustomerContact.Tel;
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar, 20).Value = o.CustomerContact.Fax;
            cmd.Parameters.Add("@BankName", SqlDbType.NVarChar, 40).Value = o.CustomerContact.BankName;
            cmd.Parameters.Add("@BankAccount", SqlDbType.NVarChar, 50).Value = o.CustomerContact.BankAccount;
            cmd.Parameters.Add("@Contacter", SqlDbType.NVarChar, 20).Value = o.CustomerContact.Contacter;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 30).Value = o.CustomerContact.Email;

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

        public bool Delete(Customer o)
        {

            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            cmd.CommandText = "cust_DeleteCustomerByCustomerID";   //要执行的存储过程
            cmd.Parameters.Clear();                                //清参数

            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;

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

        public bool Update(Customer o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "cust_UpdateCustomerByCustomerID";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数

            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 80).Value = o.CustomerContact.Name;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 20).Value = o.CustomerContact.SpellingCode;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 80).Value = o.CustomerContact.Address;
            cmd.Parameters.Add("@ZipCode", SqlDbType.Char, 6).Value = o.CustomerContact.ZipCode;
            cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 20).Value = o.CustomerContact.Tel;
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar, 20).Value = o.CustomerContact.Fax;
            cmd.Parameters.Add("@BankName", SqlDbType.NVarChar, 40).Value = o.CustomerContact.BankName;
            cmd.Parameters.Add("@BankAccount", SqlDbType.NVarChar, 50).Value = o.CustomerContact.BankAccount;
            cmd.Parameters.Add("@Contacter", SqlDbType.NVarChar, 20).Value = o.CustomerContact.Contacter;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 30).Value = o.CustomerContact.Email;

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

        public Customer FindByID(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            cmd.CommandText = "cust_GetAllCustomerByCustomerID";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 6).Value = id;    //参数1

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            while (rdr.Read())
            {
                Customer cust = new Customer();
                cust.CustomerID = rdr["CustomerID"].ToString().Trim();

                ContactInfo ci = new ContactInfo();

                ci.Name = rdr["CustomerName"].ToString().Trim();
                ci.SpellingCode = rdr["SpellingCode"].ToString().Trim();
                ci.Address = rdr["Address"].ToString().Trim();
                ci.ZipCode = rdr["ZipCode"].ToString().Trim();
                ci.Tel = rdr["Tel"].ToString().Trim();
                ci.Fax = rdr["Fax"].ToString().Trim();
                ci.BankName = rdr["BankName"].ToString().Trim();
                ci.BankAccount = rdr["BankAccount"].ToString().Trim();
                ci.Contacter = rdr["Contacter"].ToString().Trim();
                ci.Email = rdr["Email"].ToString().Trim();

                cust.CustomerContact = ci;

                rdr.Close();   //关闭连接
                return cust;   //返回值
            }
            rdr.Close();   //关闭连接
            return null;   //返回值

        }
    }
}
