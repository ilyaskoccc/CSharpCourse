using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee defaultEmployee = new Employee(); // Calls default constructor
            Employee parameterizedEmployee = new Employee("John Doe", 25); // Calls parameterized constructor
            Employee copiedEmployee = new Employee(parameterizedEmployee); // Calls copy constructor

            Console.ReadLine();
        }
    }

    class Employee
    {
        private string Name { get; set; }
        private int Age { get; set; }
        // Default constructor
        public Employee()
        {
            Name = "Default Name";
            Age = 30;

            Console.WriteLine("Default constructor called. Name: " + Name + ", Age: " + Age);
        }
        // Parameterized constructor
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine("Parameterized constructor called with Name: " + name + " and Age: " + age);
        }
        // Copy constructor
        public Employee(Employee employee)
        {
            Name = employee.Name;
            Age = employee.Age;

            Console.WriteLine("Copy constructor called. Name: " + Name + ", Age: " + Age);
        }
    }
}
