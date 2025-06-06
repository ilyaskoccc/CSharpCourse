using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Hello", "World", "Generics");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers = utilities.BuildList(new Customer { Name = "Alice" }, new Customer { Name = "Bob" });
            
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            Console.ReadLine();
        }

        public class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }

        public class Product: IEntity
        {
        }

        interface IProductDao:IRepository<Product>
        {
            void SpecialMethodForProduct();
        }

        public class Customer: IEntity
        {
            public string Name { get; set; }
        }

        interface ICustomerDao : IRepository<Customer>
        {
            void SpecialMethodForCustomer();
        }

        public interface IRepository<T> where T : class, IEntity, new()
        {
            List<T> GetAll();
            T GetById(int id);
            void Add(T entity);
            void Update(T entity);
            void Delete(int id);
        }

        public interface IEntity
        {
        }

        public class ProductDao : IProductDao
        {
            public List<Product> GetAll()
            {
                return new List<Product>();
            }

            public Product GetById(int id)
            {
                return new Product();
            }

            public void Add(Product entity)
            {
            }

            public void Update(Product entity)
            {
            }

            public void Delete(int id)
            {
            }

            public void SpecialMethodForProduct()
            {
                throw new NotImplementedException();
            }
        }

        public class CustomerDao : ICustomerDao
        {
            public List<Customer> GetAll()
            {
                return new List<Customer>();
            }

            public Customer GetById(int id)
            {
                return new Customer();
            }

            public void Add(Customer entity)
            {
            }

            public void Update(Customer entity)
            {
            }

            public void Delete(int id)
            {
            }

            public void SpecialMethodForCustomer()
            {
                throw new NotImplementedException();
            }
        }
    }
}
