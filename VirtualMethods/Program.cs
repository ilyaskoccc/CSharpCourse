using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
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

            Database db3 = new OracleDatabase();
            db3.Connect(); // This will call the base class method since OracleDatabase does not override Connect
            db3.Disconnect();

            Console.ReadLine();
        }

        class Database
        {
            public virtual void Connect()
            {
                Console.WriteLine("Connecting to the database...");
            }

            public virtual void Disconnect()
            {
                Console.WriteLine("Disconnecting from the database...");
            }
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

        class OracleDatabase : Database
        {
        }
    }
}
