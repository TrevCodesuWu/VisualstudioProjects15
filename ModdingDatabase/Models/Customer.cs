using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace ModdingDatabase.Models
{
    public class Customer
    {
       
        [Key]
        public int cust_id { get; set; }
        [Required]
        [StringLength(30)]
        public string cust_name { get; set; }
        public bool is_subbed_newsletter { get; set; }
        public int? age { get; set; }
        public int? guessdeath { get; set; }

    
    }
}