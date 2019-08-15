using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{

    public class BlogController : Controller
    {
        LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();
        // GET: Blog
        public ActionResult Index()
        {
            var model = new IndexViewModel()
            {
                BlogHeaders = db.BlogHeaders.ToList(),
                BlogInfos = db.BlogInfos.ToList(),
                Logos = db.Logos.ToList(),
                Settings = db.Settings.ToList()

            };

            return View(model);
        }
    }
}