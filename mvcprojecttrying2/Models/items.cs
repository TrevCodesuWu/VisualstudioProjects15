using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcprojecttrying2.Models
{
    public class items
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public double answer { get; set; }

        public double calcSum()
        {
            return number1 + number2;
        }


    }

}