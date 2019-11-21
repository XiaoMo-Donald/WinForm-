using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MoGuangYuan.Model;
using MoGuangYuan.DBUtility;

namespace MoGuangYuan.DAL
{
    //对入库进行操作
    public class PurchaseBillDAL : IDAL<PurchaseBill>
    {
        private SqlCommand cmd;
        public PurchaseBillDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public List<string> FindPurchaseIDByID(string id)         //根据订单查询订单号 
        {
            cmd.CommandText = "purc_FindPurchaseIDByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NVarChar, 12).Value = id;

            List<string> list = new List<string>();
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
            while (rdr.Read())
            {
                string s = rdr["PurchaseID"].ToString().Trim();
                list.Add(s);
            }
            //关闭连接
            rdr.Close();
            //返回值
            return list;
        }

        public List<string> FindPurchaseIDByClerk(string clerk)         //按业务员查询
        {
            cmd.CommandText = "purc_FindPurchaseIDByClerk";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = clerk;

            List<string> list = new List<string>();
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
            while (rdr.Read())
            {
                string s = rdr["PurchaseID"].ToString().Trim();
                list.Add(s);
            }
            //关闭连接
            rdr.Close();
            //返回值
            return list;
        }

        public List<string> FindPurchaseIDByExaminer(string examiner)        //按审核员查询
        {
            cmd.CommandText = "purc_FindPurchaseIDByExaminer";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar, 80).Value = examiner;

            List<string> list = new List<string>();
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
            while (rdr.Read())
            {
                string s = rdr["PurchaseID"].ToString().Trim();
                list.Add(s);
            }
            //关闭连接
            rdr.Close();
            //返回值
            return list;
        }

        public List<string> FindPurchaseIDByOnProcess(int onProcess)        //按完成状态查询
        {
            cmd.CommandText = "purc_FindPurchaseIDByOnProcess";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@OnProcess", SqlDbType.SmallInt).Value = onProcess;

            List<string> list = new List<string>();
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
            while (rdr.Read())
            {
                string s = rdr["PurchaseID"].ToString().Trim();
                list.Add(s);
            }
            //关闭连接
            rdr.Close();
            //返回值
            return list;
        }

        public List<string> FindPurchaseIDByPurchaseDate(DateTime beginPurchaseDate, DateTime endPurchaseDate)        //按订单日期查询
        {
            cmd.CommandText = "purc_FindPurchaseIDByPurchaseDate";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BeginPurchaseDate", SqlDbType.DateTime).Value = beginPurchaseDate;
            cmd.Parameters.Add("@EndPurchaseDate", SqlDbType.DateTime).Value = endPurchaseDate;

            List<string> list = new List<string>();
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
            while (rdr.Read())
            {
                string s = rdr["PurchaseID"].ToString().Trim();
                list.Add(s);
            }
            //关闭连接
            rdr.Close();
            //返回值
            return list;
        }


        public PurchaseBill FindByID(string id)   //根据ID查询订单基本信息和订单明细
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            //获取订单明细
            cmd.CommandText = "GetPurchaseDetailAll";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = id;

            List<PurchaseDetail> list = new List<PurchaseDetail>();
            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
            while (rdr.Read())
            {
                PurchaseDetail detail = new PurchaseDetail();

                detail.PurchaseID = rdr["PurchaseID"].ToString().Trim();

                detail.PurchaseDetailID = Convert.ToInt16(rdr["PurchaseDetailID"]);
                detail.ProductID = rdr["ProductID"].ToString().Trim();
                detail.PurchasePrice = Convert.ToDecimal(rdr["PurchasePrice"]);
                detail.Quantity = Convert.ToInt32(rdr["Quantity"]);
                list.Add(detail);
            }
            rdr.Close();


