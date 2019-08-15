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

    public class PortfoliosController : Controller
    {
        private LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();

        // GET: Admin/Portfolios
        public ActionResult Index()
        {
            return View(db.Portfolios.ToList());
        }

        // GET: Admin/Portfolios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portfolio portfolio = db.Portfolios.Find(id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }
            return View(portfolio);
        }

        // GET: Admin/Portfolios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Portfolios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Header,Title,Text,ReadMore")] Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                db.Portfolios.Add(portfolio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(portfolio);
        }

        // GET: Admin/Portfolios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portfolio portfolio = db.Portfolios.Find(id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }
            return View(portfolio);
        }

        // POST: Admin/Portfolios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Header,Title,Text,ReadMore")] Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(portfolio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portfolio);
        }

        // GET: Admin/Portfolios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Portfolio portfolio = db.Portfolios.Find(id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }
            return View(portfolio);
        }

        // POST: Admin/Portfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Portfolio portfolio = db.Portfolios.Find(id);
            db.Portfolios.Remove(portfolio);
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
