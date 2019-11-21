using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //供应商实体类 

    public class Supplier
    {
        private string supplierID;
        private ContactInfo supplierContact;     

        public string SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public ContactInfo SupplierContact
        {
            get { return supplierContact; }
            set { supplierContact = value; }
        }
       
        //无参构造函数
        public Supplier() 
        {
        }

        //带参构造函数
        public Supplier(string supplierID,ContactInfo contactInfo)
        {
            this.supplierID = supplierID;
            this.supplierContact = contactInfo;
        }

    }
}
