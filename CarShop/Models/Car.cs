using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace CarShop.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string name { get; set; }
        [Required]
        [Display(Name ="Model")]
        public string model { get; set; }
        [Display(Name = "Price")]
        public double price { get; set; }
        [Display(Name = "Has sunroof")]
        public Boolean sunroof { get; set; }
        [Display(Name = "Release Date")]
        public DateTime? released { get; set; }

        //nav prop
        public Class Class { get; set; }
        [Display(Name = "Class")]
        public int ClassId { get; set; }

    }
}