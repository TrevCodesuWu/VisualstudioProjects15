using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean cheese = true; 
            while (cheese)
            {
                int numberone = userinput();
                int userone = genrandom();

                if (numberone == userone)
                {
                    Console.WriteLine("You have guessed it correctly ");
                    cheese = false; 
                }
                else if (numberone != userone && numberone < 8 && numberone > 0)
                {
                    Console.WriteLine("You did not get it correct");
                }
                else
                {
                    Console.WriteLine("Guess within the value of a dice , 1-7"); 
                }
            }
           
            Console.ReadLine(); 
        }
        public static int genrandom()
        {
            Random random = new Random();
            int num = random.Next(1,7);  
            return num;
        }
        public static int userinput()
        {
            Console.WriteLine("Guess the number the dice is going to land on ");
            int value = int.Parse(Console.ReadLine());
            return value;  

        }
        
       
    }
    
}
