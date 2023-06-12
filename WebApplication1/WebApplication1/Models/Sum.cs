using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication1.Models
{
    public class Sum
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double Answer { get; set; }
        public double CalcSum()
        {
            return num1 + num2;
        }
    }
   
}