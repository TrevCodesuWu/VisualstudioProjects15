using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name ? ");
            string name = Console.ReadLine();
            Console.Write("What is your surname ? ");
            string surname = Console.ReadLine();
            Console.Write("Where do you live ? ");
            string place = Console.ReadLine();
            
            reverseWords(name, surname, place);
            Console.ReadLine(); 
        }
       public static void reverseWords(string name , string surname ,string place)
        {
            string combined = name +" "+ surname +" "+ place;
            char[] letters = combined.ToCharArray();
            Array.Reverse(letters);
            Console.WriteLine("Results : ");
            foreach (char c in letters)
            {
                Console.Write(c);    
            }
        }
    }
}
