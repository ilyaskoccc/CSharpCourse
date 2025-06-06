﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer("Alice", 30),
                new Customer("Charlie", 35)
            };

            customers.AddRange(new List<Customer>
            {
                new Customer("Bob", 25),
                new Customer("Diana", 28)
            });

            customers.RemoveAll(c => c.Age < 30);

            customers.Sort((x, y) => x.Name.CompareTo(y.Name));

            customers.Reverse();

            //customers.Clear();

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer Name: {customer.Name}, Age: {customer.Age}");
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add(42);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"ArrayList Item: {item}");
            }

            Console.WriteLine(arrayList.Contains(42));

            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" }
            };

            dictionary.Add(4, "Four");
            dictionary.Remove(2);
            dictionary[3] = "Updated Three";
            
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.ReadLine();
        }

        class Customer
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Customer(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
