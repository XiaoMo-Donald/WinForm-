using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;

namespace MoGuangYuan.BLL
{
    //对供应商进行操作 

    public class SupplierBLL
    {
        private SupplierDAL sl;
        public SupplierBLL()
        {
            sl = new SupplierDAL();
        }
        public List<Supplier> GetList()
        {
            return sl.GetList();
        }
        public bool Insert(Supplier o)
        {
            return sl.Insert(o);
        }
        public bool Delete(Supplier o)
        {
            return sl.Delete(o);
        }
        public bool Update(Supplier o)
        {
            return sl.Update(o);
        }

        public Supplier FindByID(string id)
        {
            return sl.FindByID(id);
        }
    }
}
