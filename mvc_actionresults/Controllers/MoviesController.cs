using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_actionresults.Models;
namespace mvc_actionresults.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movies movies = new Movies() { movie_name = "Aladin" };

            return View(movies);
        }

        [Route("Movies/ByReleaseDate/{year}/{month:regex(//d{4})")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}