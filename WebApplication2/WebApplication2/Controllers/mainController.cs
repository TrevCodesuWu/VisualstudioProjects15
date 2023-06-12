using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult helloView()
        {
            return View();
        }
    }
}