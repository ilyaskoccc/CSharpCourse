using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer();
            customerManager.RemoveCustomer();
            customerManager.UpdateCustomer();

            Console.WriteLine("--------------------------------------------------");

            ProductManager productManager = new ProductManager();
            productManager.AddProduct();
            productManager.RemoveProduct();
            productManager.UpdateProduct();

            Console.WriteLine("--------------------------------------------------");


            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@test.com",
                PhoneNumber = "123-456-7890"
            };

            Console.WriteLine($"Customer ID: {customer.Id}");
            Console.WriteLine($"Customer Name: {customer.FirstName} {customer.LastName}");
            Console.WriteLine($"Customer Email: {customer.Email}");
            Console.WriteLine($"Customer Phone: {customer.PhoneNumber}");

            Console.WriteLine("--------------------------------------------------");

            Customer anotherCustomer = new Customer
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane@test.com",
                PhoneNumber = "098-765-4321"
            };

            Console.WriteLine($"AnotherCustomer ID: {anotherCustomer.Id}");
            Console.WriteLine($"AnotherCustomer Name: {anotherCustomer.FirstName} {anotherCustomer.LastName}");
            Console.WriteLine($"AnotherCustomer Email: {anotherCustomer.Email}");
            Console.WriteLine($"AnotherCustomer Phone: {anotherCustomer.PhoneNumber}");

            Console.ReadKey();
        }
    }
}
