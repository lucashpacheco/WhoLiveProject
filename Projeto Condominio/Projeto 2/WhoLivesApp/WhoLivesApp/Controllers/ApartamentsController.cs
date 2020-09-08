using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using WhoLivesApp.Models;

namespace WhoLivesApp.Controllers
{
    public class ApartamentsController : Controller
    {
        private ApContext db = new ApContext();

        // GET: Apartaments
        public ActionResult Index()
        {
            return View(db.Apartaments.ToList());
        }

        // GET: Apartaments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartament apartament = db.Apartaments.Find(id);
            if (apartament == null)
            {
                return HttpNotFound();
            }
            return View(apartament);
        }

        // GET: Apartaments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apartaments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AP_ID,AP_NUMERO,AP_ATENCAO")] Apartament apartament)
        {
            if (ModelState.IsValid)
            {
                db.Apartaments.Add(apartament);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apartament);
        }

        // GET: Apartaments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartament apartament = db.Apartaments.Find(id);
            if (apartament == null)
            {
                return HttpNotFound();
            }
            return View(apartament);
        }

        // POST: Apartaments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AP_ID,AP_NUMERO,AP_ATENCAO")] Apartament apartament)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apartament).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(apartament);
        }

        // GET: Apartaments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartament apartament = db.Apartaments.Find(id);
            if (apartament == null)
            {
                return HttpNotFound();
            }
            return View(apartament);
        }

        // POST: Apartaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apartament apartament = db.Apartaments.Find(id);
            db.Apartaments.Remove(apartament);
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
