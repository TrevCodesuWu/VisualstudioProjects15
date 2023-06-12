using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace JobApplicationForm.Models
{
    public class JobForm
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Name")]
        [Required]
        public string personName { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string address { get; set; }

        [Display(Name = "Telephone")]
        [Required]
        public string phoneNumber { get; set; }

        [Display(Name = "Has Disability")]
    //    [AgeRestriction] // Class for the custom data annotation 
        public Boolean anyDisabilities { get; set; } // add a thing where it limits if you are disabled custom data ann

        public DateTime? dateSubmited { get; set; }

        //nav prop
        public Position Position { get; set; }

        [Display(Name = "Position")]
        public int PositionId { get; set; }


    }
}