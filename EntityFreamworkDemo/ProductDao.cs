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
