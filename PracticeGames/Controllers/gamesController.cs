using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeGames.Models;
using System.Data.Entity;
using PracticeGames.ViewModels; 

namespace PracticeGames.Controllers
{
    public class gamesController : Controller
    {
        private ApplicationDbContext context; 
        public gamesController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose(); 
        }

        public ActionResult ListGames()
        {
            var gameslist = context.GamesDb.Include(c => c.Genre).ToList(); 
            // taking the list of games from the GamesDb
            //The include is so we can use the Genre fields inside the view 
            return View(gameslist);
        }
        public ActionResult GamesDetails(int id)
        {
            var value = context.GamesDb.Include(c=>c.Genre).SingleOrDefault(c => c.game_id == id); //checking if the gameDb has the id passed in the arguments
            //Getting a value with linq using the id passed in the arguments 
            if(value == null)
            {
                return HttpNotFound(); //if nothing was matched in then display this message
            }
            return View(value); 
        }
        public ActionResult New()
        {
            var gen = context.GenreDb.ToList();
            // making a list of genres from the db
            GenGameViewModel gengame = new GenGameViewModel()
            {
                game = new Game(),
                GenreList = gen     // giving the values of the GenreList the values of the GenreDb           
            }; 

            return View("GameForm",gengame); // going to the view that has the name of 'GameForm' 
        }

        [HttpPost] //Only for data that is being posted 
        public ActionResult Save(Game game) //Model binding , values from View 'GameForm'(ActionResult 'New') are taken and mapped to the instantiated object in the parameters
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new GenGameViewModel()
                {
                    game = game,
                    GenreList = context.GenreDb.ToList()
                };
         
                return View("GameForm", viewmodel); 
            }
            if(game.game_id == 0) // checking if its a new game or an existing one . default value for int (game_id) is 0
            {// This means that it was a new game adding 
                context.GamesDb.Add(game); //Adding the data in the database of the GamesDb
            }
            else
            { // This means that a old game that is being updated 
                var gamefromDb = context.GamesDb.Single(c => c.game_id == game.game_id); // Using linq to get the specific one so it can be updated in the db 
                gamefromDb.game_name = game.game_name;
                gamefromDb.price = game.price;
                gamefromDb.rated = game.rated;
                gamefromDb.release_date = game.release_date; 
                game.GenreId = game.GenreId; 

            }
            context.SaveChanges(); // Saving it because all is temporary if not saved 

            return RedirectToAction("ListGames","games"); 
            //redirected to the ActionResult 'ListGames' which is where the List of all the games are situated 
        }
        public ActionResult Edit(int id) 
        {
            var value = context.GamesDb.SingleOrDefault(c => c.game_id == id); 
            // Using linq to get a value from the db with a id that is passed from the parameters 
            if(value == null)
            {
                return HttpNotFound(); // if nothing found , then return this 
            }
            var viewmodel = new GenGameViewModel() //viewmodel is used to send more than one entity into the View 
            {
                game = value,
                GenreList = context.GenreDb.ToList()
            }; // Giving the values of a game to the viewmodel with a list of the genres

            return View("GameForm", viewmodel); // returning to the view named 'GameForm' with viewmodel which contains current shi
            
        }

    }
}