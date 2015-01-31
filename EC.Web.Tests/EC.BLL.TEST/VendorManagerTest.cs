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

        //delete vendor
        //[TestMethod]
        //public void RemoveVendorTest()
        //{
        //    // Arrange
        //    VendorManager VendorManager = new VendorManager();

            
        //    // Act
        //     VendorManager.RemoveVendor(1);

        //    // Assert
        //     Assert.IsFalse();
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
