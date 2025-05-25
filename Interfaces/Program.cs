using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfacesIntro();

            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();

            // Creating instances of Customer and Student
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@test.com"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Departmant = "Computer Science"
            };


            personManager.Add(customer);
            personManager.Add(student);
            personManager.Update(customer);
            personManager.Update(student);
            personManager.Delete(customer);
            personManager.Delete(student);

            Console.WriteLine("Operations completed successfully.");
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                // Adding logic here
                Console.WriteLine($"{person.FirstName} {person.LastName} added.");
            }
            public void Update(IPerson person)
            {
                // Updating logic here
                Console.WriteLine($"{person.FirstName} {person.LastName} updated.");
            }
            public void Delete(IPerson person)
            {
                // Deleting logic here
                Console.WriteLine($"{person.FirstName} {person.LastName} deleted.");
            }
        }
    }
}
