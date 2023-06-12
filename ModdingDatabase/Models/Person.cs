using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace ModdingDatabase.Models
{
    public class Person

    {
        [Key]
        public string person_id { get; set; }
        [Required]

        public string name { get; set; }
        [Required]
        public int age { get; set; }
        public int? luckynum { get; set; }
        public DateTime? birth { get; set; }



    }
}