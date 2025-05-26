using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.PublicField = 10; // Accessible
            // myClass.protectedField = 20; // Not accessible, protected member
            // myClass.privateField = 30; // Not accessible, private member
            // myClass.internalField = 40; // Not accessible, internal member (if in different assembly)

            Console.WriteLine("Public Field: " + myClass.PublicField);
            // Console.WriteLine("Protected Field: " + myClass.protectedField); // Not accessible
            // Console.WriteLine("Private Field: " + myClass.privateField); // Not accessible
            // Console.WriteLine("Internal Field: " + myClass.internalField); // Not accessible

            Console.ReadLine();
        }
    }

    class MyClass
    {
        public int PublicField;
        protected int protectedField;
        private int privateField;
        internal int internalField;
    }

    class DerivedClass : MyClass
    {
        public void AccessFields()
        {
            PublicField = 10; // Accessible
            protectedField = 20; // Accessible in derived class
            // privateField = 30; // Not accessible, private member
            // internalField = 40; // Accessible if in the same assembly
        }

    }
}
