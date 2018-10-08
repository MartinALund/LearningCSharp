using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Marubo.Interfaces;
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
            MessageBox.Show("Destructor called");
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
        }
    }
}
