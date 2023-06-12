using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymManagement.Models;
using System.Data.Entity;
using GymManagement.ViewModels; 

namespace GymManagement.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        private ApplicationDbContext context; 
        public UserProfileController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }
        public ActionResult List()
        {
            var TableData = context.UserProfileTable.Include(a => a.gender).ToList(); 

            return View(TableData);
        }
        public ActionResult Details(int id)
        {
            var single = context.UserProfileTable.Include(c => c.gender).SingleOrDefault(c => c.id == id);
           if(single == null)
            {
                return View("NothingFound"); 
            }
            return View(single); 
        }
        public ActionResult CreateForm()
        {
            User_Gender_ViewModel vm = new User_Gender_ViewModel
            {
                GenderList = context.GenderTable.ToList()
            };

            return View("Create",vm); 
        }
        [HttpPost]
        public ActionResult Save(UserProfile userprofile)
        {
            if (!ModelState.IsValid)
            {
                var vm = new User_Gender_ViewModel
                {
                    userprofile = userprofile,
                    GenderList = context.GenderTable.ToList()
                };
                return View("Create", vm); 
            }
            if(userprofile.id == 0)
            {
                context.UserProfileTable.Add(userprofile); 
            } else
            {
                var fromdb = context.UserProfileTable.Single(c => c.id == userprofile.id);

                fromdb.name = userprofile.name;
                fromdb.age = userprofile.age;
                fromdb.genderId = userprofile.genderId; 
                
            }
            context.SaveChanges();
            
            return RedirectToAction("List", "UserProfile");  
        }
        public ActionResult Edit(int id)
        {
            var single = context.UserProfileTable.SingleOrDefault(c => c.id == id);
            var vm = new User_Gender_ViewModel
            {
                userprofile = single,
                GenderList = context.GenderTable.ToList()
            }; 
            return View("Create",vm); 
        }
    }
}