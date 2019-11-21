using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //员工实体类 

    public class Employee
    {
        private string employeeID;
        private string employeeName;
        private int sex;
        private DateTime birthday;
       
        private string brief;


        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }      

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }      

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Brief
        {
            get { return brief; }
            set { brief = value; }
        }


        public Employee()  //无参构造函数
        {        
        }

        public Employee(string employeeID, string employeeName, int sex, DateTime birthday, string brief) //带参数构造函数
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.sex = sex;
            this.birthday = birthday;
            this.brief = brief;
        }
    }
}
