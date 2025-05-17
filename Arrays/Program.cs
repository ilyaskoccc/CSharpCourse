using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] {"İlyas", "Volkan", "Ahmet", "Ali", "Veli"};

            Console.WriteLine("----------NAMES------------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("----------REGIONS------------");

            string[,] regions = new string[3, 3]
            {
                {"İstanbul", "Bursa", "İzmit"},
                {"Ankara", "Konya", "Kırıkkale"},
                {"İzmir", "Manisa", "Aydın"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***************");
            }

            Console.ReadLine();
        }
    }
}
