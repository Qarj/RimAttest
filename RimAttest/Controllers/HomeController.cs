using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RimAttest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "RimAttest provides a web site for automated test examples.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Qarj on GitHub.";

            return View();
        }
        public ActionResult Pictures()
        {
            ViewBag.Message = "The Pictures Page.";

            return View();
        }

        public ActionResult JavaScript()
        {
            ViewBag.Message = "The JavaScript Page.";

            return View();
        }

        public ActionResult Special()
        {
            ViewBag.Message = "Here be links to special things.";

            return View();
        }
    }
}