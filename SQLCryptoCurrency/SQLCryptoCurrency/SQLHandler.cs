using SQLCryptoCurrency.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCryptoCurrency
{
    public class SqlHandler
    {
        public SqlConnection ConnectToDatabase()
        {
            string connectionString;
            SqlConnection connection;
            connectionString = @"Data Source=LAPTOP-6HUM6MNH;Initial Catalog=cryptocurrency;User ID=admin;Password=admin";
            connection = new SqlConnection(connectionString);
            return connection;
        }

        public void InsertIntoUserDatabase(User user)
        {
            SqlConnection connection = ConnectToDatabase();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            connection.Open();
            sql = $"INSERT INTO Users(Username, Firstname, Lastname) VALUES ('{user.Username}','{user.Firstname}', '{user.Lastname}')";
            command = new SqlCommand(sql, connection);
            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
    }
}
