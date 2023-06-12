using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Migrations_EF.Models;
using System.Data.Entity;
using Migrations_EF.ViewModels;
using System.Data.Entity.Validation;

namespace Migrations_EF.Controllers
{
    public class moviesController : Controller
    {
        private ApplicationDbContext context;

        public moviesController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }
        // Created and instance of the db context and disposed all the shit 
        
        public ActionResult listofmovies()
        {
            var listM = context.Movies.Include(m => m.Genre).ToList();
             
            return View(listM); 
        }
        public ActionResult InfoMovie(int id)
        {
            var value = context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.movie_id == id); 
            if(value == null)
            {
                return RedirectToAction("notFound"); 
            }
            return View(value); 
        }
        public ActionResult notFound()
        {
            return View(); 
        }
        public ActionResult formData()
        {
            NewMovieViewModel Mviewmodel = new NewMovieViewModel
            {
                GenreList = context.Genre.ToList()
            };
            return View("MovieForm",Mviewmodel); 
        }
        [HttpPost]
        public ActionResult Save(Movie Movie)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new NewMovieViewModel
                {
                    Movie = Movie,
                    GenreList = context.Genre.ToList()
                };
                return View("MovieForm", viewmodel); 
            }
            if(Movie.movie_id == 0)
            {
                context.Movies.Add(Movie);
            }
            else
            {
                var valuefromdb = context.Movies.Single(c => c.movie_id == Movie.movie_id);

                valuefromdb.movie_id = Movie.movie_id;
                valuefromdb.movie_name = Movie.movie_name;
                valuefromdb.release_date = Movie.release_date;
                valuefromdb.duration_min = Movie.duration_min;
                valuefromdb.Genre_id = Movie.Genre_id;
                valuefromdb.left_stock = Movie.left_stock; 
            }
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e); 
            }
            

            return RedirectToAction("listofmovies", "movies"); 
        }
        public ActionResult Edit(int id)
        {
            var valuefromdb = context.Movies.SingleOrDefault(c => c.movie_id == id);

            NewMovieViewModel viewmodel = new NewMovieViewModel()
            {
                GenreList = context.Genre.ToList(),
                Movie = valuefromdb
            }; 
            return View("MovieForm",viewmodel); 
        }
    }
}