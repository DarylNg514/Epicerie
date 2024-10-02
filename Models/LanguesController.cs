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
    public class LanguesController : Controller
    {
        private DbEpicerier db = new DbEpicerier();

        // GET: Langues
        public ActionResult Index()
        {
            return View(db.Langues.ToList());
        }

        // GET: Langues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Langues langues = db.Langues.Find(id);
            if (langues == null)
            {
                return HttpNotFound();
            }
            return View(langues);
        }

        // GET: Langues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Langues/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,symbol,name,description")] Langues langues)
        {
            if (ModelState.IsValid)
            {
                db.Langues.Add(langues);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(langues);
        }

        // GET: Langues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Langues langues = db.Langues.Find(id);
            if (langues == null)
            {
                return HttpNotFound();
            }
            return View(langues);
        }

        // POST: Langues/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,symbol,name,description")] Langues langues)
        {
            if (ModelState.IsValid)
            {
                db.Entry(langues).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(langues);
        }

        // GET: Langues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Langues langues = db.Langues.Find(id);
            if (langues == null)
            {
                return HttpNotFound();
            }
            return View(langues);
        }

        // POST: Langues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Langues langues = db.Langues.Find(id);
            db.Langues.Remove(langues);
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
