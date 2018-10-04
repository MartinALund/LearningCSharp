using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Marubo.UserControls;

namespace Marubo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer currentCustomer;
        public MainWindow(Customer loggedInCustomer)
        {
            currentCustomer = loggedInCustomer;
            InitializeComponent();
            CenterWindowOnScreen();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "CompanyUC":
                    ContentArea.Content = new CompanyUC();
                    break;
                case "CustomerUC":
                    ContentArea.Content = new CustomerUC();
                    break;
                case "ProductUC":
                    ContentArea.Content = new ProductUC();
                    break;
                case "EmployeeUC":
                    ContentArea.Content = new EmployeeUC();
                    break;
                case "OrderUC":
                    ContentArea.Content = new OrderUC();
                    break;
                case "ProfileUC":
                    ContentArea.Content = new ProfileUC(currentCustomer);
                    break;
                default:
                    break;
            }
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
}