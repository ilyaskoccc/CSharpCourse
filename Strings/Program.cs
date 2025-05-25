using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Manipulation
            string str = "Hello World";
            Console.WriteLine("Original String: " + str);
            Console.WriteLine("Length of String: " + str.Length);
            Console.WriteLine("Uppercase: " + str.ToUpper());
            Console.WriteLine("Lowercase: " + str.ToLower());
            Console.WriteLine("Substring: " + str.Substring(0, 5));
            Console.WriteLine("Index of 'W': " + str.IndexOf('W'));
            Console.WriteLine("Replace 'World' with 'C#': " + str.Replace("World", "C#"));
            Console.WriteLine("Split by space: " + string.Join(", ", str.Split(' ')));
            Console.WriteLine("Trimmed String: " + str.Trim());

            // String Interpolation
            string name = "John";
            int age = 30;
            string greeting = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(greeting);

            // String Formatting
            string formattedString = string.Format("Hello, my name is {0} and I am {1} years old.", name, age);
            Console.WriteLine(formattedString);

            // String Concatenation
            string concatenatedString = "Hello, my name is " + name + " and I am " + age + " years old.";
            Console.WriteLine(concatenatedString);

            // String Builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(", ");
            sb.Append(name);
            sb.Append("!");
            sb.Append(" You are ");
            sb.Append(age);
            sb.Append(" years old.");
            Console.WriteLine(sb.ToString());

            // String Comparison
            string str1 = "Hello";
            string str2 = "hello";
            Console.WriteLine("String Comparison: " + str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
            
            // String Contains
            Console.WriteLine("String Contains 'World': " + str.Contains("World"));
            
            // String StartsWith
            Console.WriteLine("String StartsWith 'Hello': " + str.StartsWith("Hello"));
            
            // String EndsWith
            Console.WriteLine("String EndsWith 'World': " + str.EndsWith("World"));
            
            // String IsNullOrEmpty
            string nullString = null;
            string emptyString = "";
            Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(nullString));
            Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(emptyString));
            
            // String IsNullOrWhiteSpace
            string whiteSpaceString = "   ";
            Console.WriteLine("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(whiteSpaceString));
            
            // String Join
            string[] words = { "Hello", "World" };
            string joinedString = string.Join(" ", words);
            Console.WriteLine("Joined String: " + joinedString);
            
            // String Format
            string formatted = string.Format("Hello {0}, you are {1} years old.", name, age);
            Console.WriteLine("Formatted String: " + formatted);
            
            // String ToCharArray
            char[] charArray = str.ToCharArray();
            Console.WriteLine("Char Array: " + string.Join(", ", charArray));
            
            // String ToCharArray with range
            char[] charArrayRange = str.ToCharArray(0, 5);
            Console.WriteLine("Char Array with range: " + string.Join(", ", charArrayRange));

            // String ToUpper and ToLower
            string upper = str.ToUpper();
            string lower = str.ToLower();
            Console.WriteLine("Upper: " + upper);
            Console.WriteLine("Lower: " + lower);

            // String Compare
            string compareStr1 = "Hello";
            string compareStr2 = "hello";
            int comparisonResult = string.Compare(compareStr1, compareStr2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("String Compare: " + comparisonResult);

            // String Copy
            string copyStr = string.Copy(str);
            Console.WriteLine("Copied String: " + copyStr);
            
            // String Remove
            string removeStr = str.Remove(5);
            Console.WriteLine("Removed String: " + removeStr);
            
            // String Insert
            string insertStr = str.Insert(5, " Beautiful");
            Console.WriteLine("Inserted String: " + insertStr);

            // String PadLeft and PadRight
            string padLeftStr = str.PadLeft(20, '*');
            string padRightStr = str.PadRight(20, '*');
            Console.WriteLine("Padded Left String: " + padLeftStr);
            Console.WriteLine("Padded Right String: " + padRightStr);

            Console.ReadLine();
        }
    }
}
