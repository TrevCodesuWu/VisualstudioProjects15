using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Migrations_EF.Models; 

namespace Migrations_EF.ViewModels
{
    public class NewMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> GenreList { get; set; }

    }
}