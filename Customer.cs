using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShopApp
{
    class Customer : Person
    {
        
        private int Sum { get; set; }
        public Customer(string name,string surname,int age,int sum):base(name,surname,age)
        {
            
            Sum = sum;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name}, {Surname} => Dzer Gumar@ Kazmum e   {Sum} Dram");
        }
    }
}
