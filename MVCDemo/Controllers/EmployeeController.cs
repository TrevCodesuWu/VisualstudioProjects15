using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models; 
namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employees
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                Name = "trevlin",
                Gender = "male",
                City = "durban"
            };

            return View(employee);
        }
    }
}