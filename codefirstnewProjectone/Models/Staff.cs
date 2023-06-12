using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace codefirstnewProjectone.Models
{
    public class Staff
    {
        [Key]
        [Display(Name ="Staff Id :")]
        public string staff_id { get; set; }
        [Display(Name = "Staff Name :")]
        public string staff_name { get; set; }
        [Display(Name = "Surname :")]
        public string surname { get; set; }
        [Display(Name = "Staff Age :")]
        public int staff_age { get; set; }
        [Display(Name = "Staff Points :")]
        public int staff_points { get; set; }

    }
}