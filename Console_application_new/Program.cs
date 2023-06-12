using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_application_new
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your name?");
            Console.Write("Type your name : "); 
            string myFirstName = Console.ReadLine();

            Console.WriteLine("What is your surname?");
            Console.Write("Type in your last name : "); 
            string myLastName = Console.ReadLine();
           
            Console.WriteLine("Hello"+" " + myFirstName +" "+myLastName+", nice to meet you!");
            Console.ReadLine(); */
            //ReadLine can be used to get user input -pauses the application for the user to enter something
            /* Console.Write("Enter a value from 1 to 3 :");
            string userValue = Console.ReadLine();

            string Value = "3"; 
            string message = (userValue == Value) ? "cow" : "nothing";
            Console.Write("You picked the number {0} so you win {1}", userValue, message); 
            Console.ReadLine();  
             */

            /* There is 2 ways to instantiate arrays . the first one is to do it with all the values in the
            start and the second is to state how many is int the array and add the values of it later */
            int[] numbers = { 2, 4, 23, 454, 232 };
            string[] names = new string[6];
            names[0] = "Trevlin";
            names[1] = "Kylan";
            names[2] = "Rakheel";
            names[3] = "Shaolin";
            names[4] = "Joshua";
            names[5] = "Jeremiah";
             
            for (int i = 0; i < names.Length; i++ )
            {
                Console.Write(" " + names[i] );
                 
                if (names.Length == 6)
                {
                    Console.ReadLine();
                }
            }
             

        }
        public static void displayUserDetails(string user , int age)
        {
            if (user == "Kylan")
            {
                Console.WriteLine("My friend"); 
            }
            else if (user == "Trevlin")
            {
                Console.WriteLine("Trevlin"); 
            }
            else
            {
                Console.WriteLine("Dear"); 
            }
            Console.WriteLine( user +" who is about "+age+" years old");
            Console.ReadLine(); 
        }
    }
}
