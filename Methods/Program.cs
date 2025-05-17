using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator

            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int result = 0;

            switch (operation)
            {
                case '+':
                    result = Addition(firstNumber, secondNumber);
                    break;
                case '-':
                    result = Subtraction(firstNumber, secondNumber);
                    break;
                case '*':
                    result = Multiplication(firstNumber, secondNumber);
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        result = (int)Division(firstNumber, secondNumber);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }
            Console.WriteLine();
            Console.WriteLine($"Result: {result}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }



        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static double Division(int a, int b)
        {
            return a / b;
        }
    }
}
