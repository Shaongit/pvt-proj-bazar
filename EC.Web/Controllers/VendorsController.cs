using EC.BLL;
using EC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EC.Web.Controllers
{   
    public class VendorsController : Controller
    {
        IVendorManager objIVendorManager = new VendorManager();

        //private ECommerceContext context = new ECommerceContext();
        

        //
        // GET: /Vendors/

        public ViewResult Index()
        {
            return View(objIVendorManager.GetAllVendors());
        }

        //
        // GET: /Vendors/Details/5

        public ViewResult Details(int id)
        {
            //Vendor vendor = context.Vendors.Single(x => x.Id == id);
            return View(objIVendorManager.GetSingleVendor(id));
        }

        //
        // GET: /Vendors/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Vendors/Create

        [HttpPost]
        public ActionResult Create(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                //context.Vendors.Add(vendor);
                //context.SaveChanges();
                objIVendorManager.AddVendor(vendor);
                return RedirectToAction("Index");  
            }

            return View(vendor);
        }
        
        //
        // GET: /Vendors/Edit/5
 
        public ActionResult Edit(int id)
        {
            //Vendor vendor = context.Vendors.Single(x => x.Id == id);
            Vendor vendor = objIVendorManager.GetSingleVendor(id);
            return View(vendor);
        }

        //
        // POST: /Vendors/Edit/5

        [HttpPost]
        public ActionResult Edit(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                //context.Entry(vendor).State = EntityState.Modified;
                //context.SaveChanges();
                objIVendorManager.EditVendor(vendor);
                return RedirectToAction("Index");
            }
            return View(vendor);
        }

        //
        // GET: /Vendors/Delete/5
 
        public ActionResult Delete(int id)
        {
            //Vendor vendor = context.Vendors.Single(x => x.Id == id);
            return View(objIVendorManager.GetSingleVendor(id));
        }

        //
        // POST: /Vendors/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //Vendor vendor = context.Vendors.Single(x => x.Id == id);
            //context.Vendors.Remove(vendor);
            //context.SaveChanges();

            objIVendorManager.RemoveVendor(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                //context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}