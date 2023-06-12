using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Http; // needed  
using System.Web.Routing; // needed 

using AutoMapper; //mapping profile 
using Migrations_EF.App_Start; // mapping profile

namespace Migrations_EF
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<mappingProfile>()); // mapping profile
            Mapper.Initialize(c => c.AddProfile<mappingProfilem>()); 

            GlobalConfiguration.Configure(WebApiConfig.Register); // for the api

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
