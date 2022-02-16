using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Tom", 23),
                new Person("Bob", 27),
                new Person("Sam", 29),
                new Person("Alice",24)
            };

            var personel = from p in people
                           select new
                           {
                               FirstName = p.Names,
                               Year = DateTime.Now.Year - p.Ages
                           };

            foreach (var p in personel)
                Console.WriteLine($"{p.FirstName} - {p.Year}");
            Console.ReadLine();
        }
        class Person
        {
            public string Names { get; } 
            public int Ages { get; }
            public Person(string name, int age)
            {
                Names = name;
                Ages = age;
            }
        }


    }
}
