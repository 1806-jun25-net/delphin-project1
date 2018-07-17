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
    public class IngredientsOnPizzasController : Controller
    {
        private PizzaEntities db = new PizzaEntities();

        // GET: IngredientsOnPizzas
        public ActionResult Index()
        {
            var ingredientsOnPizzas = db.IngredientsOnPizzas.Include(i => i.Ingredient).Include(i => i.Ingredient10).Include(i => i.Ingredient11).Include(i => i.Ingredient12).Include(i => i.Ingredient13).Include(i => i.Ingredient14).Include(i => i.Ingredient15).Include(i => i.Ingredient16).Include(i => i.Ingredient17);
            return View(ingredientsOnPizzas.ToList());
        }

        // GET: IngredientsOnPizzas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientsOnPizza ingredientsOnPizza = db.IngredientsOnPizzas.Find(id);
            if (ingredientsOnPizza == null)
            {
                return HttpNotFound();
            }
            return View(ingredientsOnPizza);
        }

        // GET: IngredientsOnPizzas/Create
        public ActionResult Create()
        {
            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "ID", "Name");
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "ID", "Name");
            return View();
        }

        // POST: IngredientsOnPizzas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9")] IngredientsOnPizza ingredientsOnPizza)
        {
            if (ModelState.IsValid)
            {
                db.IngredientsOnPizzas.Add(ingredientsOnPizza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient1);
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient2);
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient3);
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient4);
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient5);
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient6);
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient7);
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient8);
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient9);
            return View(ingredientsOnPizza);
        }

        // GET: IngredientsOnPizzas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientsOnPizza ingredientsOnPizza = db.IngredientsOnPizzas.Find(id);
            if (ingredientsOnPizza == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient1);
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient2);
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient3);
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient4);
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient5);
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient6);
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient7);
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient8);
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient9);
            return View(ingredientsOnPizza);
        }

        // POST: IngredientsOnPizzas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9")] IngredientsOnPizza ingredientsOnPizza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingredientsOnPizza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient1);
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient2);
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient3);
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient4);
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient5);
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient6);
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient7);
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient8);
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "ID", "Name", ingredientsOnPizza.Ingredient9);
            return View(ingredientsOnPizza);
        }

        // GET: IngredientsOnPizzas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientsOnPizza ingredientsOnPizza = db.IngredientsOnPizzas.Find(id);
            if (ingredientsOnPizza == null)
            {
                return HttpNotFound();
            }
            return View(ingredientsOnPizza);
        }

        // POST: IngredientsOnPizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IngredientsOnPizza ingredientsOnPizza = db.IngredientsOnPizzas.Find(id);
            db.IngredientsOnPizzas.Remove(ingredientsOnPizza);
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
