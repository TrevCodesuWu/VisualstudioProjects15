using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Codefirstmvc.Models
{
    public class userContext : DbContext
    {
        public userContext() : base("Dbone")
        {

        }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<Movies> movie { get; set; } 

    }
}