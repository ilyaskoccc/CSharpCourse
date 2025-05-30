using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine($"Custom exception caught: {exception.Message}");
            }

            HandleException(() =>
            {
                Find();
            });
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Custom exception caught: {exception.Message}");
            }
        }

        public static void ExceptionIntro()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }

        public static void Find()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            if (!numbers.Contains(6))
            {
                throw new RecordNotFoundException("Number Not Found!");
            }
            else
            {
                Console.WriteLine("Number found.");
            }
        }
    }
}
