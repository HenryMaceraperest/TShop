using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TShop.Models;

namespace TShop._Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        // Constructor
        public ProductRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products VALUES (@name, @type, @quantity, @agelimit, @barcode, @cost)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = productModel.Type;
                command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = productModel.Quantity;
                command.Parameters.Add("@agelimit", SqlDbType.Bit).Value = productModel.AgeLimit;
                command.Parameters.Add("@barcode", SqlDbType.BigInt).Value = productModel.Barcode;
                command.Parameters.Add("@cost", SqlDbType.Money).Value = productModel.Cost;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Products WHERE Product_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Products SET Product_name=@name,Product_type=@type,Product_quantity=@quantity,Product_ageLimit=@agelimit,Product_barcode=@barcode,Product_cost=@cost WHERE Product_id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = productModel.Type;
                command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = productModel.Quantity;
                command.Parameters.Add("@agelimit", SqlDbType.Bit).Value = productModel.AgeLimit;
                command.Parameters.Add("@barcode", SqlDbType.BigInt).Value = productModel.Barcode;
                command.Parameters.Add("@cost", SqlDbType.Money).Value = productModel.Cost;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader[0];
                        productModel.Name = (string)reader[1];
                        productModel.Type = (string)reader[2];
                        productModel.Quantity = (string)reader[3];
                        productModel.AgeLimit = (bool)reader[4];
                        productModel.Barcode = (long)reader[5];
                        productModel.Cost = (decimal)reader[6];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            long productBarcode = long.TryParse(value, out _) ? Convert.ToInt64(value) : 0;
            string productName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products " +
                    "WHERE Product_Barcode LIKE @Barcode+'%' OR Product_Name LIKE @Name+'%' " +
                    "ORDER BY Product_Id DESC";
                command.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = productBarcode;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = productName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader[0];
                        productModel.Name = (string)reader[1];
                        productModel.Type = (string)reader[2];
                        productModel.Quantity = (string)reader[3];
                        productModel.AgeLimit = (bool)reader[4];
                        productModel.Barcode = (long)reader[5];
                        productModel.Cost = (decimal)reader[6];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }
    }
}
