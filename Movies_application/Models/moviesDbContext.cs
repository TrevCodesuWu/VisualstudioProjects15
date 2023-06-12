using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace Movies_application.Models
{
    public class moviesDbContext: DbContext
    {
        public moviesDbContext() : base("moviesdatabase")
        {

        }
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<Movie> movies { get; set; }

    }
}