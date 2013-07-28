using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asolatina.Controllers
{
    public class SiteController : Controller
    {
        //
        // GET: /Site/

        public ActionResult Index()
        {
            return View("Home");
        }

        public ActionResult Promotions()
        {
            return View("Home");
        }

        public ActionResult AboutUs()
        {
            return View("Home");
        }

        public ActionResult ContactUs()
        {
            return View("Home");
        }

    }
}
