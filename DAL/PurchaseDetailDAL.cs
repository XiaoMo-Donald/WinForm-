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
    //对入库明细进行操作
    public class PurchaseDetailDAL : IDAL<PurchaseDetail>
    {
        private SqlCommand cmd;         //创建SqlCommand对象 为了调用方法
        public PurchaseDetailDAL()
        {
            cmd = new SqlCommand();                        //cmd 对象实例化
            cmd.CommandType = CommandType.StoredProcedure; //cmd 执行的命令为 存储过程
        }

        public bool Insert(PurchaseDetail o)
        {
            throw new NotImplementedException();
            //if (o == null)
            //{
            //    throw new ArgumentNullException("o");
            //}

            //cmd.CommandText = "InsertPurchaseDetail";   //要执行的存储过程
            //cmd.Parameters.Clear();                     //清参数

            //cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = o.ProductID;
            //cmd.Parameters.Add("@PurchaseDetailID", SqlDbType.SmallInt).Value = o.PurchaseDetailID;
            //cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = o.ProductID;
            //cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal, 18).Value = o.PurchasePrice;
            //cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = o.Quantity;

            //try
            //{
            //    int result = DBAccess.ExecuteSQL(cmd);
            //    if (result == 0)
            //    {
            //        return false;    //插入失败 返回false
            //    }
            //    else
            //    {
            //        return true;     //插入成功 返回true
            //    }
            //}
            //catch (Exception)
            //{
            //    return false;        //异常   返回false
            //}
        }

        public bool Delete(PurchaseDetail o)
        {
            throw new NotImplementedException();
            //if (o == null)
            //{
            //    throw new ArgumentNullException("o");
            //}
            //cmd.CommandText = "DeletePurchaseDetailByPurchaseDetailID";   //要执行的存储过程
            //cmd.Parameters.Clear();                                       //清参数

            //cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = o.ProductID;

            //try
            //{
            //    int result = DBAccess.ExecuteSQL(cmd);
            //    if (result == 0)
            //    {
            //        return false;    //删除失败 返回false
            //    }
            //    else
            //    {
            //        return true;     //删除成功 返回true
            //    }
            //}
            //catch (Exception)
            //{
            //    return false;        //异常   返回false
            //}
        }

        public List<PurchaseDetail> GetList()
        {
            throw new NotImplementedException();
        }


        public bool Update(PurchaseDetail o)
        {
            throw new NotImplementedException();
        }

        public PurchaseDetail FindByID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
