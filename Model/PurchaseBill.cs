using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //入库实体类 

    public class PurchaseBill
    {
        private string purchaseID;
        private string supplierID;
        private DateTime purchaseDate;
        private DateTime stockDate;
        private string clerk;
        private string examiner; 
        private string custodian;
        private int onProcess;
        private string memo;
        private List<PurchaseDetail> detailList; //订单明细字段

       


        public string PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }
        public string SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }
        public DateTime StockDate
        {
            get { return stockDate; }
            set { stockDate = value; }
        }
        public string Clerk
        {
            get { return clerk; }
            set { clerk = value; }
        }
        public string Examiner
        {
            get { return examiner; }
            set { examiner = value; }
        }
        public string Custodian
        {
            get { return custodian; }
            set { custodian = value; }
        }
        public int OnProcess
        {
            get { return onProcess; }
            set { onProcess = value; }
        }

        public string Memo
        {
            get { return memo; }
            set { memo = value; }
        }
        public List<PurchaseDetail> DetailList
        {
            get { return detailList; }
            set { detailList = value; }
        }

        //无参构造函数
        public PurchaseBill() 
        {
        }

        //带参构造函数
        public PurchaseBill(string purchaseID, string supplierID, DateTime purchaseDate, DateTime stockDate, string clerk, string examiner, string custodian, int onProcess, string memo)
        {
            this.purchaseID = purchaseID;
            this.supplierID = supplierID;
            this.purchaseDate = purchaseDate;
            this.stockDate =stockDate;
            this.clerk = clerk;
            this.examiner = examiner;
            this.custodian = custodian;
            this.onProcess = onProcess;
            this.memo = memo;

        }
    }
}
