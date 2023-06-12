using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace application_fluent_api.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string description { get; set; }


        //navigation properties 
        public virtual ICollection<Employee> Employees { get; set; } 
    }

}