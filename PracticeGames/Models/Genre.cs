using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace PracticeGames.Models
{
    public class Genre
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }

    }
}