using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.DAL
{
    //接口 规范(所有继承该接口的类必须实现 该 接口下的方法)
    public interface IDAL<T>
    {
        List<T> GetList();
        bool Insert(T o);
        bool Delete(T o);
        bool Update(T o);
        T FindByID(string id);
    }
}
