using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(50);
            product.ProductName = "Harddisk";

            Product product2 = new Product(50);
            product2.ProductName = "Phone";
            product2.StockControlEvent += product2_StockControlEvent;
            //product.StockControlEvent += () => Console.WriteLine("Stock is low for {0}!", product.ProductName);

            for (int i = 0; i < 5; i++)
            {
                product.Sell(10);
                product2.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void product2_StockControlEvent()
        {
            Console.WriteLine("Stock is low for Phone!");
        }
    }
}
