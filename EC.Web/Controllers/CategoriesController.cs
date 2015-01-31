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
    [Authorize]
    public class CategoriesController : Controller
    {

        ICategoryManager objCategoryManager = new CategoryManager();
        private ECommerceContext context = new ECommerceContext();
        UserManager objUserManager = new UserManager();
        WishItemManager objWishItemManager = new WishItemManager();

        //
        // GET: /Categories/

        public ViewResult Index()
        {
            return View(objCategoryManager.GetAllCategories().ToList());
            //return View(context.Categories.Include(category => category.SubCategories).ToList());
        }

        //
        // GET: /Categories/Details/5

        public ViewResult Details(int id)
        {
            Category category = context.Categories.Single(x => x.Id == id);
            return View(category);
        }

        //
        // GET: /Categories/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Categories/Create

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(category);
        }
        
        //
        // GET: /Categories/Edit/5
 
        public ActionResult Edit(int id)
        {
            Category category = context.Categories.Single(x => x.Id == id);
            return View(category);
        }

        //
        // POST: /Categories/Edit/5

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Entry(category).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //
        // GET: /Categories/Delete/5
 
        public ActionResult Delete(int id)
        {
            Category category = context.Categories.Single(x => x.Id == id);
            return View(category);
        }

        //
        // POST: /Categories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = context.Categories.Single(x => x.Id == id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
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

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}