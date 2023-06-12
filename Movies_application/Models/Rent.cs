using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Movies_application.Models
{
    public class Rent
    {
        [Key]
        public int rent_id { get; set; } 

        [Display(Name ="Retail Fee" )]
        public double retail_fee { get; set; }
        [Display(Name ="Start Date")]
        public DateTime start_date { get; set; }
        [Display(Name ="End Date")]
        public DateTime end_date { get; set; }

      
    }
}