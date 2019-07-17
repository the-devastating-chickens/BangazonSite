using System.Collections.Generic;
using Bangazon.Models;
using Bangazon.Data;
using System.Data.SqlClient;

namespace Bangazon.Models.ProductViewModels
{
  public class ProductListViewModel
  {
    public IEnumerable<Product> Products { get; set; }
    public Product Product { get; set;  }

    private readonly string _connectionString;

        private SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }

        }

        public ProductListViewModel(string connectionString)
        {
            _connectionString = connectionString;

        }
        private void GetAllProducts()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT Id,
                               Title,
                               FROM Product
";
                    SqlDataReader reader = cmd.ExecuteReader();
                    Products = new List<Product>();
                    while (reader.Read())
                    {
                        Id = 
                    }
                }
            }
        }
    }
}