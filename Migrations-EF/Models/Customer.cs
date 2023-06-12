using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Migrations_EF.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Name")]
        public string name { get; set; }

        [Display(Name ="Is Subscribed To Newsletter?")]
        public bool isSubscribedToNewsLetter { get; set; }

        public MembershipTypes Membershiptypes { get; set; }

        [Display(Name ="Membership Types")]
        public int MembershipTypesId { get; set; }

        [Display(Name ="Date of Birth")]
    //    [Min18]
        public DateTime? birthD { get; set; }
        


    }
}

// You have to add the class as a DbSet in the IdentityModels class to create a table for it 
