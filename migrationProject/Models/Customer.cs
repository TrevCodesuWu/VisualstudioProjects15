using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace migrationProject.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool issubscribedtonewsletter { get; set; }
        public bool isCool { get; set; }

    }
}