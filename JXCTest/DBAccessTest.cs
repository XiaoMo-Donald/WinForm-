using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using MoGuangYuan.DBUtility;
using System.Configuration;

namespace JXCTest
{
    /// <summary>
    /// DBAccessTest 的摘要说明
    /// </summary>
    [TestClass]
    public class DBAccessTest
    {
        public DBAccessTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码

        [TestInitialize()]
        public void Start()
        {
            string str = ConfigurationManager.ConnectionStrings["SQLConnString"].ConnectionString; //取配置文件A连接的值
            Assert.AreEqual("Server=.;Database=EntersSellsSaves;UID=sa;PWD=123456", str);//使用断言  对比两个参数的值是否一样
            SqlConnection cn = new SqlConnection(); //创建数据库连接
            cn.ConnectionString = str;
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                Assert.Fail("数据库连接失败！");
            }
        }

        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        [TestMethod]
        public void ExecuteSQLTest()   //测试数据访问层DBUtility返回影响行数ExecuteSQL方法
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert TBL_Category values('5','番石榴')";

            int expected = 1;
            int atual;
            atual = DBAccess.ExecuteSQL(cmd);
            Assert.IsNotNull(atual);
            Assert.AreEqual(expected, atual);
        }


        [TestMethod]
        public void GetScalarTest()    //测试数据访问层DBUtility返回唯一值GetScalar方法
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryName from TBL_Category where CategoryID='2'";

            object expected = "哈密瓜";
            object atual;
            atual = DBAccess.GetScalar(cmd);
            Assert.IsNotNull(atual);
            Assert.AreEqual(expected, atual);
        }


        [TestMethod]
        public void QueryDataTest()    //测试数据访问层DBUtility返回数据集QueryData方法  非连接状态下
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from TBL_Category";

            int expected = 4;

            DataSet atual;
            atual = DBAccess.QueryData(cmd);

            Assert.IsNotNull(atual);
            Assert.AreEqual(expected, atual.Tables[0].Rows.Count);
        }

        [TestMethod]
        public void ExcuteReaderTest()    //测试数据访问层DBUtility返回数据集ExcuteReader方法 连接状态下
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryName from TBL_Category where CategoryID='4'";

            string expected = "南瓜";

            SqlDataReader rdr;
            rdr = DBAccess.ExcuteReader(cmd);
         
            while (rdr.Read())
            {
                Assert.AreEqual(expected, rdr["CategoryName"].ToString().Trim());
            }

            Assert.IsNotNull(rdr);
        
        }
    }
}
