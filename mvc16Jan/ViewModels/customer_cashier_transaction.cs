using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc16Jan.Models;

namespace mvc16Jan.ViewModels
{
    public class customer_cashier_transaction
    {
        public List<Customer> customer { get; set; }
        public List<Cashier> cashier { get; set; }

    }
}