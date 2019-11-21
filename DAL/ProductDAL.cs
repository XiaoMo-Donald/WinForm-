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
    //对产品进行操作
    public class ProductDAL : IDAL<Product>
    {
        private SqlCommand cmd;         //创建SqlCommand对象 为了调用方法
        public ProductDAL()
        {
            cmd = new SqlCommand();     //实例化
            cmd.CommandType = CommandType.StoredProcedure; //cmd 执行的命令为 存储过程
        }

        public List<Product> GetList()
        {
            cmd.CommandText = "prod_GetAllProduct";
            cmd.Parameters.Clear();

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            //使用泛型集合
            List<Product> list = new List<Product>();
            while (rdr.Read())
            {
                Product prod = new Product();
                prod.ProductID = rdr["ProductID"].ToString().Trim();
                prod.ProductName = rdr["ProductName"].ToString().Trim();
                prod.SpellingCode = rdr["SpellingCode"].ToString().Trim();
                prod.Barcode = rdr["Barcode"].ToString().Trim();
                prod.Special = rdr["Special"].ToString().Trim();
                prod.Unit = rdr["Unit"].ToString().Trim();
                prod.Origin = rdr["Origin"].ToString().Trim();
                prod.CategoryID = rdr["CategoryID"].ToString().Trim();
                prod.PurchasePrice = Convert.ToDouble(rdr["PurchasePrice"].ToString().Trim());
                prod.SalePrice = Convert.ToDouble(rdr["SalePrice"].ToString().Trim());
                prod.Quantity = Convert.ToInt32(rdr["Quantity"].ToString().Trim());

                list.Add(prod);
            }
            rdr.Close();   //关闭连接
            return list;   //返回值
        }

        public bool Insert(Product o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "prod_InsertProduct";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数

            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = o.ProductID;
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 80).Value = o.ProductName;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 40).Value = o.SpellingCode;
            cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar, 14).Value = o.Barcode;
            cmd.Parameters.Add("@Special", SqlDbType.NVarChar, 40).Value = o.Special;
            cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 6).Value = o.Unit;
            cmd.Parameters.Add("@Origin", SqlDbType.NVarChar, 50).Value = o.Origin;
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
            cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = o.PurchasePrice;
            cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = o.SalePrice;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = o.Quantity;

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

        public bool Delete(Product o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            cmd.CommandText = "prod_DeleteProductByProductID";   //要执行的存储过程
            cmd.Parameters.Clear();                           //清参数

            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = o.ProductID;

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

        public bool Update(Product o)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "prod_UpdateProductByProductID";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数

            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = o.ProductID;
            cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar, 80).Value = o.ProductName;
            cmd.Parameters.Add("@SpellingCode", SqlDbType.NVarChar, 40).Value = o.SpellingCode;
            cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar, 14).Value = o.Barcode;
            cmd.Parameters.Add("@Special", SqlDbType.NVarChar, 40).Value = o.Special;
            cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 6).Value = o.Unit;
            cmd.Parameters.Add("@Origin", SqlDbType.NVarChar, 50).Value = o.Origin;
            cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
            cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = o.PurchasePrice;
            cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = o.SalePrice;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = o.Quantity;

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

        public Product FindByID(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            cmd.CommandText = "prod_GetAllProductByProductID";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = id;    //参数1

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            while (rdr.Read())
            {          
                Product prod = new Product();

                prod.ProductID = rdr["ProductID"].ToString().Trim();
                prod.ProductName = rdr["ProductName"].ToString().Trim();
                prod.SpellingCode = rdr["SpellingCode"].ToString().Trim();
                prod.Barcode = rdr["Barcode"].ToString().Trim();
                prod.Special = rdr["Special"].ToString().Trim();
                prod.Unit = rdr["Unit"].ToString().Trim();
                prod.Origin = rdr["Origin"].ToString().Trim();
                prod.CategoryID = rdr["CategoryID"].ToString().Trim();
                prod.PurchasePrice = Convert.ToDouble(rdr["PurchasePrice"].ToString().Trim());
                prod.SalePrice = Convert.ToDouble(rdr["SalePrice"].ToString().Trim());
                prod.Quantity = Convert.ToInt32(rdr["Quantity"].ToString().Trim());

                rdr.Close();   //关闭连接
                return prod;   //返回值
            }
            rdr.Close();   //关闭连接
            return null;   //返回值
        }

      
        public List<Product> SelectProductBySpellingCode(string spellingCode)
        {
            cmd.CommandText = "SelectProductBySpellingCode";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 40).Value = spellingCode;  
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            //使用泛型集合
            List<Product> list = new List<Product>();
            while (rdr.Read())
            {
                Product prod = new Product();
                prod.ProductID = rdr["ProductID"].ToString().Trim();
                prod.ProductName = rdr["ProductName"].ToString().Trim();
                prod.SpellingCode = rdr["SpellingCode"].ToString().Trim();
                prod.Barcode = rdr["Barcode"].ToString().Trim();
                prod.Special = rdr["Special"].ToString().Trim();
                prod.Unit = rdr["Unit"].ToString().Trim();
                prod.Origin = rdr["Origin"].ToString().Trim();
                prod.CategoryID = rdr["CategoryID"].ToString().Trim();
                prod.PurchasePrice = Convert.ToDouble(rdr["PurchasePrice"].ToString().Trim());
                prod.SalePrice = Convert.ToDouble(rdr["SalePrice"].ToString().Trim());
                prod.Quantity = Convert.ToInt32(rdr["Quantity"].ToString().Trim());

                list.Add(prod);
            }
            rdr.Close();   //关闭连接
            return list;   //返回值
        }
    }
}
