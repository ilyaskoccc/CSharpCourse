using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkDemo
{
    public class ProductDao
    {
        public List<Product> GetAll()
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Where(product => product.Name.Contains(key)).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Find(id);
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Where(product => product.UnitPrice >= min && product.UnitPrice <= max).ToList();
            }
        }

        public List<Product> GetByStockAmount(int min, int max)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Where(product => product.StockAmount >= min && product.StockAmount <= max).ToList();
            }
        }

        public void Add(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                context.Products.Attach(product);
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                context.Products.Attach(product);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
