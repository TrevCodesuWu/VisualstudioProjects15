using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymManagement.Controllers
{
    public class GymController : Controller
    {
        // GET: Gym
        public ActionResult Home()
        {
            return View();
        }
    }
}