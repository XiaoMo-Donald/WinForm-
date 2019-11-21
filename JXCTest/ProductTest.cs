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
    /// ProductTest 的摘要说明
    /// </summary>
    /// 
    [Transaction(TransactionOption.Required)]   //事务回滚部分代码
    [TestClass]
    public class ProductTest
    {
        public ProductTest()
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
            Product p = new Product();
            p.ProductID = "4";
            p.ProductName = "苹果";
            p.SpellingCode = "4234";
            p.Barcode = "4234";
            p.Unit = "斤";
            p.Origin = "4214";
            p.Special = "45646";
            p.CategoryID = "1";
            p.PurchasePrice = 20.00;
            p.SalePrice = 45.00;         
            p.Quantity =1;


            ProductDAL target = new ProductDAL();

            bool atual = target.Insert(p);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

            //测试无效的
            p.ProductID = "4";
            p.ProductName = "苹果";
            p.SpellingCode = "4234";
            p.Barcode = "4234";
            p.Unit = "斤";
            p.Origin = "4214";
            p.Special = "45646";
            p.CategoryID = "1";
            p.PurchasePrice = 20.00;
            p.SalePrice = 45.00;
            p.Quantity = 1;
            atual = target.Insert(p);                  //实际的结果
            expected = false;                           //预期的结果
            Assert.AreEqual(expected, atual);               //断言判等
        }       



         [TestMethod]
         public void UpdataTest()
         {

             Product p = new Product();
             p.ProductID = "4";
             p.ProductName = "苹";
             p.SpellingCode = "4234";
             p.Barcode = "4234";
             p.Unit = "斤";
             p.Origin = "4214";
             p.Special = "45646";
             p.CategoryID = "1";
             p.PurchasePrice = 20.00;
             p.SalePrice = 49.00;
             p.Quantity = 1;


             ProductDAL target = new ProductDAL();


             bool atual = target.Update(p);           //实际的结果
             bool expected = true;                           //预期的结果

             Assert.AreEqual(expected, atual);               //断言判等

         }

         [TestMethod]
         public void SelectProductAllTest()
         {
             ProductDAL target = new ProductDAL();
             List<Product> actual = target.GetList();       //实际的结果
             int expected = 2;                               //预期的结果

             Assert.AreEqual(expected, actual.Count);
             Assert.AreEqual("苹果", actual[1].ProductName);  //断言判等

         }

         [TestMethod]
         public void SelectProductByProductIDTest()
         {
             ProductDAL target = new ProductDAL();
             string id = "123";

             Product actual = target.FindByID(id); ;  //实际的结果

             Assert.IsNotNull(actual);
             Assert.AreEqual("苹果1", actual.ProductName);    //断言判等

         }


         [TestMethod]
         public void DeleteTest()
         {
             Product p = new Product();
             p.ProductID = "4";

             ProductDAL target = new ProductDAL();

             bool atual = target.Delete(p);           //实际的结果
             bool expected = true;                           //预期的结果

             Assert.AreEqual(expected, atual);               //断言判等


             //测试无效的
             p.ProductID = "4";

             atual = target.Delete(p);             //实际的结果
             expected = false;                            //预期的结果

             Assert.AreEqual(expected, atual);               //断言判等
         }
    }
}
