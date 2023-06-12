using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc15jan.Models; 
namespace mvc15jan.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getcustomerobj()
        {
            customers cust = new customers();
            cust.customer_id = "0001";
            cust.customer_name = "Trevlin";

            return View(cust);  
        }
    }
}