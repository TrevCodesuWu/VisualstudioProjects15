using System;
using System.IO;
using System.Net;

namespace LearningCsharpLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Car car = new Car();
            car.name = "Audi R8";
            car.brand = "Audi";
            car.price = 36000000; 
            car.model = "R8";
            car.rating = 'S';
            car.carDescription = "This is a very well rounded coupe for those who like high speed performance and endurance.";
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.AddDays(1).ToLongDateString()); 
            Console.WriteLine(dt.ToLongDateString()); 
         // Console.WriteLine("Car Name : {0}\n" +"Car price : {1:C}\n" +"Car Rating : \'{2}\' class", car.name,car.price,car.rating);
            Console.ReadLine(); 
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("The value of i is" + i); 
            } */

            string text;
            WebClient webclient = new WebClient();
            text = webclient.DownloadString("https://www.youtube.com/watch?v=bpHk9MZhX6E");
            string randomtextadded = "\nhoe";
            text += randomtextadded; 
            File.WriteAllText(@"C:\Lesson17\Write.txt", text);
            Console.WriteLine("Done!" + "\nPress ENTER to continue");

            Console.ReadLine(); 
            /*
            program programObj = new program();
            programObj.address = "21 magnolia crescent";
            programObj.surname = "Naicker";
            programObj.name = "Trevlin";
            programObj.age = 22;
            string message = programObj.giveName(programObj.name);
            Console.WriteLine(message); 
           // Console.WriteLine(programObj.name); 
            Console.ReadLine(); 

            /*double numberOne = 21.05; 
            string myString = string.Format("{2:C}", 12.50,"Hello", numberOne); 


            int tries = 0;
            while (Ran() != 7)
            {
                tries++;
                Console.WriteLine("Wrong number! Your number is \"" + Ran() + "\"");
            }

            Console.WriteLine("Congrats , you picked right number " +
                "which took you " + tries + " number of tries {" + Ran());



            Console.ReadLine(); */ 


        }
        private static int Ran()
        {
            Random random = new Random();
            int randomN = random.Next(1, 11);

            return randomN;
        }

    }
    public class program {
        public  string name;
        public string surname;
        public int age;
         public string address;

        public void methodOne()
        {
            Console.WriteLine("This is a method in the class program with a small letter starting with"); 
            
        }
        public string giveName(string name1)
        {
            string addon = "This is your name : "; 
            return addon + name1; 
        }
    }
}
