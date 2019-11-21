using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MoGuangYuan.DBUtility;
using MoGuangYuan.Model;


namespace MoGuangYuan.DAL
{
    //对分类进行操作
    public class CategoryDAL:IDAL<Category>
    {
        private SqlCommand cmd;         //创建SqlCommand对象 为了调用方法
        public CategoryDAL()            //无参构造函数
        {
            cmd = new SqlCommand();     //实例化
            cmd.CommandType = CommandType.StoredProcedure; //cmd 执行的命令为 存储过程
        }

        #region 旧的方法 
        //public bool InsertCategory(Category category)     //插入 新的类别ID 和 类别名称   使用实体类Model的Category类传参数
        //{
        //    if (category == null)
        //    {
        //        throw new ArgumentNullException("category");
        //    }

        //    cmd.CommandText = "InsertCategory";   //要执行的存储过程
        //    cmd.Parameters.Clear();               //清参数
        //    cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = category.CategoryID;          //参数1
        //    cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 80).Value = category.CategoryName;     //参数2

        //    try
        //    {
        //        int result = DBAccess.ExecuteSQL(cmd);
        //        if (result == 0)
        //        {
        //            return false;    //插入失败 返回false
        //        }
        //        else
        //        {
        //            return true;     //插入成功 返回true
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;        //异常   返回false
        //    }

        //}

        //public bool DeleteCategoryByCategoryID(Category cate)     //根据categoryID 删除记录  使用实体类Model的Category类传参数
        //{
        //    if (cate == null)
        //    {
        //        throw new ArgumentNullException("cate");
        //    }
        //    cmd.CommandText = "DeleteCategoryByCategoryID";   //要执行的存储过程
        //    cmd.Parameters.Clear();                           //清参数
        //    cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = cate.CategoryID;            //参数1

        //    try
        //    {
        //        int result = DBAccess.ExecuteSQL(cmd);
        //        if (result == 0)
        //        {
        //            return false;    //删除失败 返回false
        //        }
        //        else
        //        {
        //            return true;     //删除成功 返回true
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;        //异常   返回false
        //    }

        //}

        //public bool UpdataCategoryNameByCategoryIDFromCategory(Category cate)    //根据categoryID 更新记录  使用实体类Model的Category类传参数
        //{
        //    if (cate == null)
        //    {
        //        throw new ArgumentNullException("cate");
        //    }

        //    cmd.CommandText = "UpdataCategoryNameByCategoryIDFromCategory";   //要执行的存储过程
        //    cmd.Parameters.Clear();               //清参数
        //    cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = cate.CategoryID;          //参数1
        //    cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 80).Value = cate.CategoryName;     //参数2

        //    try
        //    {
        //        int result = DBAccess.ExecuteSQL(cmd);
        //        if (result == 0)
        //        {
        //            return false;    //更新失败 返回false
        //        }
        //        else
        //        {
        //            return true;     //更新成功 返回true
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;        //异常   返回false
        //    }
        //}


        //public List<Category> GetAllCategoryIDAndCategoryNameFromCategory()    //查询所有的Category类别  使用泛型
        //{
        //    cmd.CommandText = "GetAllCategoryIDAndCategoryNameFromCategory";
        //    cmd.Parameters.Clear();

        //    SqlDataReader rdr = DBAccess.ExcuteReader(cmd);       
        //    List<Category> list = new List<Category>();                        //使用泛型
        //    while (rdr.Read())
        //    {
        //        Category cate = new Category();
        //        cate.CategoryID = rdr["CategoryID"].ToString().Trim();         
        //        cate.CategoryName = rdr["CategoryName"].ToString().Trim();
        //    }
        //    rdr.Close();   //关闭连接
        //    return list;   //返回值
        //}


        //public string GetAllCategoryIDAndCategoryNameFromCategory(string categoryID)    //根据CategoryID查询类别
        //{
        //    if (categoryID == null)
        //    {
        //        throw new ArgumentNullException("categoryID");
        //    }
        //    else
        //    {
        //        cmd.CommandText = "GetAllCategoryIDAndCategoryNameByCategoryIDFromCategory";
        //        cmd.Parameters.Clear();

        //        cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = categoryID;    //参数1

        //        SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
        //        string result = "";

        //        while (rdr.Read())
        //        {
        //            result = rdr[0].ToString() + rdr[1].ToString();
        //        }
        //        return result;
        //    }
        //}

        #endregion
        

        public List<Category> GetList()        //查询所有的Category类别  使用泛型
        {
            cmd.CommandText = "cate_GetAllCategory";
            cmd.Parameters.Clear();

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);

            //使用泛型集合
            List<Category> list = new List<Category>();                       
            while (rdr.Read())
            {
                Category cate = new Category();
                cate.CategoryID = rdr["CategoryID"].ToString().Trim();
                cate.CategoryName = rdr["CategoryName"].ToString().Trim();                
                list.Add(cate);   
            }
            rdr.Close();   //关闭连接
            return list;   //返回值
        }

        public bool Insert(Category o)          //插入 新的类别ID 和 类别名称   使用实体类Model的Category类传参数
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "cate_InsertCategory";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;          //参数1
            cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 80).Value = o.CategoryName;     //参数2

            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result == 0)
                {
                    return false;    //插入失败 返回false
                }
                else
                {
                    return true;     //插入成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }

        public bool Delete(Category o)          //根据categoryID 删除记录  使用实体类Model的Category类传参数
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            cmd.CommandText = "cate_DeleteCategoryByCategoryID";   //要执行的存储过程
            cmd.Parameters.Clear();                           //清参数
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;            //参数1

            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result == 0)
                {
                    return false;    //删除失败 返回false
                }
                else
                {
                    return true;     //删除成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }

        public bool Update(Category o)          //根据categoryID 更新记录  使用实体类Model的Category类传参数
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }

            cmd.CommandText = "cate_UpdataCategoryByCategoryID";   //要执行的存储过程
            cmd.Parameters.Clear();               //清参数
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;          //参数1
            cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 80).Value = o.CategoryName;     //参数2

            try
            {
                int result = DBAccess.ExecuteSQL(cmd);
                if (result == 0)
                {
                    return false;    //更新失败 返回false
                }
                else
                {
                    return true;     //更新成功 返回true
                }
            }
            catch (Exception)
            {
                return false;        //异常   返回false
            }
        }

        public Category FindByID(string id)   //根据产品类别ID查询
        {
            if (id==null)
            {
                throw new ArgumentNullException("id");
            }
            cmd.CommandText = "cate_GetAllCategoryByCategoryID";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = id;    //参数1

            SqlDataReader rdr = DBAccess.ExcuteReader(cmd);
           
            while (rdr.Read())
            {
                Category c = new Category();
                c.CategoryID = rdr["CategoryID"].ToString().Trim();
                c.CategoryName = rdr["CategoryName"].ToString().Trim();
                rdr.Close();   //关闭连接
                return c;   //返回值
            }
            rdr.Close();   //关闭连接
            return null;   //返回值
        }
    }
}
