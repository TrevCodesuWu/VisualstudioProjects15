using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Migrations_EF.Models
{
    public class Movie
    {
        [Key]
        public int movie_id { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name ="Name")]
        public string movie_name { get; set; }
        [Display(Name ="Duration(min)")]
        public int duration_min { get; set; }
        [Display(Name ="Release Date")]
        public DateTime release_date { get; set; }
        [Display(Name ="Stock")]
        public int left_stock { get; set; }
        //nav prop
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        public int Genre_id { get; set; }


    }
}