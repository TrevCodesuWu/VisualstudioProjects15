using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Codefirstmvc.Models
{
    public class Movies
    {    
        [Key]
        public string movie_id { get; set; }
        public string movie_name { get; set; }
        public string movie_duration { get; set; }
        public string movie_pg { get; set;  }
        public bool movie_available { get; set; }

    }
}