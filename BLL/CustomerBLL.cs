using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;

namespace MoGuangYuan.BLL
{
    //对客户进行操作 

    public class CustomerBLL
    {
        private CustomerDAL c;

        public CustomerBLL()
        {
            c = new CustomerDAL();
        }

        public List<Customer> GetList()
        {
            return c.GetList();
        }

        public bool Insert(Customer o)
        {
            return c.Insert(o);
        }

        public bool Delete(Customer o)
        {
            return c.Delete(o);
        }

        public bool Update(Customer o)
        {
            return c.Update(o);
        }

        public Customer FindByID(string id)
        {
            return c.FindByID(id);
        }
    }
}
