﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models; 

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Details( )
        {
            var Cust = new Customer() { Name = "Supermm" }; 

            return View(Cust);
        }
    }
}