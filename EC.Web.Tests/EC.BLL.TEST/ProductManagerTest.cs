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
    public class ProductManagerTest
    {
        ProductManager ProductManager = new ProductManager();
        [TestMethod]
        public void GetAllProductsTest() 
        { 
             // Arrange
           

            // Act
            var result = ProductManager.GetAllProducts();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetSingleProductTest()
        {
            // Arrange
            

            // Act
            //ViewResult result = VendorController.Details() as ViewResult;
            var result = ProductManager.GetSingleProduct(1);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
