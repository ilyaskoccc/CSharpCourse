using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem islem = new DortIslem(10, 5);
            // Using the methods with parameters
            Console.WriteLine("Toplama Sonucu: " + islem.Topla2());

            // Using the default constructor
            Console.WriteLine("Toplama Sonucu (Parametreli): " + islem.Topla(20, 15));

            var type = typeof(DortIslem);
            //DortIslem islem2 = (DortIslem)Activator.CreateInstance(type, 20, 10);
            var instance = Activator.CreateInstance(type, 20, 10);

            // Using the methods with parameters
            Console.WriteLine("Toplama Sonucu: " + instance.GetType().GetMethod("Topla").Invoke(instance, new object[] { 20, 15 }));

            // Using the default constructor
            Console.WriteLine("Toplama Sonucu (Parametreli): " + instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            Console.WriteLine("-------------------------------------------");

            var methods = type.GetMethods();
            Console.WriteLine();
            Console.WriteLine("DortIslem Sınıfındaki Metotlar:");
            Console.WriteLine("-------------------------------------------");

            foreach (var method in methods)
            {
                Console.WriteLine("Method Adı : {0}", method.Name);
                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine("Parametre Adı: {0}, Parametre Tipi: {1}", parameter.Name, parameter.ParameterType);
                }

                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("Özellik Adı: {0}, Özellik Değeri: {1}", attribute.GetType().Name, attribute.ToString());
                }

                Console.WriteLine("-------------------------------------------");
            }
            Console.ReadLine();
        }

        public class DortIslem
        {
            private int _sayi1;
            private int _sayi2;

            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public DortIslem()
            {
            }

            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Cikar(int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }

            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }

            public int Cikar2()
            {
                return _sayi1 - _sayi2;
            }
        }
    }
}
