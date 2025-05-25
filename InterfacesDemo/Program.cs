using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEater[] eaters = new IEater[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eater in eaters)
            {
                eater.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.WriteLine("All operations completed successfully.");
            Console.ReadLine();
        }

        interface IWorker
        {
            void Work();
        }

        interface IEater
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }

        class Worker : IWorker, IEater, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Working...");
            }
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
            public void GetSalary()
            {
                Console.WriteLine("Getting salary...");
            }
        }

        class Manager : IWorker, IEater, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Managing work...");
            }
            public void Eat()
            {
                Console.WriteLine("Eating during a meeting...");
            }
            public void GetSalary()
            {
                Console.WriteLine("Getting manager's salary...");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot is working...");
            }
        }
    }
}
