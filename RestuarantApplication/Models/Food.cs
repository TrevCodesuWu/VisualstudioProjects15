using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestuarantApplication.Models
{
    public class Food
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Food")]
        [Required]
        public string food_name { get; set; }
        [Display(Name = "Price")]
        [Required]
        public double price { get; set; }
        [Display(Name = "Country")]
        [Required]
        public string country { get; set; }
        [Display(Name ="Food URL")]
        public string food_url { get; set; }


        //navigation property
        public Category category { get; set; }
        [Display(Name ="Category")]
        //Foreign key
        public int CategoryId { get; set; }
        

    }
}