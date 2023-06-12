using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestuarantApplication.Models;
using RestuarantApplication.ViewModels;
using System.Data.Entity; 

namespace RestuarantApplication.Controllers
{
    public class FoodController : Controller
    {
        private ApplicationDbContext context;
        public FoodController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }
        // To return the list of foods page 
        public ActionResult ListFoods()
        {
            var listFoods = context.FoodDbSet.Include(d => d.category).ToList();

            return View(listFoods); 
        }
        public ActionResult FoodDetails(int id)
        {
            var foodfromdb = context.FoodDbSet.Include(c => c.category).SingleOrDefault(c => c.id == id); 
            if(foodfromdb == null)
            {
                return HttpNotFound(); 
            }
            return View(foodfromdb); 
        }
        public ActionResult FoodForm()
        {
            var vm = new FoodCategoryViewModel
            {
                categoryvm = context.CategoryDbSet.ToList()
            }; 
            return View("Form",vm); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Food foodvm) // make sure the name of the thing is the same as the one in the view model 
        {

            if (!ModelState.IsValid)
            {
                var vm = new FoodCategoryViewModel
                {
                    foodvm = foodvm,
                    categoryvm = context.CategoryDbSet.ToList()
                };
                return View("Form", vm); 
            }
            if(foodvm.id == 0)
            {
                context.FoodDbSet.Add(foodvm); 
            }
            else
            {
                var foodindb = context.FoodDbSet.Single(c => c.id == foodvm.id);

                foodindb.food_name = foodvm.food_name;
                foodindb.price = foodvm.price;
                foodindb.country = foodvm.country;
                foodindb.CategoryId = foodvm.CategoryId;
                foodindb.food_url = foodvm.food_url; 
            }
            context.SaveChanges();
            return RedirectToAction("ListFoods","Food"); 
        }
        public ActionResult Edit(int id)
        {
            var foodfromdb = context.FoodDbSet.SingleOrDefault(c => c.id == id); 
            if(foodfromdb == null)
            {
                return HttpNotFound(); 
            }
            var vm = new FoodCategoryViewModel
            {
                foodvm = foodfromdb,
                categoryvm = context.CategoryDbSet.ToList()
            };
            return View("Form",vm); 
        }
    }
}