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
        AuthenticationWindow authWindow;
        ContentControl authControl;

        public CreateUserUC(AuthenticationWindow parentWindow)
        {
            authWindow = parentWindow;
            authControl = parentWindow.ContentArea;
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

            //Tilføj mere validering her!
            string password = PbPassword.Password.ToString();
            string confirmPassword = PbPasswordConfirm.Password.ToString();
            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Password stemmer ikke overens");
                return;
            }

            Customer customer = new Customer();
            customer.FirstName = TbFirstName.Text;
            customer.LastName = TbLastName.Text;
            customer.Adress = TbAdress.Text;
            customer.Phone = TbPhone.Text;
            customer.Email = TbEmail.Text;
            customer.LocationZip = int.Parse(TbZip.Text);
            customer.Password = BCrypt.Net.BCrypt.HashPassword(password);
            customer.FailedLoginAttempts = 0;
            dbHandler.InsertIntoCustomerDatabase(customer);
            authWindow.Content = new LoginUC(authWindow);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            authControl.Content = new AuthenticateUC(authWindow);
        }
    }
}
