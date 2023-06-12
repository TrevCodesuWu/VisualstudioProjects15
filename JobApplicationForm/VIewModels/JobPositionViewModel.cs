using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobApplicationForm.Models; 

namespace JobApplicationForm.VIewModels
{
    public class JobPositionViewModel
    {
        public JobForm JobForm { get; set; }
        public List<Position> ListPosition { get; set; }

    }
}