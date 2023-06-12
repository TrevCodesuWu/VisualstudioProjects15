using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace RestuarantApplication.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name ="Category")]
        public string category_name { get; set; }
        
    }
}