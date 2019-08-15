using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class ServicesController : Controller
    {
        LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();
        // GET: Services
        public ActionResult Index()
        {
            var model = new IndexViewModel()
            {
                ServicesWhos = db.ServicesWhos.ToList(),
                Offerings = db.Offerings.ToList(),
                WordsCommunities = db.WordsCommunities.ToList(),
                AllReleas = db.AllReleases.ToList(),
                Logos = db.Logos.ToList(),
                Settings = db.Settings.ToList()
            };
          
            return View(model);
        }
    }
}