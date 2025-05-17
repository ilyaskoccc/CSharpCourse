using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
            DoWhileLoop();
            ForEachLoop();

            Console.WriteLine("Number Is Prime : " + IsPrimeNumber(7));
            Console.WriteLine("Number Is Prime : " + IsPrimeNumber(10));

            Console.ReadLine();
        }

        public static void ForLoop()
        {
            // For Loop
            Console.WriteLine("----------NEW-LINE------------");
            for (int i = 10; i >= 0; i = i - 2)
            {
                Console.WriteLine("For Loop: " + i);
            }
            Console.WriteLine("----------NEW-LINE------------");
            Console.WriteLine();
        }
        public static void WhileLoop()
        {
            // While Loop
            Console.WriteLine("----------NEW-LINE------------");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("While Loop: " + j);
                j = j + 2;
            }
            Console.WriteLine("----------NEW-LINE------------");
            Console.WriteLine();
        }
        public static void DoWhileLoop()
        {
            // Do While Loop
            Console.WriteLine("----------NEW-LINE------------");
            int k = 0;
            do
            {
                Console.WriteLine("Do While Loop: " + k);
                k++;
            } while (k <= 10);
            Console.WriteLine("----------NEW-LINE------------");
            Console.WriteLine();
        }
        public static void ForEachLoop()
        {
            // For Each Loop
            Console.WriteLine("----------NEW-LINE------------");
            List<string> names = new List<string>() { "John", "Jane", "Doe" };
            foreach (string name in names)
            {
                Console.WriteLine("For Each Loop: " + name);
            }
            Console.WriteLine("----------NEW-LINE------------");
            Console.WriteLine();
        }
        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
