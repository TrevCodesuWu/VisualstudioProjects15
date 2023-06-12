using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Movies_application.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int customer_id { get; set; }

        [Display(Name = "Customer Name")]
        public string customer_name { get; set; }
        [Display(Name = "Address ")]
        public string address { get; set; }
        [Display(Name = "Mobile Number ")]
        public int mobile_num { get; set; }

    }
}