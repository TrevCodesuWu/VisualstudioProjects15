using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc15jan.Controllers
{
    public class ticketController : Controller
    {
        // GET: ticket
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult giveticket()
        {

            return View(); 
        }
    }
}