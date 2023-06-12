using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrevlinNaicker_modelviewcontrollerapp.Models
{
    public class PersonModel
    {
        public string firstName { get; set; } 
        public string lastName { get; set; }
        public int Age { get; set; } = 0;
        public bool isAlive { get; set; } = true; 

    }
}