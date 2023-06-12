using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace movie_rental_system.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }

        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Customer name is required ")]
        public string customer_name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address ")]
        public string address { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Display(Name = "Mobile Number ")]
        [DataType(DataType.PhoneNumber)]
        public int mobile_num { get; set; }
    }
}