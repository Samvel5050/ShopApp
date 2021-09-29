using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShopApp
{
    class Employee:Person
    {
        private string Position { get; set; }
        
        public Employee(string name, string surname, int age,string position) :base(name,surname,age)
        {
            
            Position = position;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name}, {Surname}, {Number} Ashxatum e Vorpes ({Position}) ");
        }

    }
}
