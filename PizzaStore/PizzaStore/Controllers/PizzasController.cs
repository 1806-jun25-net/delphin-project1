using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PizzaStore.Models;

namespace PizzaStore.Controllers
{
    public class PizzasController : Controller
    {
        private PizzaEntities db = new PizzaEntities();

        // GET: Pizzas
        public ActionResult Index()
        {
            var pizzas = db.Pizzas.Include(p => p.Crust).Include(p => p.IngredientsOnPizza).Include(p => p.Location).Include(p => p.Sauce).Include(p => p.Size).Include(p => p.User);
            return View(pizzas.ToList());
        }

        // GET: Pizzas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pizza pizza = db.Pizzas.Find(id);
            if (pizza == null)
            {
                return HttpNotFound();
            }
            return View(pizza);
        }

        // GET: Pizzas/Create
        public ActionResult Create()
        {
            ViewBag.CrustID = new SelectList(db.Crusts, "ID", "Name");
            ViewBag.IngredientsOnPizzaID = new SelectList(db.IngredientsOnPizzas, "ID", "ID");
            ViewBag.LocationID = new SelectList(db.Locations, "ID", "NAME");
            ViewBag.SauceID = new SelectList(db.Sauces, "ID", "Name");
            ViewBag.SizeID = new SelectList(db.Sizes, "ID", "Name");
            ViewBag.UserID = new SelectList(db.Users, "ID", "FirstName");
            return View();
        }

        // POST: Pizzas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LocationID,UserID,SizeID,CrustID,SauceID,IngredientsOnPizzaID,PizzaPrice")] Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CrustID = new SelectList(db.Crusts, "ID", "Name", pizza.CrustID);
            ViewBag.IngredientsOnPizzaID = new SelectList(db.IngredientsOnPizzas, "ID", "ID", pizza.IngredientsOnPizzaID);
            ViewBag.LocationID = new SelectList(db.Locations, "ID", "NAME", pizza.LocationID);
            ViewBag.SauceID = new SelectList(db.Sauces, "ID", "Name", pizza.SauceID);
            ViewBag.SizeID = new SelectList(db.Sizes, "ID", "Name", pizza.SizeID);
            ViewBag.UserID = new SelectList(db.Users, "ID", "FirstName", pizza.UserID);
            return View(pizza);
        }

        // GET: Pizzas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pizza pizza = db.Pizzas.Find(id);
            if (pizza == null)
            {
                return HttpNotFound();
            }
            ViewBag.CrustID = new SelectList(db.Crusts, "ID", "Name", pizza.CrustID);
            ViewBag.IngredientsOnPizzaID = new SelectList(db.IngredientsOnPizzas, "ID", "ID", pizza.IngredientsOnPizzaID);
            ViewBag.LocationID = new SelectList(db.Locations, "ID", "NAME", pizza.LocationID);
            ViewBag.SauceID = new SelectList(db.Sauces, "ID", "Name", pizza.SauceID);
            ViewBag.SizeID = new SelectList(db.Sizes, "ID", "Name", pizza.SizeID);
            ViewBag.UserID = new SelectList(db.Users, "ID", "FirstName", pizza.UserID);
            return View(pizza);
        }

        // POST: Pizzas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LocationID,UserID,SizeID,CrustID,SauceID,IngredientsOnPizzaID,PizzaPrice")] Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pizza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CrustID = new SelectList(db.Crusts, "ID", "Name", pizza.CrustID);
            ViewBag.IngredientsOnPizzaID = new SelectList(db.IngredientsOnPizzas, "ID", "ID", pizza.IngredientsOnPizzaID);
            ViewBag.LocationID = new SelectList(db.Locations, "ID", "NAME", pizza.LocationID);
            ViewBag.SauceID = new SelectList(db.Sauces, "ID", "Name", pizza.SauceID);
            ViewBag.SizeID = new SelectList(db.Sizes, "ID", "Name", pizza.SizeID);
            ViewBag.UserID = new SelectList(db.Users, "ID", "FirstName", pizza.UserID);
            return View(pizza);
        }

        // GET: Pizzas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pizza pizza = db.Pizzas.Find(id);
            if (pizza == null)
            {
                return HttpNotFound();
            }
            return View(pizza);
        }

        // POST: Pizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pizza pizza = db.Pizzas.Find(id);
            db.Pizzas.Remove(pizza);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
