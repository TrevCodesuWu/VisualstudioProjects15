using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace PracticeGames.Models
{
    public class Over18 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var game = (Game)validationContext.ObjectInstance;

            if (game.GenreId == 0 || game.GenreId == 1 || game.GenreId == 2 || game.GenreId == 3 || game.GenreId == 4 )
                return ValidationResult.Success;

            if (game.release_date == null)
                return new ValidationResult("Release Date is required");
            //going on a break the shit works with 2 OR statements but not with 5 . sort that out . 
            var age = DateTime.Today.Year - game.release_date.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Should be over 18");
            
        }
    }
}