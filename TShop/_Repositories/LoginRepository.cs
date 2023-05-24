using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TShop._Repositories
{
    internal class LoginRepository : BaseRepository, ILoginRepository
    {
        public LoginRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public UserModel Login(UserModel user)
        {
            var loggedInUser = new UserModel();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Users " +
                "WHERE username = @name AND password = @password";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = user.Username;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = user.Password;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        loggedInUser = user;
                        return loggedInUser;
                    }
                    else
                    {
                        return loggedInUser;
                    }
                }
            }
        }
    }
}
