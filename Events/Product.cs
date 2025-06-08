using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (_stock <= 15 && StockControlEvent != null)
                {
                    StockControlEvent(); // Trigger the event if stock is below 10
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{0} Stock amount : {1}", ProductName, Stock);
        }
    }
}
