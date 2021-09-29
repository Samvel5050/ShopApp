using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShopApp
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
        


        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Number = age;

        }
        public abstract void Display();
    
            
            
        }
    }

