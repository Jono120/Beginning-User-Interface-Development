using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebUI.Controllers
{
    public class HomeController : Controller
    {
        //Home page description and linkage
        public ActionResult Index()
        {
            return View();
        }

        //About page description and linkage
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Contact page description and linkage
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}