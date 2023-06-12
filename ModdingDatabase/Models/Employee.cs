using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace ModdingDatabase.Models
{
    public class Employee
    {
        [Key]
        public int emp_id { get; set; }
        [Required]
        [StringLength(30)]
        public string emp_name { get; set; }
        public int? emp_age { get; set; }
        public string username { get; set; }


    }
}