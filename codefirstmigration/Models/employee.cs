using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace codefirstmigration.Models
{
    public class employee
    {
        [Key]
        public string emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_job_desc { get; set; }
        public string emp_salary { get; set; }

    }
}