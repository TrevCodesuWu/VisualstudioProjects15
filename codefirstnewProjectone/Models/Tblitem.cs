using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace codefirstnewProjectone.Models
{
    public class Tblitem
    {
        [Key]
        public string item_id { get; set; }
        public string item_desc { get; set; }
        public int Cat_id { get; set; }
        public virtual Category Category { get; set; }
        public string item_size { get; set; }
        public double item_cost { get; set; }
        public double vat { get; set; }
        public double selling { get; set; }

        public double calcVat()
        { var ansV = item_cost * 0.15;
            return ansV;
        }
        public double calcSelling()
        {
            var ansS = item_cost + calcVat();
            return ansS; 
        }
    }
}