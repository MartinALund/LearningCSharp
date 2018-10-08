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
using Marubo.Utils;

namespace Marubo.UserControls
{
    /// <summary>
    /// Interaction logic for ProfileUC.xaml
    /// </summary>
    public partial class ProfileUC : UserControl
    {
        Customer customer;
        LinqDatabaseHandler dbHandler = new LinqDatabaseHandler();
        public ProfileUC()
        {
            customer = Constants.loggedInCustomer;
            InitializeComponent();
            InputCustomerDataIntoTextBoxes();
        }

        private void BtnEditUser_Click(object sender, RoutedEventArgs e)
        {
            UpdateCustomer();
            MessageBox.Show(customer.CustomerId.ToString());
        }

        private void InputCustomerDataIntoTextBoxes()
        {
            TbFirstName.Text = customer.FirstName;
            TbLastName.Text = customer.LastName;
            TbAdress.Text = customer.Adress;
            TbZip.Text = customer.LocationZip.ToString();
            TbPhone.Text = customer.Phone;
            TbEmail.Text = customer.Email;
        }

        private void UpdateCustomer()
        {
            Customer customer = new Customer();
            customer.FirstName = TbFirstName.Text;
            customer.LastName = TbLastName.Text;
            customer.Adress = TbAdress.Text;
            customer.LocationZip = int.Parse(TbZip.Text);
            customer.Phone = TbPhone.Text;
            customer.Email = TbEmail.Text;
            dbHandler.UpdateCustomer(customer);
        }
    }
}
