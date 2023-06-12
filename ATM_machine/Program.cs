using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_machine
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car mycar = new Car("0019","M3", "BMW", 30000, "quick and fast");
            CardHolder cardholder = new CardHolder("Joshua", "Naidoo", "304848938493849384", 4949, 3949.44);

            List<Car> CarsDatabase = new List<Car>();
            CarsDatabase.Add(mycar);
            CarsDatabase.Add(new Car("0038","volkswagen", "Golf", 4838333, "loud and now slow"));
            CarsDatabase.Add(new Car("3333", "dsdf", "sdfsd", 344333, "nothing "));
            CarsDatabase.Add(new Car("9393", "dsdf", "asldfk", 394934, "good one")); 

           
            //Console.WriteLine("Enter the code to enter "); 
           // string carid = Console.ReadLine(); 
            
           // var carone = CarsDatabase.FirstOrDefault(c => c.car_id == carid);
            var neone = CarsDatabase.FirstOrDefault(c => c.car_name == "dsdf");
            foreach(var ee in neone)
            {
                Console.WriteLine(ee); 
            }
            /*
            if (carone == null)
            {
                Console.WriteLine("Nothing is found"); 
            } else
            {
                Console.WriteLine("Welcome in the application"); 
            } */ 
            
            Console.ReadLine(); 
        }
    }
}
