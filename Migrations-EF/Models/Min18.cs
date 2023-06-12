using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Migrations_EF.Models
{
    public class Min18 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cust = (Customer)validationContext.ObjectInstance;
            
            if (cust.MembershipTypesId == 0 || cust.MembershipTypesId == 1)
            {
                return ValidationResult.Success;
            }
            if
            (cust.birthD == null)
            {
                return new ValidationResult("The birthdate field is required"); 
            }

            var age = DateTime.Today.Year - cust.birthD.Value.Year;
            if (age >= 18)
               {
                    return ValidationResult.Success;
                } else
                {
                    return new ValidationResult("You are under age , approx (" + age + ")");
                }
           
            
        }
    }
}