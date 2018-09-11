using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCryptoCurrency
{
    class LinqToSQLDatabaseHandler : IDatabaseHandler
    {
        LinqToSQLDataContext db;
        public void ConnectToDatabase()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CryptoCurrencyConnectionString"].ToString();
            db = new LinqToSQLDataContext(connectionString);
        }

        public User GetUser(string username, string password)
        {
            ConnectToDatabase();
            User user = db.Users.FirstOrDefault(e => e.Username.Equals(username) && e.Password.Equals(password));
            return user;
        }

        public void InsertIntoUserDatabase(User user)
        {
            ConnectToDatabase();
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
        }
    }
}
