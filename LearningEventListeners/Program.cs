using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers; 

namespace LearningEventListeners
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer mytimer = new Timer(2000);

            mytimer.Elapsed += Mytimer_Elapsed;

            mytimer.Start();
            Console.ReadLine(); 
        }

        private static void Mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed {0:HH:mm:ss}", e.SignalTime); 
        }
    }
}
