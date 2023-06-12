using ClassLibrary29122022; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace consoleApplication29122022
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            List<Car> mylist = new List<Car>()
          {
              new Car {name="mercedes", model="r9",VIN="34DF" },
              new Car {name="Audi",model="merialago",VIN="55EE" },
              new Car {name="Audi",model="suprr",VIN="92NW" },
              new Car {name="toyota",model="tazz",VIN="31EJ" }

          };

            var j = mylist.Where(p => p.name == "Audi");
            var t = mylist.FindAll(p => p.name == "toyota"); 
            foreach ( var car in j)
            {
                Console.WriteLine("{0}", car.model); 
            } */  /*
            string[] names = { "one","two","three","four","five","six" }; 
            displayV(names);  */
 /*
            List<Todo> listOfTodo = new List<Todo>()
            {
                new Todo {Description ="THis is not it",EstimatedHours=23, status = Status.unfinished },
                new Todo {Description ="why this zink is so filthy here", EstimatedHours = 22 , status = Status.invalid },
                new Todo {Description ="hello who is this",EstimatedHours = 33 , status = Status.error },
                new Todo {Description ="What am I doing here ", EstimatedHours =55,status = Status.completed }

            };
            displaything( listOfTodo);  */ 
            try
            {
                Console.WriteLine(File.ReadAllText(@"C:\Lesson20\hello.txt")); 

            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("The directory is not found what you wrote you dum piece of shit "); 
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("The file you are looking for is not anywhere to be seen , try to see if the name of it is correct and try again later "); 
            }
            catch (Exception e)
            {
                Console.WriteLine("There was a problem doing what you were trying to do ");
                Console.WriteLine(e); 
            }
            finally
            {
                Console.WriteLine("The application is now closing ");
                Console.WriteLine("goodbye"); 
            }
            Console.ReadLine();
        }
        private static void displaything(List<Todo> todo)
        {
            foreach ( var element in todo)
            {
              switch(element.status)
                {
                    case Status.completed: Console.ForegroundColor = ConsoleColor.Cyan; 
                        break;
                    case Status.error: Console.ForegroundColor = ConsoleColor.Red; 
                        break;
                    case Status.invalid: Console.ForegroundColor = ConsoleColor.Yellow; 
                        break;
                    case Status.unfinished: Console.ForegroundColor = ConsoleColor.Magenta; 
                        break;
                     default : Console.WriteLine("Nothing to see here ");
                        break; 
                }
                Console.WriteLine(element.Description); 
            }
        }
        // displays any array that is passed in the method 
        public static void displayV(string[] u)
        {

            foreach (string used in u)
            {
                Console.WriteLine(used);
            }
            Console.ReadLine();


        }
        public enum planets
        {
            Mercury = 2030,
            Uranus = 3494,
            Jupiter = 9049,
            Pluto = 10000,
            Venus = 5000,
            Earth = 3040,
            Mars = 2003,
            Saturn = 3493
        }
        class Todo
        {
            public string Description { get; set; }
            public int EstimatedHours { get; set; }
            public Status status { get; set; }
        }
        public enum Status
        {
            completed ,
            unfinished,
            error,
            invalid
        }
    }
   
}

