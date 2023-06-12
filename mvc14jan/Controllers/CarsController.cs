using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc14jan.Models; 

namespace mvc14jan.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getshitinfo()
        {
            Car mycar = new Car();
            mycar.car_id = "0001"; 
            return View(mycar); 
        }
        public ActionResult nothing(int? id)
        {
            if (id == null)
            {
                id = 555; 
            }
            return Content("Yo what is your id " + id); 
        }
        public ActionResult chill(int year , int month, int day)
        {
            
            return Content(String.Format("The year is {0} and the month is {1} and the day is {2}", year, month, day)); 
        }
         [Route("cars/good/{idnumber}/{age}")]
        public ActionResult good(int idnumber , int age)
        {
            return Content(String.Format("Your name is {0} and your age is {1} " , idnumber , age )); 
        }
    }
}