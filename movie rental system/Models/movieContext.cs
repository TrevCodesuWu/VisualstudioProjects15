using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
namespace movie_rental_system.Models
{
    public class movieContext :DbContext
    {
        public movieContext() : base("movieDatabase")
        {

        }
        public virtual DbSet<Movie> movies { get; set; }
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<Rent> rents { get; set; }
        
        public virtual DbSet<returning> returnings { get; set; }
    }  
}