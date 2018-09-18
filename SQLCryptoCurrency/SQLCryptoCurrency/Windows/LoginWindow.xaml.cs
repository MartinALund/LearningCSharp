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
using System.Windows.Shapes;

namespace SQLCryptoCurrency.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        LinqToSQLDatabaseHandler linqToSQLDatabaseHandler = new LinqToSQLDatabaseHandler();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            //Ændre login til email i stedet for brugernavn! Email som primary key?? Nah bare tjek om email findes når man opretter bruger.

            string username = tbUsername.Text;
            string password = pbPassword.Password;

            User fetchedUser = linqToSQLDatabaseHandler.GetUser(username);
            if (fetchedUser != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, fetchedUser.Password))
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
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
