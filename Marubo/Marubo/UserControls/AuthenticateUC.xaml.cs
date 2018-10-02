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
    /// Interaction logic for AuthenticateUC.xaml
    /// </summary>
    public partial class AuthenticateUC : UserControl
    {
        ContentControl authControl;
        AuthenticationWindow authWindow;
        public AuthenticateUC(AuthenticationWindow parentWindow)
        {
            authWindow = parentWindow;
            authControl = parentWindow.ContentArea;
            InitializeComponent();
        }
        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            authControl.Content = new CreateUserUC();

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            authControl.Content = new LoginUC(authWindow);
        }
    }
}
