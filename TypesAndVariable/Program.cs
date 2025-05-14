using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariable
{
    internal class Program
    {
        //This program prints a pyramid pattern of stars
        //Şeyma Esila Erol with İlyas Koç is coming soon :)
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= 1 * i - 1; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
