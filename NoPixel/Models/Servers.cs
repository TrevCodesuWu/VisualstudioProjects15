using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace NoPixel.Models
{
    public class Servers
    {
        [Key]
        
        public int Id { get; set; }
        public string server_name { get; set; }
        public string server_location { get; set; }
        public int server_player_count { get; set; }
        public double server_gross_income { get; set; }


    }
}