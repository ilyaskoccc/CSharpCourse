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
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=Etrade; integrated security=true");
        public List<Product> GetAll()
        {
            ConenctionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        public List<Product> GetAll2()
        {
            ConenctionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable.AsEnumerable().Select(row => new Product
            {
                Id = row.Field<int>("Id"),
                Name = row.Field<string>("Name"),
                UnitPrice = row.Field<decimal>("UnitPrice"),
                StockAmount = row.Field<int>("StockAmount")
            }).ToList();
        }

        public void Add(Product product)
        {
            ConenctionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Products (Name, UnitPrice, StockAmount) VALUES (@name, @unitPrice, @stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void ConenctionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
