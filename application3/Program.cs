using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int enemycount=0;
            int allycount=0;
            int tiedcount = 0;
            int numbervalue;
            int numbervalue2; 
            Console.WriteLine("THE DICE GAME - BEST OF 10"); 
            for ( int a=0; a<10 ;a++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadLine();
                numbervalue = random.Next(1, 7);
                Console.WriteLine("The number you rolled is " + numbervalue);

                numbervalue2 = random.Next(1, 7);
                Console.WriteLine("The enemy AI rolled a " + numbervalue2);

                    if (numbervalue > numbervalue2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nYou win this round");
                            Console.ForegroundColor = ConsoleColor.White;
                            allycount++; 
                        }
                    else if (numbervalue2 > numbervalue)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nAI wins this round");
                            Console.ForegroundColor = ConsoleColor.White;
                            enemycount++;  
                        }
                    else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nYou and the enemy AI have tied in this round");
                            Console.ForegroundColor = ConsoleColor.White;
                            tiedcount++;  
                        }        
                Console.ReadLine();
            }
            Console.WriteLine("\tThe final score is :");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You : " + allycount);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AI : " + enemycount);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tied : " + tiedcount); 
            Console.ReadLine(); 
    
        }
    }
}
