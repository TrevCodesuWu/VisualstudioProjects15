using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity; 
using System.Web;
using System.ComponentModel.DataAnnotations.Schema; 

namespace application_fluent_api.Models
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext() :base("Name=Constr")
        {

        }
        public virtual DbSet<Department> Departments { get; set; } 
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual  DbSet<Project> Projects { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        //Using Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //Entity Configuration -ToTable
            modelBuilder.Entity<Department>().ToTable("Dept");
            //Entity Configuration -HasKey
            modelBuilder.Entity<Department>().HasKey(d => d.DeptId);
            modelBuilder.Entity<Department>().Property(p => p.DeptName).HasColumnName("Department Name :"); 

            //Property Configuration "EMPLOYEE" entity 
            modelBuilder.Entity<Employee>().Property(e => e.EmployeeId).IsRequired()
                                                                       .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Employee>().Property(e => e.EmpName).HasMaxLength(50)
                                                                  .HasColumnType("varchar")
                                                                  .IsRequired()
                                                                  .HasColumnName("Ename");

            modelBuilder.Entity<Employee>().Property(e => e.PrimaryContact).IsRequired()
                                                                           .HasMaxLength(10);
            modelBuilder.Entity<EmployeeAddress>().HasKey(e => e.EmployeeId);

            //one-to-one relationship between Employee and EmployeeAddress
            modelBuilder.Entity<Employee>().HasOptional(e => e.EmployeeAddress)
                                           .WithRequired(a => a.Employee);

            //one-to-many relationship between department and employee
            modelBuilder.Entity<Department>().HasMany(d => d.Employees)
                                             .WithRequired(e => e.Department)
                                             .HasForeignKey(d => d.DeptId);

            //one-to-many relationship between team and employee 
            //foreign key is nullable use 'WithOptional' otherwise use 'WithRequired' like the one above
            
            modelBuilder.Entity<Team>().HasMany(e => e.Employees)
                                       .WithOptional(t => t.Team)
                                       .HasForeignKey(f => f.TeamId);

            //many-to-many relationships between employees and projects 
            modelBuilder.Entity<Employee>().HasMany(e => e.Projects)
                                        .WithMany(m => m.Employees)
                                        .Map(ep =>
                                        {
                                            ep.MapLeftKey("EmployeeID");
                                            ep.MapRightKey("ProjectID");
                                            ep.ToTable("ProjectOfEmployees"); 
                                        }); 
        }

    }
}