using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicAuth.Controllers
{
    [BasicAuthentication]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [Filter1]
        [BasicAuthentication]
        public ActionResult Index1()
        {
            ViewBag.Title = "Home Page 1";

            return View("Index");
        }
    }
}
