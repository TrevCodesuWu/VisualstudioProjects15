using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestuarantApplication.DTOs
{
    public class FoodDto
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string food_name { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public string country { get; set; }
        public string food_url { get; set; }
        //Foreign key
        public int CategoryId { get; set; }


    }
} // create another field that requires a picture 