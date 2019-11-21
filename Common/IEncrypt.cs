using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoGuangYuan.Common
{
   public interface IEncrypt
    {
       byte[] encryPassword(string pwd);
    }
}
