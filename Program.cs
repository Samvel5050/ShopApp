using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person customer1 = new Customer("David", "Santrosyan",25,5600);
            customer1.Display();
            Person customer2 = new Customer("Samvel", "Avagyan", 54, 12700);
            customer2.Display();
            Person customer3 = new Customer("Menua", "Kiarkosyan", 35, 25000);
            customer3.Display();

            Console.WriteLine(new string('_', 55));
            Person employee1 = new Employee("Arpine","Simonyan",32,"Cashier");
            employee1.Display();
            Person employee2 = new Employee("Arevik", "Hakobyan", 21, "Cashier");
            employee2.Display();
            Person employee3 = new Employee("Syuzanna", "Mesropyan", 25, "Cashier");
            employee3.Display();
            Console.WriteLine(new string('_', 55));
            Person manager = new Employee("Syuzanna", "Mesropyan", 42, "Manager");
            manager.Display();

            List<Person> person = new List<Person>();
            person.Add(customer1);
            person.Add(customer2);
            person.Add(customer3);
            person.Add(employee1);
            person.Add(employee2);
            person.Add(employee3);
            
        }
    }

    
}
