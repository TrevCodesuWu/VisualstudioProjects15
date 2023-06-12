using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc14jan.Models
{
    public class Car
    {
        [Key]
        public string car_id { get; set; }
        public string car_name { get; set; }
        public string car_brand { get; set; }
        public int car_price { get; set; }

        public string car_desc { get; set; }

    }
}