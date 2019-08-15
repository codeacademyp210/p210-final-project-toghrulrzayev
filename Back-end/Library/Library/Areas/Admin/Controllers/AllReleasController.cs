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

    public class AllReleasController : Controller
    {
        private LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();

        // GET: Admin/AllReleas
        public ActionResult Index()
        {
            return View(db.AllReleases.ToList());
        }

        // GET: Admin/AllReleas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllReleas allReleas = db.AllReleases.Find(id);
            if (allReleas == null)
            {
                return HttpNotFound();
            }
            return View(allReleas);
        }

        // GET: Admin/AllReleas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AllReleas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Title,AuthorTitle,AuthorText,Isbn,IsbnCod,Text")] AllReleas allReleas)
        {
            if (ModelState.IsValid)
            {
                db.AllReleases.Add(allReleas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(allReleas);
        }

        // GET: Admin/AllReleas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllReleas allReleas = db.AllReleases.Find(id);
            if (allReleas == null)
            {
                return HttpNotFound();
            }
            return View(allReleas);
        }

        // POST: Admin/AllReleas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Title,AuthorTitle,AuthorText,Isbn,IsbnCod,Text")] AllReleas allReleas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allReleas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(allReleas);
        }

        // GET: Admin/AllReleas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllReleas allReleas = db.AllReleases.Find(id);
            if (allReleas == null)
            {
                return HttpNotFound();
            }
            return View(allReleas);
        }

        // POST: Admin/AllReleas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AllReleas allReleas = db.AllReleases.Find(id);
            db.AllReleases.Remove(allReleas);
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
