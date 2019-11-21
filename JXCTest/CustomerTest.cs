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
    /// CustomerTest 的摘要说明
    /// </summary>
    [Transaction(TransactionOption.Required)]   //事务回滚部分代码
    [TestClass]
    public class CustomerTest
    {
        public CustomerTest()
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
            Customer c = new Customer();
            c.CustomerID = "222";
            ContactInfo ci = new ContactInfo();
            ci.Name = "2222";
            ci.SpellingCode = "2222222222";
            ci.ZipCode = "23124";
            ci.Tel = "123123132132";
            ci.Fax = "12646546";
            ci.Address = "541654564654";
            ci.BankName = "瑞士银行";
            ci.BankAccount = "88888888888888";
            ci.Contacter = "莫";
            ci.Email = "132123132@qq.com";
            c.CustomerContact = ci;

            CustomerDAL target = new CustomerDAL();

            bool atual = target.Insert(c);                  //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

            //测试无效的           
            atual = target.Insert(c);                   //实际的结果
            expected = false;                           //预期的结果
            Assert.AreEqual(expected, atual);           //断言判等
        }


       
        [TestMethod]
        public void UpdataTest()
        {
            Customer c = new Customer();
            c.CustomerID = "222";
            c.CustomerContact.Name = "2222";
            c.CustomerContact.SpellingCode = "22tw2";
            c.CustomerContact.ZipCode = "2twet24";
            c.CustomerContact.Tel = "123twet132";
            c.CustomerContact.Fax = "12twet";
            c.CustomerContact.Address = "wdtwetw4564654";
            c.CustomerContact.BankName = "瑞士银行";
            c.CustomerContact.BankAccount = "88888888888888";
            c.CustomerContact.Contacter = "235235莫";
            c.CustomerContact.Email = "132123132@qq.com";

            CustomerDAL target = new CustomerDAL();

            bool atual = target.Update(c);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

        }

        [TestMethod]
        public void SelectCustomerAllTest()
        {
            CustomerDAL target = new CustomerDAL();
            List<Customer> actual = target.GetList();       //实际的结果
            int expected = 2;                               //预期的结果

            Assert.AreEqual(expected, actual.Count);
            Assert.AreEqual("235235", actual[1].CustomerContact.Name);  //断言判等

        }

        [TestMethod]
        public void SelectCustomerByCustomerIDTest()
        {
            CustomerDAL target = new CustomerDAL();
            string id = "12";

            Customer actual = target.FindByID(id); ;  //实际的结果

            Assert.IsNotNull(actual);
            Assert.AreEqual("瑞士银行", actual.CustomerContact.BankName);    //断言判等

        }

        [TestMethod]
        public void DeleteTest()
        {
            Customer c = new Customer();
            c.CustomerID = "222";

            CustomerDAL target = new CustomerDAL();

            bool atual = target.Delete(c);                  //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等


            //测试无效的
            c.CustomerID = "222";

            atual = target.Delete(c);                     //实际的结果
            expected = false;                            //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等
        }

    }
}
