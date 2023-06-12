using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace CarShop.Models
{
    public class Class
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(1)]
        public string car_class { get; set; }
    }
}