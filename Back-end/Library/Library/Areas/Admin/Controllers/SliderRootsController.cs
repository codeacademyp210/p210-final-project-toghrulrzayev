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

    public class SliderRootsController : Controller
    {
        private LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();

        // GET: Admin/SliderRoots
        public ActionResult Index()
        {
            return View(db.SliderRoots.ToList());
        }

        // GET: Admin/SliderRoots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderRoot sliderRoot = db.SliderRoots.Find(id);
            if (sliderRoot == null)
            {
                return HttpNotFound();
            }
            return View(sliderRoot);
        }

        // GET: Admin/SliderRoots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SliderRoots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Title,Text,TextSecond")] SliderRoot sliderRoot)
        {
            if (ModelState.IsValid)
            {
                db.SliderRoots.Add(sliderRoot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sliderRoot);
        }

        // GET: Admin/SliderRoots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderRoot sliderRoot = db.SliderRoots.Find(id);
            if (sliderRoot == null)
            {
                return HttpNotFound();
            }
            return View(sliderRoot);
        }

        // POST: Admin/SliderRoots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Title,Text,TextSecond")] SliderRoot sliderRoot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sliderRoot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sliderRoot);
        }

        // GET: Admin/SliderRoots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderRoot sliderRoot = db.SliderRoots.Find(id);
            if (sliderRoot == null)
            {
                return HttpNotFound();
            }
            return View(sliderRoot);
        }

        // POST: Admin/SliderRoots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SliderRoot sliderRoot = db.SliderRoots.Find(id);
            db.SliderRoots.Remove(sliderRoot);
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
