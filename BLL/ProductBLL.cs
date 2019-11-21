using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;

namespace MoGuangYuan.BLL
{
    //对产品进行操作 

    public class ProductBLL
    {
        private ProductDAL prod;
        public ProductBLL() 
        {
            prod = new ProductDAL();
        }
        public List<Product> GetList()
        {
         return  prod.GetList();
        }
        public bool Insert(Product o)
        {
        return prod.Insert(o);
        }
        public bool Delete(Product o)
        {
            return prod.Delete(o);
        }
        public bool Update(Product o)
        {
            return prod.Update(o);
        }
        public Product FindByID(string id)
        {
            return prod.FindByID(id);
        }
        public List<Product> SelectProductBySpellingCode(string spellingCode)
        {
            return prod.SelectProductBySpellingCode(spellingCode);
        }
        
    }
}
