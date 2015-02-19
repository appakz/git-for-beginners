using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitSampleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //commit 001
            //rebase commit 002
            return View();
        }

        public ActionResult About()
        {
            //essej commit 001
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //rebase commit 003
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}