using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{    
   public class ContactInfo
    {
        private string name;
        private string spellingCode;
        private string address;
        private string zipCode;
        private string tel;
        private string fax;
        private string bankName;
        private string bankAccount;
        private string contacter;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SpellingCode
        {
            get { return spellingCode; }
            set { spellingCode = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        public string BankAccount
        {
            get { return bankAccount; }
            set { bankAccount = value; }
        }
        public string Contacter
        {
            get { return contacter; }
            set { contacter = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
