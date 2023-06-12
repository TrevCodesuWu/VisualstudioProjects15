using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary29122022
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string Id_Number { get; set; }

        private string display_details(string name, string Id)
        {
            return "Name : " + name + "\n" + "ID Number : " + Id;
        }
        public string publicversion(string n, string id)
        {
            return display_details(n, id);
        }
    }
}

