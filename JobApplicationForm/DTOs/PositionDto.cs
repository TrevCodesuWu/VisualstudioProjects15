using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobApplicationForm.DTOs
{
    public class PositionDto
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string position { get; set; }
        public double pay { get; set; }
        public int durationMonths { get; set; }
    }
}