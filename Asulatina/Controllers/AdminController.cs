using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asulatina.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View("LoanRequest");
        }

        public ActionResult LoanRequest()
        {
            return View("LoanRequest");
        }

        public ActionResult AccountStatus()
        {
            return View("AccountStatus");
        }


        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Site");
        }
    }
}
