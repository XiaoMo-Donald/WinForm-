using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //产品实体类 

    public class Product
    {
        private string productID;
        private string productName;
        private string spellingCode;
        private string barcode;
        private string special;
        private string unit;
        private string origin;
        private string categoryID;
        private double purchasePrice;
        private double salePrice;
        private int quantity;


        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string SpellingCode
        {
            get { return spellingCode; }
            set { spellingCode = value; }
        }   
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }       
        public string Special
        {
            get { return special; }
            set { special = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        public double PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        public double SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        //无参构造函数
        public Product() 
        {
        }

        //带参构造函数
        public Product(string productID, string productName, string spellingCode, string barcode, string special, string unit, string origin, string categoryID, double purchasePrice, double salePrice, int quantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.spellingCode = spellingCode;
            this.barcode = barcode;
            this.special = special;
            this.unit = unit;
            this.origin = origin;
            this.categoryID = categoryID;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.quantity = quantity;

        }
    }
}
