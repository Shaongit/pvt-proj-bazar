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

namespace EC.Web.Controllers
{
    [Authorize]
    public class CitiesController : Controller
    {
        private ECommerceContext context = new ECommerceContext();

        //
        // GET: /Cities/

        public ViewResult Index()
        {
            return View(context.Cities.Include(city => city.Country).ToList());
        }

        //
        // GET: /Cities/Details/5

        public ViewResult Details(int id)
        {
            City city = context.Cities.Single(x => x.Id == id);
            return View(city);
        }

        //
        // GET: /Cities/Create

        public ActionResult Create()
        {
            ViewBag.PossibleCountries = context.Countries;
            return View();
        } 

        //
        // POST: /Cities/Create

        [HttpPost]
        public ActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                context.Cities.Add(city);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleCountries = context.Countries;
            return View(city);
        }
        
        //
        // GET: /Cities/Edit/5
 
        public ActionResult Edit(int id)
        {
            City city = context.Cities.Single(x => x.Id == id);
            ViewBag.PossibleCountries = context.Countries;
            return View(city);
        }

        //
        // POST: /Cities/Edit/5

        [HttpPost]
        public ActionResult Edit(City city)
        {
            if (ModelState.IsValid)
            {
                context.Entry(city).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleCountries = context.Countries;
            return View(city);
        }

        //
        // GET: /Cities/Delete/5
 
        public ActionResult Delete(int id)
        {
            City city = context.Cities.Single(x => x.Id == id);
            return View(city);
        }

        //
        // POST: /Cities/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            City city = context.Cities.Single(x => x.Id == id);
            context.Cities.Remove(city);
            context.SaveChanges();
            return RedirectToAction("Index");
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