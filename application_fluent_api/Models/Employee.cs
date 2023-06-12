using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace application_fluent_api.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public string Email { get; set; }
        public string PrimaryContact { get; set; }
        public string SecondaryContact { get; set; }
        //Foreign Keys
        public int DeptId { get; set; }
        // ? means it can be nullable 
        public int? TeamId { get; set; } 

        // navigation properties
        public virtual EmployeeAddress EmployeeAddress { get; set; }
        public virtual Team Team { get; set; }
        public virtual Department Department { get; set; } 
        public virtual ICollection<Project> Projects { get; set; } 
    }
}