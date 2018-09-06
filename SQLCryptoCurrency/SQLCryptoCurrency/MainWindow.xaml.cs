﻿using System;
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

namespace SQLCryptoCurrency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user;
        SqlHandler sqlHandler = new SqlHandler();
        public MainWindow()
        {
            InitializeComponent();
            user = new User
            {
                Username = "Test 2",
                Firstname = "Yaaas",
                Lastname = "Tasasd"
            };

        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            sqlHandler.InsertIntoUserDatabase(user);
        }
    }
}
