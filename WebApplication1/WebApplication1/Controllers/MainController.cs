using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Calculate()
        {
            return View("Output");
        }
        public ActionResult Calculate(Sum sum)
        {
            sum.num1 = sum.num1;
            sum.num2 = sum.num2;
            sum.Answer = sum.CalcSum();


            return View("Output",sum);

        }
    }
}