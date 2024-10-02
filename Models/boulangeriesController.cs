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
    public class boulangeriesController : Controller
    {
        private DbEpicerier db = new DbEpicerier();

        // GET: boulangeries
        public ActionResult Index()
        {
            return View(db.boulangerie.ToList());
        }

        // GET: boulangeries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            boulangerie boulangerie = db.boulangerie.Find(id);
            if (boulangerie == null)
            {
                return HttpNotFound();
            }
            return View(boulangerie);
        }

        // GET: boulangeries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: boulangeries/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,image,prix")] boulangerie boulangerie)
        {
            if (ModelState.IsValid)
            {
                db.boulangerie.Add(boulangerie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(boulangerie);
        }

        // GET: boulangeries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            boulangerie boulangerie = db.boulangerie.Find(id);
            if (boulangerie == null)
            {
                return HttpNotFound();
            }
            return View(boulangerie);
        }

        // POST: boulangeries/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,image,prix")] boulangerie boulangerie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(boulangerie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(boulangerie);
        }

        // GET: boulangeries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            boulangerie boulangerie = db.boulangerie.Find(id);
            if (boulangerie == null)
            {
                return HttpNotFound();
            }
            return View(boulangerie);
        }

        // POST: boulangeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            boulangerie boulangerie = db.boulangerie.Find(id);
            db.boulangerie.Remove(boulangerie);
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
