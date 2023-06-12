using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); 

            Console.Write("Enter a number : ");
            string input1 = Console.ReadLine();
            
            Console.Write("Enter a number : ");
            string input2 = Console.ReadLine();
            
            Console.WriteLine("Choose the operator :\n" +
                              "1. Add \n" +
                              "2. Subtract \n" +
                              "3. Divide \n" +
                              "4. Multiply ");
            string choice = Console.ReadLine();
             
            switch (Convert.ToInt32(choice))
            {
                case 1:  Console.WriteLine(calculator.ansAdd(Convert.ToInt32(input1), Convert.ToInt32(input2))); 
                    break;
                case 2:
                    Console.WriteLine(calculator.ansSub(Convert.ToInt32(input1), Convert.ToInt32(input2)));
                    break;
                case 3:
                    Console.WriteLine(calculator.ansDiv(Convert.ToInt32(input1), Convert.ToInt32(input2)));
                    break;
                case 4:
                    Console.WriteLine(calculator.ansMult(Convert.ToInt32(input1), Convert.ToInt32(input2)));
                    break;
                default: Console.WriteLine("Enter a valid number from the options above "); 
                    break; 
            }
            Console.ReadLine(); 
        }


    }
    class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int ansAdd(int number1 , int number2)
        {
            return number1 + number2;
        }
        public int ansSub(int number1, int number2)
        {
            return number1 - number2;
        }
        public int ansDiv(int number1, int number2)
        {
            return number1 / number2;
        }
        public int ansMult(int number1, int number2)
        {
            return number1 * number2;
        }
        public int anss (int number1 , int number2, int choice)
        {
            if(choice==1)
            {
                return number1 + number2;
            }
            else if (choice ==2)
            {
                return number1 - number2;
            }
            else if (choice ==3)
            {
                return number1 / number2;
            }
            else  
            {
                return number1 * number2;
            }
            
        }
    }

    
}
