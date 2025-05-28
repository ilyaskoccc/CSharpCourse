using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value type example
            int value1 = 10;
            int value2 = value1; // Copying value type
            value2 = 20; // Changing value2 does not affect value1
            Console.WriteLine($"Value Type Example: value1 = {value1}, value2 = {value2}");
            // Reference type example
            List<string> list1 = new List<string> { "Apple", "Banana" };
            List<string> list2 = list1; // Copying reference type
            list2.Add("Cherry"); // Changing list2 affects list1
            Console.WriteLine($"Reference Type Example: list1 = {string.Join(", ", list1)}, list2 = {string.Join(", ", list2)}");
            Console.ReadLine();
        }
    }
}
