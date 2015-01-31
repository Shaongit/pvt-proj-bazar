using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EC.Web;
using EC.BLL;
using EC.Web.Controllers;

namespace EC.Web.Tests.EC.BLL.TEST
{
    [TestClass]
    public class CategoryManagerTest
    {
        [TestMethod]
        public void GetAllCategoriesTest()
        {
            // Arrange
            CategoryManager CategoryManager = new CategoryManager();

            // Act
            var result = CategoryManager.GetAllCategories();

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GetSingleCategoryTest()
        {
            // Arrange
            CategoryManager CategoryManager = new CategoryManager();

            // Act
            //ViewResult result = VendorController.Details() as ViewResult;
            var result = CategoryManager.GetSingleCategory(1);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
