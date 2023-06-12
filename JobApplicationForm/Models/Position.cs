using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace JobApplicationForm.Models
{
    public class Position
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string position { get; set; }
        public double pay { get; set; }
        public int durationMonths { get; set; }


    }
}