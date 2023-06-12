using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarShop.DTOs
{
    public class CarDTO
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string model { get; set; }
        public double price { get; set; }
        public Boolean sunroof { get; set; }
        public DateTime? released { get; set; }

        //Check whether the name of the MembershiptypeDto property name in CustomerDto is same as the one in MembershipType model. Because you are trying to map same property names with AutoMapper. In my case that was the problem.
        public ClassDto Class { get; set; } 
        public int ClassId { get; set; }
    }
}