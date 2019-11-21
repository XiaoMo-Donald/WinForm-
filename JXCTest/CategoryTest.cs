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
    /// CategoryTest 的摘要说明
    /// </summary>
    ///  
    [Transaction(TransactionOption.Required)]   //事务回滚部分代码

    [TestClass]
    public class CategoryTest
    {
        public CategoryTest()
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
            //有效的
            Category category = new Category("7", "西瓜");
            CategoryDAL target = new CategoryDAL();

            bool atual = target.Insert(category);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

            //测试无效的
            category.CategoryID = "6";
            category.CategoryName = "青苹果";
            atual = target.Insert(category);           //实际的结果
            expected = false;                           //预期的结果
            Assert.AreEqual(expected, atual);           //断言判等
        }



        [TestMethod]
        public void UpdataTest()
        {
            Category category = new Category("6", "蜜桃");
            CategoryDAL target = new CategoryDAL();

            bool atual = target.Update(category);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等

        }

        [TestMethod]
        public void SelectCategoriesAllTest()
        {
            //有效的
            CategoryDAL target = new CategoryDAL();
            List<Category> actual = target.GetList();       //实际的结果
            int expected = 4;                               //预期的结果

            Assert.AreEqual(expected, actual.Count);
            Assert.AreEqual("番石榴", actual[3].CategoryName);  //断言判等


        }

        [TestMethod]
        public void SelectCategoryByCategoryIDTest()
        {
            CategoryDAL target = new CategoryDAL();
            string id = "3";
            Category actual = target.FindByID(id);           //实际的结果

            Assert.IsNotNull(actual);
            Assert.AreEqual("雪梨", actual.CategoryName);    //判等

            //无效的
            id = "5";
            actual = target.FindByID(id);
            Assert.IsNotNull(actual);
            Assert.AreNotEqual("雪梨", actual.CategoryName);    //判不等
        }


        [TestMethod]
        public void DeleteTest()
        {
            Category category = new Category();
            category.CategoryID = "1";

            CategoryDAL target = new CategoryDAL();

            bool atual = target.Delete(category);           //实际的结果
            bool expected = true;                           //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等


            //测试无效的
            category.CategoryID = "8";
            atual = target.Delete(category);             //实际的结果
            expected = false;                            //预期的结果

            Assert.AreEqual(expected, atual);               //断言判等
        }
    }
}
