using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticeGames.Models; 

namespace PracticeGames.ViewModels
{
    public class GenGameViewModel
    {
        public IEnumerable<Genre> GenreList { get; set; }
        public Game game { get; set; }

    }
}