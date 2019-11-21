using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;

namespace MoGuangYuan.BLL
{
    //对员工进行操作 

    public class EmployeeBLL
    {
        private EmployeeDAL e;
        public EmployeeBLL()  //无参构造函数
        {
            e = new EmployeeDAL();
        }
        public List<Employee> GetList()
        {
            return e.GetList();
        }
        public bool Insert(Employee o)
        {
            return e.Insert(o);
        }
        public bool Delete(Employee o)
        {
            return e.Delete(o);
        }
        public bool Update(Employee o)
        {
            return e.Update(o);
        }
        public Employee FindByID(string id)
        {
            return e.FindByID(id);
        }
    }
}
