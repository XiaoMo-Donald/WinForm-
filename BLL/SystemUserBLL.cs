using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;

namespace MoGuangYuan.BLL
{
    //对系统用户进行操作 
    public class SystemUserBLL
    {
        private SystemUserDAL u;
        public SystemUserBLL()
        {
            u = new SystemUserDAL();
        }
        public List<SystemUser> GetList()      //获取所有的用户权限（员工）
        {
            return u.GetList();
        }
        public List<string> GetAllUserID()     //获取所有的用户ID
        {
            return u.GetAllUserID();
        }      
        public bool Delete(SystemUser o)       //删除用户（该界面可能用不到）
        {
            return u.Delete(o);
        }
        public bool Update(SystemUser o)       //更新用户权限
        {
            return u.Update(o);
        }
        public SystemUser FindByID(string id) //根据用户ID查询用户的所有信息
        {
            return u.FindByID(id);
        }
        public bool ChangeUserPassword(string userID, string password)    //修改密码
        {
            return u.ChangeUserPassword(userID,password);
        }
        public bool UserLogin(string userid, string password)    //用户登录
        {
            return u.UserLogin(userid,password);
        }
    }
}
