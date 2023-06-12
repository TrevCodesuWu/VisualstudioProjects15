using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace displaylistofcust.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public MembershipTypes MembershipTypes { get; set; }
        public int MembershipTypesId { get; set; }

    }
}