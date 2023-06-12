using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc16Jan.Models;
using mvc16Jan.ViewModels; 

namespace mvc16Jan.Controllers
{
    public class customerController : Controller
    {
        // GET: customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult listcustomer()
        {
            List<Customer> cust = new List<Customer>()
            {
                new Customer { cust_name = "Kylan" ,cust_address="sunpark drive",cust_gender='M',cust_number= 0828384757 },
                new Customer { cust_name = "Joshua", cust_address ="Greenland" ,cust_gender='F',cust_number= 0712635378 },
                new Customer {cust_name ="Rakheel",cust_address ="newhevan",cust_gender='M',cust_number= 0923734637 }
            };

           /* List<Cashier> cash = new List<Cashier>();
            cash.Add{ }

            customer_cashier_transaction cuscash = new customer_cashier_transaction();
            cuscash.cashier = cash; 
            cuscash.customer = cust; 
             */ 

            return View(cust); 
        }

    }
}