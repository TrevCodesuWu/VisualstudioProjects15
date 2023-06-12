using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Migrations_EF.Models
{
    public class MembershipTypes
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public int durationInMonths { get; set; }
        public int discount { get; set; }
        public int signupfee { get; set; }
        
    }
}