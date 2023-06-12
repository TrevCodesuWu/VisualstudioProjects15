using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movies_application.Models
{
    public class Movie
    {
        [Key]
        [Display(Name ="Movie Id ")]
        public int movie_id { get; set; }
        [Display(Name ="Movie Name ")]
        public string movie_name { get; set; }
        [Display(Name ="Movie Duration ")]
        public string movie_duration { get; set; }
        [Display(Name ="Movie Rated ")]
        public string movie_age_restriction { get; set; }
        [Display(Name ="Movie Availability ")]
        public bool movie_available { get; set; }

    }
}