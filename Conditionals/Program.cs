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
            // Example: Switch statement to determine the day of the week
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

            Console.WriteLine("--------------EXAMPLE-----------------");
            // Example: Check if a number is in a specific range

            if (number >= 0 && number < 100)
            {
                Console.WriteLine("Number is between 0 and 100");
            }
            else if (number >= 100 && number < 200)
            {
                Console.WriteLine("Number is between 100 and 200");
            }
            else if (number >= 200 && number < 300)
            {
                Console.WriteLine("Number is between 200 and 300");
            }
            else if (number >= 300 || number < 400)
            {
                Console.WriteLine("Number is between 300 and 400");
            }
            else
            {
                Console.WriteLine("Number is greater than or equal to 400");
            }
            Console.ReadLine();
        }
    }
}