using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace applicationMigrations.Models
{
    public class borrow
    {
        [Key]
        
         public int borrow_Id { get; set; }
        public string borrower_name { get; set; }
        public string borrower_age { get; set; }
        public string borrower_hometown { get; set; }
        public int cust_Id { get; set; }
        public customer customer { get; set; }
    }
}