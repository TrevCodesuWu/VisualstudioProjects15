using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace GymManagement.Models
{
    public class UserProfile
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Username")]
        [Required]
        public string name { get; set; }
        [Required]
        [Display(Name ="Age")]
        public int age { get; set; }
        //Navigation Property
        public Gender gender { get; set; }
        //Foreign Key
        [Display(Name ="Gender")]
        public int genderId { get; set; }

    }
}