using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCryptoCurrency
{
    class ADODatabaseHandler : IDatabaseHandler
    {
        SqlConnection connection;
        public void ConnectToDatabase()
        {         
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CryptoCurrencyConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
        }

        public User GetUser(string username)
        {
            throw new NotImplementedException(); 
        }

        public void InsertIntoUserDatabase(User user)
        {
            ConnectToDatabase();
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
