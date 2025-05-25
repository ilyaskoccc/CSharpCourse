using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Person { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Department = "HR", Salary = 60000m },
                new Student { Id = 3, FirstName = "Alice", LastName = "Johnson", Major = "Computer Science", GPA = 3.8 }
            };

            foreach (var p in person)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Employee : Person
        {
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }

        class Student : Person
        {
            public string Major { get; set; }
            public double GPA { get; set; }
        }
    }
}
