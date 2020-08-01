using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webapiproject.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            // this is the first Controller
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
