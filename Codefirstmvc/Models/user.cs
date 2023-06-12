using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Codefirstmvc.Models
{
    public class user
    {   
        public string user_name { get; set; }
        [Key] 
        public string user_id { get; set; }
        public string user_address { get; set; }
        public bool user_alive { get; set; }

    }
}