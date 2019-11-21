using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //入库明细实体类
    public class PurchaseDetail
    {
        private string purchaseID;
        private int purchaseDetailID;
        private string productID;
        private decimal purchasePrice;
        private int quantity;

        public string PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }
        public int PurchaseDetailID
        {
            get { return purchaseDetailID; }
            set { purchaseDetailID = value; }
        }
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //计算总价 数量 乘 单价
        public decimal TotalPrice
        {
            get { return quantity * purchasePrice; }
        }

        //无参构造函数
        public PurchaseDetail() 
        {        
        }

        //有参构造函数
        public PurchaseDetail(string purchaseID, int purchaseDetailID, string productID, decimal purchasePrice, int quantity)
        {
            this.purchaseID = purchaseID;
            this.purchaseDetailID = purchaseDetailID;
            this.productID = productID;
            this.purchasePrice = purchasePrice;
            this.quantity = quantity;
        }
    }
}
