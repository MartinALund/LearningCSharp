using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Marubo.Interfaces;
using Marubo.Utils;
namespace Marubo
{
    class LinqDatabaseHandler : IDatabaseHandler
    {
        MaruboDBDataContext db;


        public LinqDatabaseHandler()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Marubo.Properties.Settings.maruboConnectionString"].ToString();
            db = new MaruboDBDataContext(connectionString);           
        }

        ~LinqDatabaseHandler()
        {
            db.Connection.Close();       
        }

        public Customer GetCustomer(string email)
        {
            Customer user = db.Customers.FirstOrDefault(e => e.Email.Equals(email));
            return user;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = db.Products.ToList();
            return products;
        }

        public void InsertIntoCustomerDatabase(Customer customer)
        {
            db.Customers.InsertOnSubmit(customer);
            db.SubmitChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var loggedInCustomer = db.Customers.Single(x => x.CustomerId == Constants.loggedInCustomer.CustomerId);
            loggedInCustomer.Adress = customer.Adress;
            loggedInCustomer.Email = customer.Email;
            loggedInCustomer.FirstName = customer.FirstName;
            loggedInCustomer.LastName = customer.LastName;
            loggedInCustomer.Phone = customer.Phone;
            db.SubmitChanges();
            Constants.loggedInCustomer = loggedInCustomer;
        }
    }
}
