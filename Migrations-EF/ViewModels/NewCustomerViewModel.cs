using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Migrations_EF.Models; 

namespace Migrations_EF.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipTypes> memlist { get; set; }
        public Customer customer { get; set; }

    }
}