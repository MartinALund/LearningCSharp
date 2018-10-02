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
    /// Interaction logic for LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        AuthenticationWindow authWindow;
        LinqDatabaseHandler dbHandler = new LinqDatabaseHandler();
        public LoginUC(AuthenticationWindow parentWindow)
        {
            authWindow = parentWindow;
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Godkendt login, gå til main

            string email = TbEmail.Text;
            string password = PbPassword.Password;
            Customer fetchedUser = dbHandler.GetCustomer(email);
            if (fetchedUser != null)
            {
                MessageBox.Show(fetchedUser.Email);
                if (BCrypt.Net.BCrypt.Verify(password, fetchedUser.Password))
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    authWindow.Hide();
                }
                else
                {
                    // Wrong password!
                    MessageBox.Show("Wrong information entered, try again!");
                }
            }
            else
            {
                //Wrong username!
                MessageBox.Show("Wrong information entered, try again!");
            }
        }
    }
}
