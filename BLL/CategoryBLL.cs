using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;

namespace MoGuangYuan.BLL
{
    //对分类进行操作 

    public class CategoryBLL
    {
        private CategoryDAL cate;
        public CategoryBLL()  //无参构造函数
        {
            cate = new CategoryDAL();
        }

        public List<Category> GetList()        //查询所有的Category类别  使用泛型
        {
            return cate.GetList();
        }

        public bool Insert(Category o)          //插入 新的类别ID 和 类别名称   使用实体类Model的Category类传参数
        {
            return cate.Insert(o);
        }

        public bool Delete(Category o)          //根据categoryID 删除记录  使用实体类Model的Category类传参数
        {
            return cate.Delete(o);
        }

        public bool Update(Category o)          //根据categoryID 更新记录  使用实体类Model的Category类传参数
        {
            return cate.Update(o);
        }

        public Category FindByID(string id)   //根据产品类别ID查询
        {
            return cate.FindByID(id);
        }
    }
}
