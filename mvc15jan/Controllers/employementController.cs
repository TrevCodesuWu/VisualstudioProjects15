using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc15jan.Models;
using mvc15jan.ViewModels; 

namespace mvc15jan.Controllers
{
    public class employementController : Controller
    {
        // GET: employement
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult bothcombined()
        {
            Person person = new Person();
            person.id_number = "0009235176089"; 
            person.name_person = "Jeremiah";
            person.Gender = 'M';

            Employement employement = new Employement();
            employement.job_name = "construction";
            employement.work_hours = "3hrs";
            employement.estimated_pay = 3000.00;

            employeePerson emp = new employeePerson();
            emp.person = person;
            emp.employement = employement; 

            return View(emp); 
        }
    }
}