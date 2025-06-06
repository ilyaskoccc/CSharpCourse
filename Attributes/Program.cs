using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };

            PersonDao personDao = new PersonDao();
            personDao.Add(person); // This will show a warning because of the Obsolete attribute
            personDao.AddNew(person); // This is the preferred method
        }


    }

    [Table("Person")]
    public class Person
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
    }

    public class PersonDao
    {
        [Obsolete("Use AddNew instead", false)]
        public void Add(Person person)
        {
            Console.WriteLine($"Adding person: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }

        public void AddNew(Person person)
        {
            Console.WriteLine($"Adding person: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    class TableAttribute : Attribute
    {
        public string Name { get; }
        public TableAttribute(string name)
        {
            Name = name;
        }
    }
}