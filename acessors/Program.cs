using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kylan","Govender",false);
            Console.WriteLine(person.Name + "\n" + person.Surname + "\n" + person.Gender);
            person.age = 33;
            Console.WriteLine(person.age);  
            Console.ReadLine(); 

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public int age { get; set; } 

        public Person(string name , string surname , bool gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
       
    }
}
