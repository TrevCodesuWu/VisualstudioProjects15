using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestuarantApplication.Models; 

namespace RestuarantApplication.ViewModels
{
    public class FoodCategoryViewModel
    {
        public Food foodvm { get; set; }
        public IEnumerable<Category> categoryvm { get; set; }

    }
}