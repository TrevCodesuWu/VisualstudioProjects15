using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; 
namespace searching_functionality.Models
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string depart_name { get; set; }
        public virtual Department Department { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string Emp_name { get; set; }
        [Required]
        [Display(Name = "Gender ")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Fathers Name")]
        public string F_name { get; set; }
        [Range(1,100)]
        [Display(Name ="Age")]
        public int age { get; set; }

    }
}