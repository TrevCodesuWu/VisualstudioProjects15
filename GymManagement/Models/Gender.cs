using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymManagement.Models
{
    public class Gender
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Gender")]
        [Required]
        public string gender_name { get; set; }
    }
}