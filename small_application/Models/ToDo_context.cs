using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions; 

namespace small_application.Models
{
    public class ToDo_context :DbContext 
    {

        public ToDo_context() : base("tododatabase")
        {
          
        }
        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
            // Fluent API for the Person Model -Entity configuration and Property Configuration 
            modelBuilder.Entity<Person>().HasKey(e => e.Id)
                                         .Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Person>().Property(e => e.Name).IsRequired()
                                                               .HasMaxLength(25)
                                                               .HasColumnName("Person Name");
            modelBuilder.Entity<Person>().Property(e => e.Thing_to_do).IsRequired()
                                                                    .HasColumnName("Important Things")
                                                                    .HasMaxLength(80); 

        }
    }
}