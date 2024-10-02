﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace projetEpicerie.Models
{
    public class viandesController : Controller
    {
        private DbEpicerier db = new DbEpicerier();

        // GET: viandes
        public ActionResult Index()
        {
            return View(db.viandes.ToList());
        }

        // GET: viandes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            viandes viandes = db.viandes.Find(id);
            if (viandes == null)
            {
                return HttpNotFound();
            }
            return View(viandes);
        }

        // GET: viandes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: viandes/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,image,prix")] viandes viandes)
        {
            if (ModelState.IsValid)
            {
                db.viandes.Add(viandes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viandes);
        }

        // GET: viandes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            viandes viandes = db.viandes.Find(id);
            if (viandes == null)
            {
                return HttpNotFound();
            }
            return View(viandes);
        }

        // POST: viandes/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,image,prix")] viandes viandes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viandes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viandes);
        }

        // GET: viandes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            viandes viandes = db.viandes.Find(id);
            if (viandes == null)
            {
                return HttpNotFound();
            }
            return View(viandes);
        }

        // POST: viandes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            viandes viandes = db.viandes.Find(id);
            db.viandes.Remove(viandes);
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
