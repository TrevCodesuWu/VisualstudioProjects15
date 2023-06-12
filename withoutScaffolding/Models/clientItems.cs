using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace withoutScaffolding.Models
{
    public class clientItems
    {
        [Key]
        public int item_id { get; set; }
        public string item_name { get; set; }
        public string item_descr { get; set; }
        public int item_price { get; set; }
        public int item_vat { get; set; }
        public int item_selling { get; set; }
        public int item_markup { get; set; }
        public int item_total { get; set; }

    }
}