            //获取订单基本信息
            cmd.CommandText = "GetPurchaseBillAll";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = id;

            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            while (reader.Read())
            {
                PurchaseBill bill = new PurchaseBill();

                bill.PurchaseID = reader["PurchaseID"].ToString().Trim();
                bill.SupplierID = reader["SupplierID"].ToString().Trim();
                bill.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]);

                bill.StockDate = new DateTime();               //数据库里入库日期为空的时候默认为空值
                if (reader["StockDate"] != Convert.DBNull)     //数据库里入库日期不为空的时候就转换获取数据库的时间值
                {
                    bill.StockDate = Convert.ToDateTime(reader["StockDate"]);
                }

                bill.Clerk = reader["Clerk"].ToString().Trim();
                bill.Examiner = reader["Examiner"].ToString().Trim();
                bill.Custodian = reader["Custodian"].ToString().Trim();
                bill.OnProcess = Convert.ToInt16(reader["OnProcess"]);
                bill.Memo = reader["Memo"].ToString().Trim();
                bill.DetailList = list;
                reader.Close();
                return bill;
            }
            reader.Close();
            return null;
        }

        public bool Update(PurchaseBill o)     //更新订单
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            //事务开始
            SqlTransaction tran = DBAccess.ExecuteSqlTransaction(cmd);
            try
            {
                //更新进货单
                cmd.CommandText = "bill_UpdatePurchaseBillByPurchaseID";   //要执行的存储过程   

                SetParameters(o);    //设置参数（封装为方法）

                cmd.ExecuteNonQuery();

                //删除旧的订单明细
                cmd.CommandText = "DeletePurchaseDetailByPurchaseID";   //要执行的存储过程
                cmd.Parameters.Clear();                                       //清参数

                cmd.Parameters.Add("@PurchaseID", SqlDbType.NVarChar, 12).Value = o.PurchaseID;

                cmd.ExecuteNonQuery();

                //新增新的订单明细
                foreach (PurchaseDetail detail in o.DetailList)
                {
                    cmd.CommandText = "InsertPurchaseDetail";   //要执行的存储过程
                    cmd.Parameters.Clear();                     //清参数

                    cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = detail.PurchaseID;
                    cmd.Parameters.Add("@PurchaseDetailID", SqlDbType.SmallInt).Value = detail.PurchaseDetailID;
                    cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = detail.ProductID;
                    cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal, 18).Value = detail.PurchasePrice;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = detail.Quantity;

                    cmd.ExecuteNonQuery();
                }

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

        public bool Insert(PurchaseBill o)    //插入新的订单
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            //事务开始
            SqlTransaction tran = DBAccess.ExecuteSqlTransaction(cmd);
            try
            {
                //插入新的进货单
                cmd.CommandText = "bill_InsertPurchaseBill";   //要执行的存储过程

                SetParameters(o);   //设置参数（封装为方法）

                cmd.ExecuteNonQuery();

                //新增新的订单明细
                foreach (PurchaseDetail detail in o.DetailList)
                {
                    cmd.CommandText = "InsertPurchaseDetail";   //要执行的存储过程
                    cmd.Parameters.Clear();                     //清参数

                    cmd.Parameters.Add("@PurchaseID", SqlDbType.NChar, 12).Value = detail.PurchaseID;
                    cmd.Parameters.Add("@PurchaseDetailID", SqlDbType.SmallInt).Value = detail.PurchaseDetailID;
                    cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 6).Value = detail.ProductID;
                    cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal, 18).Value = detail.PurchasePrice;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = detail.Quantity;

                    cmd.ExecuteNonQuery();
                }

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

        public string CreatePurchaseID(DateTime dt)      //根据日期生成订单编号
        {
            cmd.CommandText = "bill_CreatePurchaseID";   //要执行的存储过程
            cmd.Parameters.Clear();                      //清参数
            cmd.Parameters.Add("@PurchaseDate", SqlDbType.DateTime).Value = dt;

            object result = DBAccess.GetScalar(cmd);
            return result.ToString();

        }

        public bool UpdatePurchaseBillOnly(PurchaseBill o)            //撤销
        {
            
            cmd.CommandText = "bill_UpdatePurchaseBillByPurchaseID";   //要执行的存储过程

            SetParameters(o);   //设置参数（封装为方法）

            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result==0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(PurchaseBill o)
        {
            throw new NotImplementedException();
        }


        public List<PurchaseBill> GetList()
        {
            throw new NotImplementedException();
        }

        private void SetParameters(PurchaseBill o)    //设置参数（封装为方法）
        {
            //设置参数
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PurchaseID", SqlDbType.NVarChar, 12).Value = o.PurchaseID;
            cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
            cmd.Parameters.Add("@PurchaseDate", SqlDbType.DateTime).Value = o.PurchaseDate;
            if (o.StockDate == new DateTime())
            {
                cmd.Parameters.Add("@StockDate", SqlDbType.DateTime).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@StockDate", SqlDbType.DateTime).Value = o.StockDate;
            }
            cmd.Parameters.Add("@Clerk", SqlDbType.NVarChar, 6).Value = o.Clerk;
            if (o.Examiner == "")
            {
                cmd.Parameters.Add("@Examiner", SqlDbType.NVarChar, 6).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@Examiner", SqlDbType.NVarChar, 6).Value = o.Examiner;
            }
            if (o.Custodian == "")
            {
                cmd.Parameters.Add("@Custodian", SqlDbType.NVarChar, 6).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@Custodian", SqlDbType.NVarChar, 6).Value = o.Custodian;
            }
            cmd.Parameters.Add("@OnProcess", SqlDbType.SmallInt).Value = o.OnProcess;
            if (o.Memo == "")
            {
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar, 100).Value = Convert.DBNull;
            }
            else
            {
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar, 100).Value = o.Memo;
            }
        }
    }
}
