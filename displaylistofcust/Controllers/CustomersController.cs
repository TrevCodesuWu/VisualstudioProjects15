using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using displaylistofcust.Models; // applicationName plus .Model to show you can use the Models now 

namespace displaylistofcust.Controllers
{
    public class CustomersController : Controller
    {
        
        private ApplicationDbContext context; 
        public CustomersController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }
        /* No longer need the list because we created an instance of the applicationdb context 
        // GET: Customers
        private IEnumerable<Customer> getcus() //private method of type IEnumerable that returns a list 
        {
            var custom = new List<Customer>()
            {
                new Customer {customerID=01,customerName="evvy",customerAddress="street" },
                new Customer {customerID=07,customerName="Shinigami",customerAddress="nopixel" },
                new Customer {customerID=05,customerName="Ramee",customerAddress="Los Angelos" },
                new Customer {customerID=03,customerName="Tony",customerAddress="Clean Manor" }
            };
            return custom; 
            /* #1- I created a method of type IEnumerable and made  a list inside it and then called the list in the 
             other ActionResult instead of making a list inside the Actionmethod which then others cannot access it 
             and it would be unusable in Details Actionmethod 
        } 
      */
        public ActionResult listcust()
        {
            var cust1 = context.Customer.ToList();

  /* #0- I need to create a method which has the database(list of customers) and use linq to call it out
            using the id I get from the details and compare it to the one in the list and do the thing or return
                not found */ 
            return View(cust1); //Whatever is returned here , the view can use it . that is why when there is two lists
             // or two classes initialized you have to use a viewmodel to return both to the view 
        }  
        public ActionResult Details(int id)
        { /* #3- Trying to get the Id of the person in the list with a linq query and using the id from the parameters to 
            compare if it exists and make arrangements */  // update- now changed to context.Customers because of dbcontext

            var val  = context.Customer.SingleOrDefault(c => c.customerID == id);

            if (val == null)
            {
                return RedirectToAction("error"); 
            }
            return View(val); 
        }
        public ActionResult error()
        {
            return View(); 
        }
    }
}