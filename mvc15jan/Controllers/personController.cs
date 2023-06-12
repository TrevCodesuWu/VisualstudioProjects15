using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc15jan.Controllers
{
    public class personController : Controller
    {
        // GET: person
        public ActionResult Index()
        {
            return View();
        }
    }
}