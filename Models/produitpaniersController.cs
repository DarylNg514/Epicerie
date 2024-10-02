using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace projetEpicerie.Models
{
    public class produitpaniersController : Controller
    {
        private DbEpicerier db = new DbEpicerier();

        // GET: produitpaniers
        public ActionResult Index()
        {
            return View(db.produitpanier.ToList());
        }

        // GET: produitpaniers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produitpanier produitpanier = db.produitpanier.Find(id);
            if (produitpanier == null)
            {
                return HttpNotFound();
            }
            return View(produitpanier);
        }

        // GET: produitpaniers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: produitpaniers/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,image,name,description,prix")] produitpanier produitpanier)
        {
            if (ModelState.IsValid)
            {
                db.produitpanier.Add(produitpanier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produitpanier);
        }

        // GET: produitpaniers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produitpanier produitpanier = db.produitpanier.Find(id);
            if (produitpanier == null)
            {
                return HttpNotFound();
            }
            return View(produitpanier);
        }

        // POST: produitpaniers/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,image,name,description,prix")] produitpanier produitpanier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produitpanier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produitpanier);
        }

        // GET: produitpaniers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produitpanier produitpanier = db.produitpanier.Find(id);
            if (produitpanier == null)
            {
                return HttpNotFound();
            }
            return View(produitpanier);
        }

        // POST: produitpaniers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            produitpanier produitpanier = db.produitpanier.Find(id);
            db.produitpanier.Remove(produitpanier);
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
