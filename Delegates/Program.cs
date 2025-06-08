using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            // Using delegate to call methods
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; // Adding another method to the delegate
            
            myDelegate -= customerManager.SendMessage; // Removing the SendMessage method from the delegate

            myDelegate(); // Invoking the delegate to call both methods

            MathOperations mathOperations = new MathOperations();
            // Using delegate to call math operations
            MyDelegate mathDelegate = () => mathOperations.Add(10, 5);
            mathDelegate += () => mathOperations.Subtract(10, 5);
            mathDelegate += () => mathOperations.Multiply(10, 5);
            mathDelegate += () => mathOperations.Divide(10, 5);
            
            mathDelegate(); // Invoking the delegate to call all math operations

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }
    }

    public class MathOperations
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Sum: " + (x + y));
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("Difference: " + (x - y));
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("Product: " + (x * y));
        }
        public void Divide(int x, int y)
        {
            if (y != 0)
            {
                Console.WriteLine("Quotient: " + (x / y));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
