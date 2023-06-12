using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarShop.DTOs
{
    public class ClassDto
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string car_class { get; set; }

    }
}