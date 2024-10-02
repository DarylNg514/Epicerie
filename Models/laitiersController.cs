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
    public class laitiersController : Controller
    {
        private DbEpicerier db = new DbEpicerier();

        // GET: laitiers
        public ActionResult Index()
        {
            return View(db.laitiers.ToList());
        }

        // GET: laitiers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            laitiers laitiers = db.laitiers.Find(id);
            if (laitiers == null)
            {
                return HttpNotFound();
            }
            return View(laitiers);
        }

        // GET: laitiers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: laitiers/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,image,prix")] laitiers laitiers)
        {
            if (ModelState.IsValid)
            {
                db.laitiers.Add(laitiers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(laitiers);
        }

        // GET: laitiers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            laitiers laitiers = db.laitiers.Find(id);
            if (laitiers == null)
            {
                return HttpNotFound();
            }
            return View(laitiers);
        }

        // POST: laitiers/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,image,prix")] laitiers laitiers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laitiers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laitiers);
        }

        // GET: laitiers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            laitiers laitiers = db.laitiers.Find(id);
            if (laitiers == null)
            {
                return HttpNotFound();
            }
            return View(laitiers);
        }

        // POST: laitiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            laitiers laitiers = db.laitiers.Find(id);
            db.laitiers.Remove(laitiers);
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
