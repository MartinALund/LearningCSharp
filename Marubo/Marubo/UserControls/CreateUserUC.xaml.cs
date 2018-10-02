using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Marubo.UserControls
{
    /// <summary>
    /// Interaction logic for CreateUserUC.xaml
    /// </summary>
    public partial class CreateUserUC : UserControl
    {
        LinqDatabaseHandler dbHandler = new LinqDatabaseHandler();

        public CreateUserUC()
        {
            InitializeComponent();
        }

        private void btnConfirmUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateCustomer();              
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
