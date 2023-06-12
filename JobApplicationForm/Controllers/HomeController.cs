using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobApplicationForm.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is your description page you are currently viewing :)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This yo contact page ";

            return View();
        }
    }
}