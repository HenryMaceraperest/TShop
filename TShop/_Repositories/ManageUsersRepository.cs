using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Models;

namespace TShop._Repositories
{
    internal class ManageUsersRepository : BaseRepository, IManageUsersRepository
    {
        // Methods
        public ManageUsersRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        public void Add(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Users VALUES (@name)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = userModel.Username;
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
                command.CommandText = "DELETE FROM Users WHERE User_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Users SET User_name=@name WHERE User_id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = userModel.Username;
                command.Parameters.Add("@id", SqlDbType.Int).Value = userModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<UserModel> GetAll()
        {
            var userList = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Users ORDER BY User_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = (int)reader[0];
                        userModel.Username = (string)reader[1];
                        userList.Add(userModel);
                    }
                }
            }
            return userList;
        }

        public IEnumerable<UserModel> GetByValue(string value)
        {
            var userList = new List<UserModel>();
            string userName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Users " +
                    "WHERE User_Name LIKE @Name+'%' " +
                    "ORDER BY User_Id DESC";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = (int)reader[0];
                        userModel.Username = (string)reader[1];
                        userList.Add(userModel);
                    }
                }
            }
            return userList;
        }
    }
}
