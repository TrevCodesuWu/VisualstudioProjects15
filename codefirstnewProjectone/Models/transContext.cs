using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
namespace codefirstnewProjectone.Models
{
    public class transContext :DbContext
    {     //Contructor is created to give the database a name 
        public transContext() : base("dataDb")
        {

        }
        // Creating objects of the tables , names we use to refer to the actual table 
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Tblitem> Tblitems { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<transaction> transactions { get; set; }
    }
}