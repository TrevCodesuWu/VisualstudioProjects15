using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace movie_rental_system.Models
{
    public class Movie
    {
        [Key]

        [Display(Name = "Movie Id ")]
        public int movie_id { get; set; }
        [Display(Name = "Movie Name ")]
        [Required(ErrorMessage = "Movie name is required")]
        public string movie_name { get; set; }
        [Required(ErrorMessage = "Movie duration is required")]
        [Display(Name = "Movie Duration ")]
        public string movie_duration { get; set; }
        [Required(ErrorMessage = "Age is required for movie")]
        [Display(Name = "Movie Rated ")]
        public string movie_age_restriction { get; set; }
        [Required(ErrorMessage = "movie price is required")]
        [Display(Name ="Movie Price ")]
        public double movie_price { get; set; }
        [Required(ErrorMessage = "Movie accessibility is required ")]

        [Display(Name = "Movie Availability ")]
        public bool movie_available { get; set; }

    }
}