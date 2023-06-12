using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarShop.Models; 

namespace CarShop.ViewModels
{
    public class carClassViewModel
    {
        public Car Car { get; set; }
        public List<Class> Class { get; set; }

    }
}