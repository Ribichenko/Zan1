using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zan1
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new List<Company>
            {
                new Company("Microsoft", new List<Person> {new Person("Tom"), new Person("Bob")}),
                new Company("Google", new List<Person> {new Person("Sam"), new Person("Mike")}),
            };
            var employees = from c in companies
                            from emp in c.Staff
                            select new { Name = emp.Name, Company = c.Name };

            foreach (var emp in employees)
                Console.WriteLine($"{emp.Name} - {emp.Company}");
        }
            class Company
            {
                public string Name { get; }
                public List<Person> Staff;
                public Company(string Name, List<Person> Staff)
                {
                    Name = Name;
                }
            }
            class Person
            {
                public string Name { get; }
                public Person(string Name)
                {
                    Name = Name;
                }
            }
    }
}
