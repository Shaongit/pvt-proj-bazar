using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EC.Web;
using EC.Web.Controllers;

namespace EC.Web.Tests.Controllers
{
    [TestClass]
    public class VendorControllerTest
    {
        //GetSingleVendor
        [TestMethod]
        public void GetSingleVendorTest()
        {
            // Arrange
            VendorsController VendorController = new VendorsController();

            // Act
            ViewResult result = VendorController.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
