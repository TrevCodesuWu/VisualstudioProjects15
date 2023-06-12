using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeGames.Models
{
    public class person
    {
        public int id { get; set; }
        public string name { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }

    }
}