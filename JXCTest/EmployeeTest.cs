using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;
using System.EnterpriseServices;

namespace JXCTest
{
    /// <summary>
    /// EmployeeTest 的摘要说明
    /// </summary>

    [Transaction(TransactionOption.Required)]   //事务回滚部分代码
    [TestClass]
    public class EmployeeTest
    {
        public EmployeeTest()
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
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        [TestCleanup()]
        public void TransactionTestCleanup()   // 测试方法结束后，所有事务撤销 
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }
        #endregion

        [TestMethod]
        public void InsertTest()
        {
            Employee e = new Employee();
            e.EmployeeID = "0";
            e.EmployeeName = "我的名字";
            e.Sex = 1;
            e.Birthday = Convert.ToDateTime("2016-05-20");
            e.Brief = "我的简历！！！";

            EmployeeDAL target = new EmployeeDAL();

            bool atual = target.Insert(e);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

            //测试无效的           
            atual = target.Insert(e);           //实际的结果
            expected = false;                           //预期的结果
            Assert.AreEqual(expected, atual);           //断言判等
        }


        [TestMethod]
        public void UpdataTest()
        {
            Employee e = new Employee();
            e.EmployeeID = "0";
            e.EmployeeName = "这是我的名字";
            e.Sex = 1;
            e.Birthday = Convert.ToDateTime("2015-05-20");
            e.Brief = "这是我的简历！！！";

            EmployeeDAL target = new EmployeeDAL();

            bool atual = target.Update(e);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

        }

        [TestMethod]
        public void SelectEmployeeAllTest()
        {
            EmployeeDAL target = new EmployeeDAL();
            List<Employee> actual = target.GetList();       //实际的结果
            int expected = 4;                               //预期的结果

            Assert.AreEqual(expected, actual.Count);
            Assert.AreEqual("莫", actual[1].EmployeeName);  //断言判等

        }

        [TestMethod]
        public void SelectEmployeeByEmployeeIDTest()
        {
            EmployeeDAL target = new EmployeeDAL();
            string id = "0";

            Employee actual = target.FindByID(id); ;  //实际的结果

            Assert.IsNotNull(actual);
            Assert.AreEqual("这是我的名字", actual.EmployeeName);    //断言判等

        }


        [TestMethod]
        public void DeleteTest()
        {
            Employee e = new Employee();
            e.EmployeeID = "0";
            EmployeeDAL target = new EmployeeDAL();

            bool atual = target.Delete(e);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等


            //测试无效的
            e.EmployeeID = "0";

            atual = target.Delete(e);             //实际的结果
            expected = false;                            //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等
        }

    }
}
