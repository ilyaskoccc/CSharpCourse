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
            Console.WriteLine("-------------------------------");

            //Value Types
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            double number5 = 10.4;
            decimal number6 = 10;
            char character = 'A';
            bool isTrue = true;

            Console.WriteLine("Value Types:");
            Console.WriteLine("int: number1 is{0}",number1);
            Console.WriteLine("long: number2 is{0}", number2);
            Console.WriteLine("short: number3 is{0}", number3);
            Console.WriteLine("byte: number4 is{0}", number4);
            Console.WriteLine("double: number5 is{0}", number5);
            Console.WriteLine("decimal: number6 is{0}", number6);
            Console.WriteLine("char: character is{0}", character);
            Console.WriteLine("bool: isTrue is{0}", isTrue);
            Console.WriteLine((int)Days.Friday);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }

    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
