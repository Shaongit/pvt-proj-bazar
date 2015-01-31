using EC.BLL;
using EC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EC.Web.Controllers
{
    public class HomeController : BaseController
    {
        ICategoryManager objICategoryManager = new CategoryManager();
        IProductManager objProductManager = new ProductManager();
        UserManager objUserManager = new UserManager();
        WishItemManager objWishItemManager = new WishItemManager();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            ViewBag.Category = objICategoryManager.GetAllCategories();
            ViewBag.RecentProduct = objProductManager.GetRecentTenProducts();
            this.SetBaseData();

            return View();
        }

        public void SetBaseData()
        {
            List<WishItem> lstWishItem = new List<WishItem>();

            if (!String.IsNullOrEmpty(User.Identity.Name))
            {
                try
                {
                    int userId = objUserManager.GetUser(User.Identity.Name).UserId;
                    lstWishItem = objWishItemManager.GetUserWishItems(userId);
                }
                catch
                {
                }
            }

            ViewBag.UserWishList = lstWishItem;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
