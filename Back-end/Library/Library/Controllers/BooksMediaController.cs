using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BooksMediaController : Controller
    {
        LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();
        // GET: BooksMedia
        public ActionResult Index()
        {
            var model = new IndexViewModel()
            {
                BooksMediaTitles = db.BooksMediaTitles.ToList(),
                BookCategories = db.BookCategories.ToList(),
                RelatedSearches = db.RelatedSearchs.ToList(),
                OnOrderItems = db.OnOrderItems.ToList(),
                StaffPicks = db.StaffPicks.ToList(),
                NewReleas = db.NewReleases.ToList(),
                Logos = db.Logos.ToList(),
                Settings = db.Settings.ToList()
            };
            return View(model);
        }
    }
}