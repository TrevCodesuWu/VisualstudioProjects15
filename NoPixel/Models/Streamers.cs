using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace NoPixel.Models
{
    public class Streamers
    {
        [Key]
        public int streamer_id { get; set; }
        public string streamer_name { get; set; }
        public string streamer_username { get; set; }
        public string streamer_content { get; set; }
        public double streamer_avg_viewers { get; set; }

        public Servers Servers { get; set; }
        public int ServersId { get; set; }

    }
}