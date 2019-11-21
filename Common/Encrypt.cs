using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MoGuangYuan.Common
{
   public class Encrypt:IEncrypt
    {
        public byte[] encryPassword(string pwd)
        {
            //取得密码的字节数据
            ASCIIEncoding en = new ASCIIEncoding();
            byte[] passowrd = en.GetBytes(pwd);

            //调用.NET 自带的加密类，调用 SHA1（哈希）方法
            SHA1Managed sha = new SHA1Managed();
            return sha.ComputeHash(passowrd);
        }
    }
}
