using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using taskNortal.Models;
using taskNortal.Shared;

namespace taskNortal.Controllers
{
    public class HomeController : Controller
    {
        private PhonesContext db = new PhonesContext();
        public ActionResult Index()
        {

            return View(db.dbSet.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}