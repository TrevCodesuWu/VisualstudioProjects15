using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc15jan.Models; 
namespace mvc15jan.ViewModels
{
    public class customerMovie
    {
        public movies movie { get; set; }
        public Tickets ticket { get; set; }
        public List<customers> customer { get; set; }

    }
}