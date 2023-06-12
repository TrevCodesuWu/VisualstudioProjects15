using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace displaylistofcust.Models
{
    public class MembershipTypes
    {
        public int Id { get; set; }
        public int signupfee { get; set; }
        public int durationInMonths { get; set; }
        public int discount { get; set; } 

    }
}