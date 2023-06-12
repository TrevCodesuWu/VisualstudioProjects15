using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Migrations_EF.Models;
using System.Data.Entity;
using Migrations_EF.ViewModels; 

namespace Migrations_EF.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult listofcust()
        {
            var cuslist = _context.Customers.Include(c => c.Membershiptypes).ToList();

            return View(cuslist);
        }
        public ActionResult custInfo(int id)
        {
            var item = _context.Customers.Include(m => m.Membershiptypes).SingleOrDefault(c => c.id == id);
            if (item == null)
            {
                return RedirectToAction("custNotFound");
            }

            return View(item);
        }
       
        public ActionResult custNotFound()
        {
            return View();
        }
        
        public ActionResult New()
        {
            var databasemem = _context.MembershipTypes.ToList();

            var cus_memlist = new NewCustomerViewModel()
            {
                customer = new Customer(),
                memlist = databasemem    
            }; 
            return View("CustomerForm",cus_memlist); 
        }

        [HttpPost] //If your actions modify data they should never be accessible by HTTP GET 
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                NewCustomerViewModel viewmodel = new NewCustomerViewModel
                {
                    customer = customer,
                    memlist = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm",viewmodel); 
            }
            if(customer.id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var cusInDb = _context.Customers.Single(c => c.id == customer.id);
                cusInDb.name = customer.name;
                cusInDb.isSubscribedToNewsLetter = customer.isSubscribedToNewsLetter;
                cusInDb.MembershipTypesId = customer.MembershipTypesId;
                cusInDb.birthD = customer.birthD; 
            }
            _context.SaveChanges();

            return RedirectToAction("listofcust","Customer"); 
        }

        public ActionResult Edit(int id)
        {
            var value = _context.Customers.SingleOrDefault(c => c.id == id);
            NewCustomerViewModel viewmodel = new NewCustomerViewModel()
            {
                customer = value,
                memlist = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewmodel); 
        }
 
    }   
    
    
}