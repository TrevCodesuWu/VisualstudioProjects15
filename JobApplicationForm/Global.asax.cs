using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // api 
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper; // to use the mapper 
using JobApplicationForm.App_Start;

namespace JobApplicationForm
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<mappingProfile>()); // to use the automapper 

            GlobalConfiguration.Configure(WebApiConfig.Register); // to implement an API 

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
