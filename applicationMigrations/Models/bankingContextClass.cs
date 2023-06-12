using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace applicationMigrations.Models
{
    public class bankingContextClass:DbContext
    { 
        public bankingContextClass():base("newData")
        {

        }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<borrow> borrows { get; set; } 
    }
}