using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc16Jan.Models; 

namespace mvc16Jan.Controllers
{
    public class cashierController : Controller
    {
        // GET: Cashier
        public ActionResult Index()
        {
            return View();
        }
       
    }
}