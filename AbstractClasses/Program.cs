using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db1 = new SqlDatabase();
            db1.Connect();
            db1.Disconnect();

            Database db2 = new PostgresDatabase();
            db2.Connect();
            db2.Disconnect();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public abstract void Connect();
        public abstract void Disconnect();
    }

    class SqlDatabase : Database
    {
        public override void Connect()
        {
            Console.WriteLine("Connecting to SQL database...");
        }
        public override void Disconnect()
        {
            Console.WriteLine("Disconnecting from SQL database...");
        }
    }

    class PostgresDatabase : Database
    {
        public override void Connect()
        {
            Console.WriteLine("Connecting to PostgreSQL database...");
        }
        public override void Disconnect()
        {
            Console.WriteLine("Disconnecting from PostgreSQL database...");
        }
    }
}
