using Library.Models;
using Library.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class ContactController : Controller
    {
        LibraryProjectFinalEntities db = new LibraryProjectFinalEntities();
        // GET: Contact
        public ActionResult Index()
        {
            var model = new IndexViewModel()
            {
                Logos = db.Logos.ToList(),
                ContactHeaders=db.ContactHeaders.ToList(),
                ContactPhones=db.ContactPhones.ToList(),
                Settings = db.Settings.ToList()
            };
            return View(model);
        }
    }
}