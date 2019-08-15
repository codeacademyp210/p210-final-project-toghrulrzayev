using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library.Areas.Admin.Helpers;
using Library.Models;

namespace Library.Areas.Admin.Controllers
{
    [Auth]

    public class LogoesController : Controller
    {
        private LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();

        // GET: Admin/Logoes
        public ActionResult Index()
        {
            return View(db.Logos.ToList());
        }

        // GET: Admin/Logoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Logo logo = db.Logos.Find(id);
            if (logo == null)
            {
                return HttpNotFound();
            }
            return View(logo);
        }

        // GET: Admin/Logoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Logoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Image,Classs")] Logo logo)
        {
            if (ModelState.IsValid)
            {
                db.Logos.Add(logo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(logo);
        }

        // GET: Admin/Logoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Logo logo = db.Logos.Find(id);
            if (logo == null)
            {
                return HttpNotFound();
            }
            return View(logo);
        }

        // POST: Admin/Logoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Image,Classs")] Logo logo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(logo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logo);
        }

        // GET: Admin/Logoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Logo logo = db.Logos.Find(id);
            if (logo == null)
            {
                return HttpNotFound();
            }
            return View(logo);
        }

        // POST: Admin/Logoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Logo logo = db.Logos.Find(id);
            db.Logos.Remove(logo);
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
