using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace codefirstmigration.Models
{
    public class customer
    {
        [Key]
        public string cust_id { get; set; }
        public string cust_name { get; set; }
        public string cust_address { get; set; }
        public double cust_tax { get; set; } 
        public double cust_salary { get; set; }
        public double cust_salary_after { get; set; }

        public double calc_tax()
        {
            return cust_salary * 0.15;
        }
        public double calc_total()
        {
            return cust_salary - calc_tax();
        }

    }
}