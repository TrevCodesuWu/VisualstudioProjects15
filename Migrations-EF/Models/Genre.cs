using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Migrations_EF.Models
{
    public class Genre
    {
        [Key]
        public int genre_id { get; set; }
        [Required]
        [StringLength(30)]
        public string genre_name { get; set; }

    }
}