using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace withoutScaffolding.Models
{
    public class clientContext : DbContext
    {
        public clientContext() : base ("ItDb")
        {

        }
        public virtual DbSet<clientItems> clients { get; set; }
    }
}