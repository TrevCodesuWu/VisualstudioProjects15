using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc14jan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); 
            /*
            routes.MapRoute(
                "ReleaseByDate",
                "Cars/chill/{year}/{month}/{day}",
                 new { controller = "Cars", action = "chill" },
                 new { year = @"\d{4}",month =@"\d{2}" , day=@"\d{2}" });  
            routes.MapRoute(
                "mappingroute",
                "Cars/good/{idnumber}/{age}",
                new { controller = "Cars", action = "good" },
                new { idnumber = @"\d{5}", age = @"\d{2}" });  */ 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
