using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoGuangYuan.Model;
using MoGuangYuan.DAL;

namespace MoGuangYuan.BLL
{
    //对入库进行操作 

    public class PurchaseBillBLL
    {
        private PurchaseBillDAL pd;
        public PurchaseBillBLL() 
        {
            pd = new PurchaseBillDAL();
        }
        public List<string> FindPurchaseIDByID(string id)                  //根据订单查询订单号 
        {
            return pd.FindPurchaseIDByID(id);
        }

        public List<string> FindPurchaseIDByClerk(string clerk)            //按业务员查询
        {
            return pd.FindPurchaseIDByClerk(clerk);
        }

        public List<string> FindPurchaseIDByExaminer(string examiner)      //按审核员查询
        {
            return pd.FindPurchaseIDByExaminer(examiner);
        }

        public List<string> FindPurchaseIDByOnProcess(int onProcess)       //按完成状态查询
        {
            return pd.FindPurchaseIDByOnProcess(onProcess);
        }
        public List<string> FindPurchaseIDByPurchaseDate(DateTime beginPurchaseDate, DateTime endPurchaseDate)        //按订单日期查询
        {
            return pd.FindPurchaseIDByPurchaseDate(beginPurchaseDate, endPurchaseDate);
        }

        public PurchaseBill FindByID(string id)        //根据ID查询订单基本信息和订单明细
        {
            return pd.FindByID(id);
        }
        public bool Update(PurchaseBill o)    //修改订单
        {
            return pd.Update(o);
        }

        public bool Insert(PurchaseBill o)   //新增订单
        {
            return pd.Insert(o);
        }

        public string CreatePurchaseID(DateTime dt)      //根据日期生成订单编号
        {
            return pd.CreatePurchaseID(dt);
        }
        public bool UpdatePurchaseBillOnly(PurchaseBill o)    //撤销
        {
            return pd.UpdatePurchaseBillOnly(o);
        }
    }
}
