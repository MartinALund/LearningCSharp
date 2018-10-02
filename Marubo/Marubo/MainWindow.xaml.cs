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
using Marubo.Model;
using Marubo.UserControls;

namespace Marubo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
        }

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "BtnCompanies":
                    ContentArea.Content = new CompanyUC();
                    break;
                case "BtnCustomers":
                    ContentArea.Content = new CustomerUC();
                    break;
                case "BtnEmployees":
                    ContentArea.Content = new EmployeeUC();
                    break;
                case "BtnOrders":
                    ContentArea.Content = new OrderUC();
                    break;
                case "BtnProducts":
                    ContentArea.Content = new ProductUC();
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