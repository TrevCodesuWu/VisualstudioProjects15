using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_machine
{
    class Car
    {
        public string car_id { get; set; }
        public string car_name { get; set; }
        public string car_brand { get; set; }
        public double car_price { get; set; }
        public string car_desc { get; set; }


        public Car(string car_id,string car_name, string car_brand, double car_price, string car_desc)
        {
            this.car_id = car_id; 
            this.car_name = car_name;
            this.car_brand = car_brand;
            this.car_price = car_price;
            this.car_desc = car_desc;
        }
    }
}
