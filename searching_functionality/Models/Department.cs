using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace searching_functionality.Models
{
    public class Department
    {
        [Key]
        public string depart_name { get; set; }

    }
}