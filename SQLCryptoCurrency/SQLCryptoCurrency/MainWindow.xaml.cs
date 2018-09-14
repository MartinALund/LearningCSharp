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
using SQLCryptoCurrency.Models;
using BCrypt.Net;

namespace SQLCryptoCurrency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user;
        UserDatabase userDB = new UserDatabase();
        LinqToSQLDatabaseHandler linqToSQLDatabaseHandler = new LinqToSQLDatabaseHandler();
        public MainWindow()
        {
            InitializeComponent();
            user = new User
            {
                Username = "Testbruger",
                Firstname = "Test",
                Lastname = "Bruger",
                Password = "test1234",
                Email = "test@test.dk",
                FailedLoginAttempts = 0
            };
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            linqToSQLDatabaseHandler.InsertIntoUserDatabase(user); 
        }
    }
}
