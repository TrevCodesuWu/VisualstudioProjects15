using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace movie_rental_system.Models
{
    public class Rent
    {
        [Key]
        public int rent_id { get; set; }
        [Display(Name ="Movie ID")]
        public int movie_id { get; set; }
        public virtual Movie Movie { get; set; }
        [Display(Name ="Customer ID")]
        public int customer_id { get; set; }
        public virtual Customer Customer { get; set; }
       
        [Display(Name ="Rental fee ")]
        public double rental_fee { get; set; }
        [Display(Name ="Total vat incl.")]
        public double total_with_vat { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Borrowed Date ")]
        public Nullable<System.DateTime> start_date { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Return field is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name ="Return Deadline ")]
        public Nullable<System.DateTime> end_date { get; set; }

        public double pullPrice()
        { movieContext db = new movieContext();

            var p_amt = (from i in db.movies
                         where i.movie_id == movie_id
                         select i.movie_price).Single();
            return p_amt; 
        }
        public double vat()
        {
            return pullPrice() * 0.15; 

        }
        public double addedvatPrice()
        {
            return pullPrice() + vat(); 
        }

       public DateTime datenow()
        {
            var stringone = DateTime.Now;
            return stringone; 
        }
    }
}