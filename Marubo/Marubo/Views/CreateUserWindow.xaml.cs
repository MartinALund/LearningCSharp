using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Marubo.Model;

namespace Marubo.Views
{
    /// <summary>
    /// Interaction logic for CreateUserWindow.xaml
    /// </summary>
    public partial class CreateUserWindow : Window
    {

        LinqDatabaseHandler dbHandler = new LinqDatabaseHandler();
        public CreateUserWindow()
        {
            InitializeComponent();

        }

        private void btnConfirmUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateCustomer();
                AuthenticateWindow window = new AuthenticateWindow();
                window.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Noget gik galt, prøv igen!");
            }
        }

        public void CreateCustomer()
        {
            Customer customer = new Customer();
            customer.FirstName = tbFirstName.Text;
            customer.LastName = tbLastName.Text;
            customer.Adress = tbAdress.Text;
            customer.Phone = tbPhone.Text;
            customer.Email = tbEmail.Text;
            customer.LocationZip = int.Parse(tbZip.Text);
            customer.Password = BCrypt.Net.BCrypt.HashPassword(tbPassword.Password.ToString());
            customer.FailedLoginAttempts = 0;
            dbHandler.InsertIntoCustomerDatabase(customer);

        }
    }
}
