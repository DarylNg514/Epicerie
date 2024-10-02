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
    public class fruits_et_légumesController : Controller
    {
        private DbEpicerier db = new DbEpicerier();

        // GET: fruits_et_légumes
        public ActionResult Index()
        {
            return View(db.fruits_et_légumes.ToList());
        }

        // GET: fruits_et_légumes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fruits_et_légumes fruits_et_légumes = db.fruits_et_légumes.Find(id);
            if (fruits_et_légumes == null)
            {
                return HttpNotFound();
            }
            return View(fruits_et_légumes);
        }

        // GET: fruits_et_légumes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: fruits_et_légumes/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,image,prix")] fruits_et_légumes fruits_et_légumes)
        {
            if (ModelState.IsValid)
            {
                db.fruits_et_légumes.Add(fruits_et_légumes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fruits_et_légumes);
        }

        // GET: fruits_et_légumes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fruits_et_légumes fruits_et_légumes = db.fruits_et_légumes.Find(id);
            if (fruits_et_légumes == null)
            {
                return HttpNotFound();
            }
            return View(fruits_et_légumes);
        }

        // POST: fruits_et_légumes/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,image,prix")] fruits_et_légumes fruits_et_légumes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fruits_et_légumes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fruits_et_légumes);
        }

        // GET: fruits_et_légumes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fruits_et_légumes fruits_et_légumes = db.fruits_et_légumes.Find(id);
            if (fruits_et_légumes == null)
            {
                return HttpNotFound();
            }
            return View(fruits_et_légumes);
        }

        // POST: fruits_et_légumes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            fruits_et_légumes fruits_et_légumes = db.fruits_et_légumes.Find(id);
            db.fruits_et_légumes.Remove(fruits_et_légumes);
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
