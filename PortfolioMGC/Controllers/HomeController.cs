using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioMGC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult About()
        {
            return View("About");
        }
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View("Contact");
        }
        public ActionResult Resume()
        {
            ViewBag.Message = "";
            return View();
        }
    }
}