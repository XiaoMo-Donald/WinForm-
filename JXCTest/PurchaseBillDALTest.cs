using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoGuangYuan.DAL;
using MoGuangYuan.Model;

namespace JXCTest
{
    /// <summary>
    /// PurchaseBillDALTest 的摘要说明
    /// </summary>
    [TestClass]
    public class PurchaseBillDALTest
    {
        public PurchaseBillDALTest()
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
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        [TestMethod]
        public void InsertTest()
        {
            //有效的
            PurchaseBill p = new PurchaseBill();
            p.PurchaseID = "20160130001";
            p.SupplierID = "0";
            p.PurchaseDate = Convert.ToDateTime("2015-05-06");
            p.StockDate =new DateTime();
            p.Clerk="1";
            p.Examiner = "2";
            p.Custodian = "3";
            p.OnProcess = 0;
            p.Memo = "哈哈哈";
            List<PurchaseDetail> pdd = new List<PurchaseDetail>();
            PurchaseDetail pd = new PurchaseDetail();
        
            pd.PurchaseID = "20160130001";
            pd.PurchaseDetailID = 1;
            pd.ProductID = "0002";
            pd.PurchasePrice = 2;
            pd.Quantity = 100;
            pdd.Add(pd);

            p.DetailList = pdd;

            PurchaseBillDAL target = new PurchaseBillDAL();
            bool atual = target.Insert(p);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

        
        }

     
    }
}
