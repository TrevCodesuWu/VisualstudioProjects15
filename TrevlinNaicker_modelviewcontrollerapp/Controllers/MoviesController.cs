using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrevlinNaicker_modelviewcontrollerapp.Models;
 
namespace TrevlinNaicker_modelviewcontrollerapp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult MovieView()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { firstName = "Trevlin", lastName = "Naicker", Age = 21, isAlive = false }) ;
            people.Add(new PersonModel { firstName = "Jeremiah", lastName = "Naidoo", Age = 20, isAlive = true });
            people.Add(new PersonModel { firstName = "Joshua", lastName = "Naidoo", Age = 19, isAlive = false });
            people.Add(new PersonModel { firstName = "Shaolin", lastName = "Govender", Age = 16, isAlive = true });

            return View(people);
        }
    }
}