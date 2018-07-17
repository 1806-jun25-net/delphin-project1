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
    public class NumberOfPizzaOrderedsController : Controller
    {
        private PizzaEntities db = new PizzaEntities();

        // GET: NumberOfPizzaOrdereds
        public ActionResult Index()
        {
            var numberOfPizzaOrdereds = db.NumberOfPizzaOrdereds.Include(n => n.Pizza).Include(n => n.Pizza13).Include(n => n.Pizza14).Include(n => n.Pizza15).Include(n => n.Pizza16).Include(n => n.Pizza17).Include(n => n.Pizza18).Include(n => n.Pizza19).Include(n => n.Pizza20).Include(n => n.Pizza21).Include(n => n.Pizza22).Include(n => n.Pizza23);
            return View(numberOfPizzaOrdereds.ToList());
        }

        // GET: NumberOfPizzaOrdereds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NumberOfPizzaOrdered numberOfPizzaOrdered = db.NumberOfPizzaOrdereds.Find(id);
            if (numberOfPizzaOrdered == null)
            {
                return HttpNotFound();
            }
            return View(numberOfPizzaOrdered);
        }

        // GET: NumberOfPizzaOrdereds/Create
        public ActionResult Create()
        {
            ViewBag.Pizza1 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza10 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza11 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza12 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza2 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza3 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza4 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza5 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza6 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza7 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza8 = new SelectList(db.Pizzas, "ID", "ID");
            ViewBag.Pizza9 = new SelectList(db.Pizzas, "ID", "ID");
            return View();
        }

        // POST: NumberOfPizzaOrdereds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Pizza1,Pizza2,Pizza3,Pizza4,Pizza5,Pizza6,Pizza7,Pizza8,Pizza9,Pizza10,Pizza11,Pizza12")] NumberOfPizzaOrdered numberOfPizzaOrdered)
        {
            if (ModelState.IsValid)
            {
                db.NumberOfPizzaOrdereds.Add(numberOfPizzaOrdered);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Pizza1 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza1);
            ViewBag.Pizza10 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza10);
            ViewBag.Pizza11 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza11);
            ViewBag.Pizza12 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza12);
            ViewBag.Pizza2 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza2);
            ViewBag.Pizza3 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza3);
            ViewBag.Pizza4 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza4);
            ViewBag.Pizza5 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza5);
            ViewBag.Pizza6 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza6);
            ViewBag.Pizza7 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza7);
            ViewBag.Pizza8 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza8);
            ViewBag.Pizza9 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza9);
            return View(numberOfPizzaOrdered);
        }

        // GET: NumberOfPizzaOrdereds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NumberOfPizzaOrdered numberOfPizzaOrdered = db.NumberOfPizzaOrdereds.Find(id);
            if (numberOfPizzaOrdered == null)
            {
                return HttpNotFound();
            }
            ViewBag.Pizza1 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza1);
            ViewBag.Pizza10 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza10);
            ViewBag.Pizza11 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza11);
            ViewBag.Pizza12 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza12);
            ViewBag.Pizza2 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza2);
            ViewBag.Pizza3 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza3);
            ViewBag.Pizza4 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza4);
            ViewBag.Pizza5 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza5);
            ViewBag.Pizza6 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza6);
            ViewBag.Pizza7 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza7);
            ViewBag.Pizza8 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza8);
            ViewBag.Pizza9 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza9);
            return View(numberOfPizzaOrdered);
        }

        // POST: NumberOfPizzaOrdereds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Pizza1,Pizza2,Pizza3,Pizza4,Pizza5,Pizza6,Pizza7,Pizza8,Pizza9,Pizza10,Pizza11,Pizza12")] NumberOfPizzaOrdered numberOfPizzaOrdered)
        {
            if (ModelState.IsValid)
            {
                db.Entry(numberOfPizzaOrdered).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Pizza1 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza1);
            ViewBag.Pizza10 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza10);
            ViewBag.Pizza11 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza11);
            ViewBag.Pizza12 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza12);
            ViewBag.Pizza2 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza2);
            ViewBag.Pizza3 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza3);
            ViewBag.Pizza4 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza4);
            ViewBag.Pizza5 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza5);
            ViewBag.Pizza6 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza6);
            ViewBag.Pizza7 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza7);
            ViewBag.Pizza8 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza8);
            ViewBag.Pizza9 = new SelectList(db.Pizzas, "ID", "ID", numberOfPizzaOrdered.Pizza9);
            return View(numberOfPizzaOrdered);
        }

        // GET: NumberOfPizzaOrdereds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NumberOfPizzaOrdered numberOfPizzaOrdered = db.NumberOfPizzaOrdereds.Find(id);
            if (numberOfPizzaOrdered == null)
            {
                return HttpNotFound();
            }
            return View(numberOfPizzaOrdered);
        }

        // POST: NumberOfPizzaOrdereds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NumberOfPizzaOrdered numberOfPizzaOrdered = db.NumberOfPizzaOrdereds.Find(id);
            db.NumberOfPizzaOrdereds.Remove(numberOfPizzaOrdered);
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
