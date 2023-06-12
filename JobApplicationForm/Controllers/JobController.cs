using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobApplicationForm.Models;
using System.Data.Entity;
using JobApplicationForm.VIewModels;

namespace JobApplicationForm.Controllers
{
    [AllowAnonymous]
    public class JobController : Controller
    {
        private ApplicationDbContext context; 
        public JobController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }
        public ActionResult ListApplications()
        {
           
                return View("ListApplications");
            
        }
        [Authorize(Roles = variable.CanManageJobs)]
        public ActionResult DetailsApplication(int id)
        {
            var value = context.JobFormDb.Include(c => c.Position).SingleOrDefault(c => c.id == id); 
            if(value == null)
            {
                return HttpNotFound(); 
            }

            return View(value); 
        }
        // form  , edit , create , and then after delete 

        [Authorize(Roles = variable.CanManageJobs)]
        public ActionResult form()
        {
            var viewmodelJ = new JobPositionViewModel
            {               
                JobForm = new JobForm(), //To sort out the validation summary id error . 
                ListPosition = context.PositionDb.ToList()
            }; 
            return View("EntryForm",viewmodelJ); 
        }


        [Authorize(Roles = variable.CanManageJobs)]
        public ActionResult EditForm(int id)
        {
            var value = context.JobFormDb.SingleOrDefault(c => c.id == id); 
            if(value == null)
            {
                return HttpNotFound(); 
            }
            var viewmodelJ = new JobPositionViewModel
            {
                JobForm = value,
                ListPosition = context.PositionDb.ToList()
            };
            return View("EntryForm",viewmodelJ);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = variable.CanManageJobs)]

        public ActionResult Save(JobForm jobform)
        {
            if (!ModelState.IsValid)
            {
                var viewmodelJ = new JobPositionViewModel
                {
                    JobForm = jobform,
                    ListPosition = context.PositionDb.ToList()
                };
                return View("EntryForm", viewmodelJ);
            }
            if(jobform.id == 0)
            {
                jobform.dateSubmited = DateTime.Now;
                context.JobFormDb.Add(jobform); 
            }
            else
            {
                var value = context.JobFormDb.Single(c => c.id == jobform.id);

                 value.id = jobform.id;
                 value.personName = jobform.personName;
                 value.address = jobform.address;
                 value.anyDisabilities = jobform.anyDisabilities;
                value.dateSubmited = jobform.dateSubmited; 
                 value.phoneNumber = jobform.phoneNumber; 
                 value.PositionId = jobform.PositionId; 
            }
            context.SaveChanges(); 

            return RedirectToAction("ListApplications", "Job"); 
        }
    }
}