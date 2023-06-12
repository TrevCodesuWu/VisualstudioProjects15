using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeGames.Models
{
    public class Game
    {
        [Key]
        public int game_id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage ="Name is a required field")]
        [Display(Name ="Name")]
        public string game_name { get; set; }

        [Display(Name ="Cost")]
        public double price { get; set; }

        [Display(Name ="Rating Score")]
        [Range(1, 10)]
        public int rated { get; set; }

        [Display(Name ="Release Date")]
        [Over18] //Custom Data annotation 1. add a class 2. derive it from ValidateAttribute(add namespace) 3. cast the validationcontext to the model and store it in another variable 4.continue 
        public DateTime? release_date { get; set; }


        //The nav prop
        public Genre Genre { get; set; }

        [Display(Name ="Genre Types")]
        public int GenreId { get; set; }

        

    }
}