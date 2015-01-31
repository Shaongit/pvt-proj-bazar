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
    public class UserManagerTest
    {
        UserManager UserManager = new UserManager();
        //[TestMethod]
        //public void GetAllUsersTest() 
        //{ 
        //     // Arrange
           

        //    // Act
        //    var result = UserManager.GetAllUsers();

        //    // Assert
        //    Assert.IsNull(result);
        //}

        [TestMethod]
        public void GetSingleUserTest()
        {
            // Arrange
            

            // Act
            //ViewResult result = VendorController.Details() as ViewResult;
            var result = UserManager.GetSingleUser(1);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetUserTest()
        {
            var result = UserManager.GetUser("juthi");

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
