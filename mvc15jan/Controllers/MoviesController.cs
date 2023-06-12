using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc15jan.Models; 
using mvc15jan.ViewModels; 

namespace mvc15jan.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getcustlistandmovie()
        {//first you are naming the namespace to get access to the model then when you finish add the values then 
            // you do the viewmodel class you added and assign the values to that so it can be passed in one 
            var moviez = new movies(); // you can use var or the actual blueprint 'movies'
            moviez.movie_id = "323222";
            moviez.movie_name = "camelot";

            Tickets tick = new Tickets();
            tick.ticket_name = "concert";
            tick.ticket_price = 250; 

            List<customers> custz = new List<customers>();
            custz.Add(new customers { customer_id = "11212", customer_name = "inthatclub" });
            custz.Add(new customers { customer_id = "55543", customer_name = "jussse" });
            custz.Add(new customers { customer_id = "11213", customer_name = "character" });
            custz.Add(new customers { customer_id = "89929", customer_name = "esason" });

            customerMovie cusmovie = new customerMovie(); // object of the viewmodel and assigning its values to the movie and customer list 
            cusmovie.movie = moviez;
            cusmovie.customer = custz;
            cusmovie.ticket = tick; 

            // View models are used to transfer more than one class in a view 
            return View(cusmovie); 
        }
    }
}