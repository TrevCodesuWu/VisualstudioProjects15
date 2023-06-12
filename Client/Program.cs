using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            carX car1 = new carX();
            car1.make = "1979";
            car1.model = "juicer";
            car1.VIN = "21KDL";

            carX car2 = new carX();
            car2.make = "1440";
            car2.model = "bigtoes";
            car2.VIN = "89JFO"; 

            Dictionary<string, carX> dict1 = new Dictionary<string, carX>();
            dict1.Add(car1.VIN, car1);
            dict1.Add(car2.VIN, car2);

            Console.WriteLine(dict1["21KDL"].make); 



            List<normalClass> class1 = new List<normalClass>()
            {
                new normalClass { age ="12" ,normalName = "Naicker" },
                new normalClass { age ="15" ,normalName = "Govender" }
        };
           /*  Console.WriteLine(class1[0].age);
            Console.WriteLine(class1[1].normalName); */ 
            normalClass normall = new normalClass();
            normall.age = "33";
            normall.normalName = "superman";

            normalClass anotherclass = new normalClass();
            anotherclass.age = "23";
            anotherclass.normalName = "Shaolin";

            uselessclass uselessclass1 = new uselessclass();
            uselessclass1.myAge = "3";
            uselessclass1.myName = "nobody"; 
            


            List<normalClass> cClass = new List<normalClass>();
            cClass.Add(normall);
            cClass.Add(anotherclass);
            /*
            Console.WriteLine(uselessclass1.Age(2000)); 
            Console.WriteLine(cClass[0].age);
            Console.WriteLine(cClass[1].normalName);  */ 

            /* 
            List<string> firstList = new List<string>();
            firstList.Add("Joshua");
            firstList.Add("Rakheel");
            firstList.Add("anotherName");
            foreach(string c in firstList)
            {
                Console.WriteLine(c);
            }
           firstList.Remove(firstList[2]);
            foreach (string c in firstList)
            {
                Console.WriteLine(c);
            }
            
              string[] names = { "Trevlin", "Kylan", "Jeremiah" };
              normalClass nc = new normalClass();
              string randomthing = nc.callmethod(names[1]);  

              Console.WriteLine(randomthing);  */
            Console.ReadLine(); 
        }
    }
    public class carX
    {
        public string make { get; set; }
        public string model { get; set; }
        public string VIN { get; set; } 
    }
    public class uselessclass
    {
        private string country { get; set; }
        public string myName;
        public string myAge; 

        public int Age(int born)
        {
            return getyearborn(born); 
        }
        private int getyearborn(int born)
        {
            int yearNow = 2022;
            return yearNow - born; 
        }
    }
    public class normalClass
    {
        private string personName = "Trevlin Naicker"; 
        public string normalName;
        public string age; 

        public string callmethod(string obj)
        {
            return welcomeMessage(obj); 
        }
        private string welcomeMessage(string name)
        {
            
            string s = "Welcome ";
            string e = "!";
            string d = " done by ";

            return s + name + e + d + personName; 
        }

       
    }
}
