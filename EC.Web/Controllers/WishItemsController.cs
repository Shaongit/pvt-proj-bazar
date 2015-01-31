using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC.Model;
using EC.Web.Models;
using EC.Context;
using EC.BLL;

namespace EC.Web.Controllers
{
    public class WishItemsController : BaseController
    {
        private IUserManager objIUserManager = new UserManager();
        private ECommerceContext context = new ECommerceContext();

        //
        // GET: /WishItems/

        public ViewResult Index()
        {
            int userId = objIUserManager.GetUser(User.Identity.Name).UserId;
            return View(context.WishItems.Include(wishitem => wishitem.Product).Where(p => p.UserId == userId).ToList());
        }

        //
        // GET: /WishItems/Details/5

        public ViewResult Details(long id)
        {
            WishItem wishitem = context.WishItems.Single(x => x.Id == id);
            return View(wishitem);
        }

        //
        // GET: /WishItems/Create

        public ActionResult Create()
        {
            //ViewBag.PossibleProducts = context.Products;
            //ViewBag.PossibleUsers = context.Users;
            return View();
        }


        public ActionResult AddWishList(int productId)
        {
            if (User != null)
            {
                WishItem objWishItem = new WishItem();
                objWishItem.ProductId = productId;
                objWishItem.UserId = objIUserManager.GetUser(User.Identity.Name).UserId;
                context.WishItems.Add(objWishItem);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        //
        // POST: /WishItems/Create

        [HttpPost]
        public ActionResult Create(WishItem wishitem)
        {
            if (ModelState.IsValid)
            {
                context.WishItems.Add(wishitem);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.PossibleProducts = context.Products;
            //ViewBag.PossibleUsers = context.Users;
            return View(wishitem);
        }

        //
        // GET: /WishItems/Edit/5

        public ActionResult Edit(long id)
        {
            WishItem wishitem = context.WishItems.Single(x => x.Id == id);
            //ViewBag.PossibleProducts = context.Products;
            //ViewBag.PossibleUsers = context.Users;
            return View(wishitem);
        }

        //
        // POST: /WishItems/Edit/5

        [HttpPost]
        public ActionResult Edit(WishItem wishitem)
        {
            if (ModelState.IsValid)
            {
                context.Entry(wishitem).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.PossibleProducts = context.Products;
            //ViewBag.PossibleUsers = context.Users;
            return View(wishitem);
        }

        //
        // GET: /WishItems/Delete/5

        public ActionResult Delete(long id)
        {
            WishItem wishitem = context.WishItems.Single(x => x.Id == id);
            return View(wishitem);
        }

        //
        // POST: /WishItems/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            WishItem wishitem = context.WishItems.Single(x => x.Id == id);
            context.WishItems.Remove(wishitem);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}