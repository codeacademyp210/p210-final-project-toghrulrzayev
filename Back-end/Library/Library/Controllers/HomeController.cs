using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();
        public ActionResult Index()
        {
            var model = new IndexViewModel()
            {
                AllReleas = db.AllReleases.ToList(),
                SliderRoots = db.SliderRoots.ToList(),
                Books = db.Books.ToList(),
                Portfolios = db.Portfolios.ToList(),
                Communities = db.Communities.ToList(),
                LibraryWelcomes = db.LibraryWelcomes.ToList(),
                Logos = db.Logos.ToList(),


                AdminUsers = db.AdminUsers.ToList(),      
                Settings=db.Settings.ToList(),
              
            };

            return View(model);
        }

      
    }
}