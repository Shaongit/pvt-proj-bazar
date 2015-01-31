using EC.BLL;
using EC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EC.Web.Controllers
{
    public class BaseController : Controller
    {
        WishItemManager objWishItemManager = new WishItemManager();
        IUserManager objUserManager = new UserManager();

        public BaseController()
        {
            List<WishItem> lstWishItem = new List<WishItem>();

            if (User != null)
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
    }
}