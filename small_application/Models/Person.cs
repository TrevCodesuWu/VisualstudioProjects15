using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace small_application.Models
{
    public class Person
    {
       /* [Key]
        [Display(Name ="Person Id")] */
        public int Id { get; set; }
       /* [Required(ErrorMessage ="Name is required")]
        [StringLength(25)]
        [Display(Name="Person Name")] */
        public string Name { get; set; }
        /*[Required(ErrorMessage ="This field is required")]
        [StringLength(50)]
        [Display(Name ="Things to do")] */
        public string Thing_to_do { get; set; }

    }
}