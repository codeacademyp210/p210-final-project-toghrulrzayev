using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class NewsEventsController : Controller
    {
        LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();
        // GET: NewsEvents
        public ActionResult Index()
        {
            var model = new IndexViewModel()
            {
                RelatedEvents = db.RelatedEvents.ToList(),
                NewsEvents = db.NewsEvents.ToList(),
                Logos = db.Logos.ToList(),
                Settings = db.Settings.ToList()

            };

            return View(model);
        }
    }
}