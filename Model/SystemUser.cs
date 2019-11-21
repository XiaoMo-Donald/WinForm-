using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //系统用户实体类 

    public class SystemUser
    {

        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private byte[] password;

        public byte[] Password
        {
            get { return password; }
            set { password = value; }
        }
        private int baseFunction;

        public int BaseFunction
        {
            get { return baseFunction; }
            set { baseFunction = value; }
        }
        private int purchaseFunction;

        public int PurchaseFunction
        {
            get { return purchaseFunction; }
            set { purchaseFunction = value; }
        }
        private int saleFunction;

        public int SaleFunction
        {
            get { return saleFunction; }
            set { saleFunction = value; }
        }
        private int userFunction;

        public int UserFunction
        {
            get { return userFunction; }
            set { userFunction = value; }
        }
        public SystemUser()
        {
        }
        public SystemUser(string userID, byte[] password, int baseFunction, int purchaseFunction, int saleFunction, int userFunction)
        {
            this.userID = userID;
            this.password = password;
            this.baseFunction = baseFunction;
            this.purchaseFunction = purchaseFunction;
            this.saleFunction = saleFunction;
            this.userFunction = userFunction;
        }
    }
}
