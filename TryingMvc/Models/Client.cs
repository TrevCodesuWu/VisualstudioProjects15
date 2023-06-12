using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TryingMvc.Models
{
    public class Client
    {
        [Key]
        [Range(100000, 999999, ErrorMessage = "Enter a valid number")]
        [Required(ErrorMessage = "Enter a valid account number")]
        [Display(Name = "Person Id :")]
        public int personId { get; set; }

        [Required(ErrorMessage = "Enter your first name")]
        [Display(Name = "First Name :")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        [Display(Name = "Last Name :")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Enter your age")]
        [Display(Name = "Age :")]

        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter a valid email address")]
        [Display(Name = "Email Address :")]
        public string emailAddress { get; set; }
        
        [Display(Name = "Password :")]
        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Confirm Password :")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Passwords do not match ")]
        public string confirmPassword { get; set; }
    }
}