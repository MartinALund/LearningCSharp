using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marubo.Interfaces;
namespace Marubo
{
    class LinqDatabaseHandler : IDatabaseHandler
    {
        MaruboDBDataContext db;
        public void ConnectToDatabase()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Marubo.Properties.Settings.maruboConnectionString"].ToString();
            db = new MaruboDBDataContext(connectionString);
        }

        public Customer GetCustomer(string email)
        {
            ConnectToDatabase();
            Customer user = db.Customers.FirstOrDefault(e => e.Email.Equals(email));
            return user;
        }

        public List<Product> GetProducts()
        {
            ConnectToDatabase();
            List<Product> products = db.Products.ToList();
            return products;
        }

        public void InsertIntoCustomerDatabase(Customer customer)
        {
            ConnectToDatabase();
            db.Customers.InsertOnSubmit(customer);
            db.SubmitChanges();
        }
    }
}
