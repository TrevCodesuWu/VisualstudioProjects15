using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobApplicationForm.Models
{
    public class AgeRestriction : ValidationAttribute // Custom Data Annotation 
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var job = (JobForm)validationContext.ObjectInstance;

            if(job.PositionId == 0 || job.PositionId == 1)
            {
                return ValidationResult.Success; 
            }
            if(job.anyDisabilities == false)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("People with disabilities cannot apply for any position other than employee"); 

        }
    }
}