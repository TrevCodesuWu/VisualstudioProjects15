using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace application_fluent_api.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjName { get; set; }
        public string ProgLanguage { get; set; }
        public string Database { get; set; }

        //navigation properties 
        public virtual ICollection<Employee> Employees { get; set; } 
    }
}