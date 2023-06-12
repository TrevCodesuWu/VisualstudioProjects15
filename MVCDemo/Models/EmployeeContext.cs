using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
namespace MVCDemo.Models

{  //The purpose of this entity framework is to establish a connection to the database
    public class EmployeeContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; } 
    }
}