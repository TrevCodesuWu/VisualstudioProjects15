using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace codefirstnewProjectone.Models
{
    public class transaction
    {
        [Key]
        public int Trans_no { get; set; }
        public string Staff_Id { get; set; }
        public virtual Staff Staff { get; set; }
        public string item_id { get; set; }
        public virtual Tblitem Tblitem { get; set; }
        public double Trans_amount { get; set; }

        //using a linq statement to calculate it
        public double pullSelling()
        {
            transContext db = new transContext();
            var t_amount = (from i in db.Tblitems
                            where i.item_id == item_id // first i.item_is the one in the Tblitems and the second one is the one in the transaction model
                            select i.selling).Single();

            return t_amount;
        }
        public double pullPoints()
        {
            transContext db = new transContext();
            var p_num = (from xo in db.Staffs
                         where xo.staff_id == Staff_Id
                         select xo.staff_points).Single();
            return p_num; 
        }
        public double calcFinal()
        {
            return pullSelling() - pullPoints(); 
        }
        public double calcPoints()
        {
            return pullSelling() / 1000; 
        }
        public void updPoints()
        {
            transContext db = new transContext();
            Staff points = new Staff();
            points = (from st in db.Staffs
                      where st.staff_id == Staff_Id
                      select st).FirstOrDefault(); 
        }
    }
}