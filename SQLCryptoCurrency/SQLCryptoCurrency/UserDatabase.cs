using SQLCryptoCurrency.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCryptoCurrency
{
    public class UserDatabase
    {

        public void LinqConnect(User user)
        {
            string connectionString = @"Data Source=LAPTOP-6HUM6MNH;Initial Catalog=cryptocurrency;User ID=admin;Password=admin";
            LinqToSQLDataContext db = new LinqToSQLDataContext(connectionString);
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
        }

        public User GetUser()
        {
            string connectionString = @"Data Source=LAPTOP-6HUM6MNH;Initial Catalog=cryptocurrency;User ID=admin;Password=admin";
            LinqToSQLDataContext db = new LinqToSQLDataContext(connectionString);
            return null;
        }

        public SqlConnection ConnectToDatabase()
        {
            string connectionString;
            SqlConnection connection;
            connectionString = @"Data Source=LAPTOP-6HUM6MNH;Initial Catalog=cryptocurrency;User ID=admin;Password=admin";
            connection = new SqlConnection(connectionString);
            return connection;
        }

        public void InsertIntoDatabase(User user)
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
