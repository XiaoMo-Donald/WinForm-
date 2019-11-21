using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.DBUtility
{
    //不能访问数据库异常类。
    public class DBException : ApplicationException
    {
        //异常类 不能访问数据库（数据库连接失败）
        public DBException(Exception innerException)
            : base(" 不能访问数据库 ", innerException)
        {
        }
    }
}
