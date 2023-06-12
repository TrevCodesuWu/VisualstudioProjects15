using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace application_fluent_api.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Size { get; set; }

        //navigation properties 
        public virtual ICollection<Employee> Employees { get; set; }
    }
}