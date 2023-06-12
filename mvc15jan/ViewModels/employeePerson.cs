using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc15jan.Models; 
namespace mvc15jan.ViewModels
{
    public class employeePerson
    { 
        public Person person { get; set; }
        public Employement employement { get; set; }

    }
}