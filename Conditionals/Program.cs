using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------IF-ELSE-----------------");
            var number = 10;
            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }

            Console.WriteLine("--------------TERNARY-----------------");

            // Ternary operator
            Console.WriteLine(number == 0 ? "Number is zero" : number > 0 ? "Number is positive" : "Number is negative");
       
            Console.ReadLine();
        }
    }
}
