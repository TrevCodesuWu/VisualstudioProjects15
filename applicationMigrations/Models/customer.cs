using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace applicationMigrations.Models
{
    public class customer
    {
        [Key] 
        public int cust_Id { get; set; }
        public string cust_name { get; set; }
        public int cust_age { get; set; } 
        public string cust_address { get; set; }
        public bool cust_member { get; set; }

    }
}