using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EC.Web;
using EC.BLL;
using EC.Web.Controllers;

namespace EC.Web.Tests.Controllers
{
    [TestClass]
    public class VendorManagerTest
    {
        [TestMethod]
        public void GetAllVendorsTest()
        {
            // Arrange
            VendorManager VendorManager = new VendorManager();

            // Act
            var result = VendorManager.GetAllVendors();

            // Assert
            Assert.IsNotNull(result);
        }

        //GetSingleVendor
        //public void GetSingleVendor()
        //{
        //    // Arrange
        //    VendorsController VendorController = new VendorsController();

        //    // Act
        //    ViewResult result = VendorController.Details() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void GetSingleVendorTest()
        {
            // Arrange
            VendorManager VendorManager = new VendorManager();

            // Act
            //ViewResult result = VendorController.Details() as ViewResult;
            var result = VendorManager.GetSingleVendor(1);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
