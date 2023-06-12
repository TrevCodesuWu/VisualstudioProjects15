using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ORMwithSql.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter a value")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter a value")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter a value")]
        [Display(Name = "City")]
        public string City { get; set; }
        public string available { get; set; } 

    }
    public class empContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}