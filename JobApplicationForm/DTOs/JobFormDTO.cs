using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using JobApplicationForm.Models;

namespace JobApplicationForm.DTOs
{
    public class JobFormDTO
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string personName { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string phoneNumber { get; set; }

   //     [AgeRestriction] // Class for the custom data annotation 
        public Boolean anyDisabilities { get; set; } // add a thing where it limits if you are disabled custom data ann

        public DateTime? dateSubmited { get; set; }

        public PositionDto Position { get; set; } 
        public int PositionId { get; set; }


    }
}