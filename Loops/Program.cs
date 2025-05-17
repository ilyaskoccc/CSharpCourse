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
            // For Loop
            for (int i = 10; i >= 0; i = i - 2)
            {
                Console.WriteLine("For Loop: " + i);
            }
            Console.WriteLine("----------NEW-LINE------------");
            // While Loop
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("While Loop: " + j);
                j = j + 2;
            }
            Console.WriteLine("----------NEW-LINE------------");
            // Do While Loop
            int k = 0;
            do
            {
                Console.WriteLine("Do While Loop: " + k);
                k++;
            } while (k <= 10);

            Console.WriteLine("----------NEW-LINE------------");
            // Foreach Loop
            string[] names = new string[5] { "İlyas", "Volkan", "Ahmet", "Ali", "Veli" };
            foreach (string name in names)
            {
                Console.WriteLine("Foreach Loop: " + name);
            }
            Console.ReadLine();
        }
    }
}
