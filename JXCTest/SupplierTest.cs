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
    /// SupplierTest 的摘要说明
    /// </summary>
    [Transaction(TransactionOption.Required)]   //事务回滚部分代码
    [TestClass]
    public class SupplierTest
    {
        public SupplierTest()
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
            Supplier s = new Supplier();
            s.SupplierID = "123";

            s.SupplierContact.Name = "供应商名字";
            s.SupplierContact.SpellingCode = "GYSMZ";
            s.SupplierContact.Address = "广西柳州";
            s.SupplierContact.ZipCode = "1546546";
            s.SupplierContact.Tel = "88888888";
            s.SupplierContact.Fax = "88888888";
            s.SupplierContact.BankName = "瑞士银行";
            s.SupplierContact.BankAccount = "8888888888888888888888888";
            s.SupplierContact.Contacter = "默默";
            s.SupplierContact.Email = "1232146@qq.com";

            SupplierDAL target = new SupplierDAL();

            bool atual = target.Insert(s);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

            //测试无效的           
            atual = target.Insert(s);           //实际的结果
            expected = false;                           //预期的结果
            Assert.AreEqual(expected, atual);           //断言判等
        }

       
        [TestMethod]
        public void UpdataTest()
        {
            Supplier s = new Supplier();
            s.SupplierID = "123";
            s.SupplierContact.Name = "这是供应商名字";
            s.SupplierContact.SpellingCode = "GYSMZ";
            s.SupplierContact.Address = "广西柳州";
            s.SupplierContact.ZipCode = "1546546";
            s.SupplierContact.Tel = "88888888";
            s.SupplierContact.Fax = "88888888";
            s.SupplierContact.BankName = "我的瑞士银行";
            s.SupplierContact.BankAccount = "8888888888888888888888888";
            s.SupplierContact.Contacter = "默";
            s.SupplierContact.Email = "1232146@qq.com";

            SupplierDAL target = new SupplierDAL();

            bool atual = target.Update(s);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

        }

        [TestMethod]
        public void SelectSupplierAllTest()
        {
            SupplierDAL target = new SupplierDAL();
            List<Supplier> actual = target.GetList();       //实际的结果
            int expected = 3;                               //预期的结果

            Assert.AreEqual(expected, actual.Count);
            Assert.AreEqual("这是供应商名字", actual[1].SupplierContact.Name);  //断言判等

        }

        [TestMethod]
        public void SelectSupplierBySupplierIDTest()
        {
            SupplierDAL target = new SupplierDAL();
            string id = "123";

            Supplier actual = target.FindByID(id); ;  //实际的结果

            Assert.IsNotNull(actual);
            Assert.AreEqual("我的瑞士银行", actual.SupplierContact.BankName);    //断言判等

        }

         [TestMethod]
        public void DeleteTest()
        {
            Supplier s = new Supplier();
            s.SupplierID = "123";
            SupplierDAL target = new SupplierDAL();

            bool atual = target.Delete(s);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等


            //测试无效的
            s.SupplierID = "123";

            atual = target.Delete(s);             //实际的结果
            expected = false;                            //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等
        }

    }
}
