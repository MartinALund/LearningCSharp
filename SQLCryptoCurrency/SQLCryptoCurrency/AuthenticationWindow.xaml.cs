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

namespace SQLCryptoCurrency
{
    /// <summary>
    /// Interaction logic for AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : Window
    {

        LinqToSQLDatabaseHandler linqToSQLDatabaseHandler = new LinqToSQLDatabaseHandler();
        public AuthenticationWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {          
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            User fetchedUser = linqToSQLDatabaseHandler.GetUser(username);
            if (fetchedUser != null)
            {
                if(BCrypt.Net.BCrypt.Verify(password, fetchedUser.Password))
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
