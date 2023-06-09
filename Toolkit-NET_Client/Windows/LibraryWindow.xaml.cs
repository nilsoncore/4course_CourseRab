﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Toolkit_NET_Client.Models;

namespace Toolkit_NET_Client.Windows
{
    /// <summary>
    /// Логика взаимодействия для LibraryWindow.xaml
    /// </summary>
    public partial class LibraryWindow : Window
    {
        private User user;

        public LibraryWindow(User user)
        {
            InitializeComponent();
            this.user = user;

            this.UsernameTextBlock.Text = user.Username;
        }

        private void UsernameTextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var userWindow = new UserWindow(this.user);
            userWindow.Show();
            this.Close();
        }

        private void StoreTextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var storeWindow = new StoreWindow(this.user);
            storeWindow.Show();
            this.Close();
        }

        private void AppsListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void AppSearchTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
