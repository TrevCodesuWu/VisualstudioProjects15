using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TryingMvc.Models
{
    public class clientContext :DbContext
    {
        public clientContext() : base("clientdatabase")
        {

        }
        public virtual DbSet<Client> Clients { get; set; } 
    }
    
}