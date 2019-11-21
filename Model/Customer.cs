using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //客户实体类

    public class Customer
    {
        private string customerID;

       private ContactInfo customerContact;     

       
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public ContactInfo CustomerContact
        {
            get { return customerContact; }
            set { customerContact = value; }
        }
      

        //无参构造函数
        public Customer()  
        {
        }

        //带参构造函数
        public Customer(string customerID,ContactInfo contactInfo) 
        {
            this.customerID = customerID;
            this.customerContact = contactInfo;
          
        }
    }
}
