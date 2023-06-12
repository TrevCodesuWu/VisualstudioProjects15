using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CarShop.Models;
using CarShop.ViewModels;

namespace CarShop.Controllers
{
    [AllowAnonymous]
    public class CarController : Controller
    {
        private ApplicationDbContext context; 
        public CarController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }
        // GET: Car

       
        public ActionResult listofcars()
        {
            if (User.IsInRole("CanManageCars"))
            {
                return View("listofcars");
            }

            return View("ReadOnlyList");
        }
        public ActionResult cardetails(int id)
        {
            var carfromdb = context.dbCar
                .Include(c => c.Class)
                .SingleOrDefault(c => c.id == id);

            if (carfromdb == null)
            {
                return HttpNotFound();
            }

            return View(carfromdb); 
        }
        [Authorize(Roles = RoleClass.CanManageCars)]
        public ActionResult carform()
        {
            var vmodel = new carClassViewModel
            {
                
                Class = context.dbClass.ToList()
            };
            return View("carform",vmodel); 
        }
        [Authorize(Roles = RoleClass.CanManageCars)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Car car)
        {
            if (!ModelState.IsValid)
            {
                var vmodel = new carClassViewModel
                {
                    Car = car,
                    Class = context.dbClass.ToList()
                };
                return View("carform",vmodel); 
            }

            if(car.id == 0)
            {
                context.dbCar.Add(car); 
            }
            else
            {
                var carfromdb = context.dbCar.Single(c => c.id == car.id);
                carfromdb.name = car.name;
                carfromdb.model = car.model; 
                carfromdb.price = car.price;
                carfromdb.released = car.released;
                carfromdb.sunroof = car.sunroof;
                carfromdb.ClassId = car.ClassId; 

            }
            context.SaveChanges(); 

            return RedirectToAction("listofcars", "Car"); 
        }
        [Authorize(Roles = RoleClass.CanManageCars)]
        public ActionResult Edit(int id)
        {
            var carfromdb = context.dbCar.SingleOrDefault(c => c.id == id);
            if(carfromdb == null)
            {
                return HttpNotFound(); 
            }
            var vmodel = new carClassViewModel
            {
                Car = carfromdb,
                Class = context.dbClass.ToList()
            };
            return View("carform",vmodel); 
        }
    }
}