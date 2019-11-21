using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Model
{
    //分类实体类 

    public class Category
    {
        private string categoryID;     //类别ID   字段
        private string categoryName;   //类别名称 字段

        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }    

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public Category()  //无参构造函数
        {         
        }      
        public Category(string categoryID,string categoryName)  //带参构造函数
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        
        }
    }
}
