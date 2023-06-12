using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
namespace searching_functionality.Models
{
    public class empContext : DbContext
    {
        public empContext() : base("databaseEmployer")
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; } 

    }
}