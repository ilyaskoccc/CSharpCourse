using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDao
    {
        public List<Product> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=Etrade; integrated security=true");
           
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable.AsEnumerable().Select(row => new Product
            {
                Id = row.Field<int>("Id"),
                Name = row.Field<string>("Name"),
                UnitPrice = row.Field<decimal>("UnitPrice"),
                StockAmount = row.Field<int>("StockAmount")
            }).ToList();
        }
    }
}
