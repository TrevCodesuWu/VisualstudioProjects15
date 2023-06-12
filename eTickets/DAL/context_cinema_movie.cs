using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace eTickets.Models
{
    public class context_cinema_movie : DbContext
    {
        public context_cinema_movie() : base("datamovie")
        {

        }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
    }
}