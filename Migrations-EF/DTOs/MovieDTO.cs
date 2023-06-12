using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Migrations_EF.DTOs
{
    public class MovieDTO
    {
        [Key]
        public int movie_id { get; set; }
        [Required]
        [StringLength(30)]
        public string movie_name { get; set; }
        
        public int duration_min { get; set; }
        
        public DateTime release_date { get; set; }
        
        public int left_stock { get; set; }
        
        public int Genre_id { get; set; }

    }
}