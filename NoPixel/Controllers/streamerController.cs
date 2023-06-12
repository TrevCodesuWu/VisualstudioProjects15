using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NoPixel.Models; 

namespace NoPixel.Controllers
{
    public class streamerController : Controller
    {
        private ApplicationDbContext _context; // creating an instance of the dbcontext 
        public streamerController()
        {
            _context = new ApplicationDbContext();  //using the constructor to initialize the new dbcontext 
        }
        protected override void Dispose(bool disposing) //disposing all the shit first 
        {
            _context.Dispose(); 
        }
        public ActionResult listofstreamer()
        {
            var Streamerlist = _context.streamer; 

            return View(Streamerlist);
        }
        public ActionResult Details(int id)
        {
            var spec_streamer = _context.streamer.SingleOrDefault(s => s.streamer_id == id);
            if(spec_streamer == null)
            {
                return RedirectToAction("streamerIdNotFound"); 
            }
            return View(spec_streamer); 
        }
        public ActionResult streamerIdNotFound()
        {
            return View(); 
        }
    }
}