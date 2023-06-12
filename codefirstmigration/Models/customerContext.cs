using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
namespace codefirstmigration.Models
{
    public class customerContext : DbContext
    {
        public customerContext() : base("databaseCust")
        {

        }
        public virtual DbSet<customer> customers { get; set; } 
        public virtual DbSet<employee> employees { get; set; }
    }
}