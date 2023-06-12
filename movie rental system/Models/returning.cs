using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace movie_rental_system.Models
{
    public class returning
    {
        [Key]
        public int returning_id { get; set; }
        public int rent_id { get; set; }
      
        public virtual Rent Rent { get; set; }
         
        
        public bool late_fee { get; set; }

        public double actual_fee { get; set; }

     
    }

}