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

            // Switch statement
            Console.WriteLine("--------------SWITCH-----------------");
            var day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
                }
                Console.ReadLine();
        }
    }
}
