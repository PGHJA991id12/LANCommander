﻿using LANCommander.SDK.Models;
using Playnite.SDK;
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

namespace LANCommander.Playnite.Extension.Views
{
    public partial class Authentication : UserControl
    {
        private PlayniteLibraryPlugin Plugin;
        private ViewModels.Authentication Context { get { return (ViewModels.Authentication)DataContext; } }
        private PlayniteSettingsViewModel Settings { get; set; }

        public Authentication(PlayniteLibraryPlugin plugin)
        {
            Plugin = plugin;
            Settings = Plugin.GetSettings(false) as PlayniteSettingsViewModel;

            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                Authenticate();
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Authenticate();
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
            {
                ((ViewModels.Authentication)DataContext).Password = ((PasswordBox)sender).Password;
            }
        }

        private void Authenticate()
        {
            try
            {
                var response = Plugin.LANCommander.Authenticate(Context.UserName, Context.Password);

                Settings.AccessToken = response.AccessToken;
                Settings.RefreshToken = response.RefreshToken;

                // Probably unneeded, but why not be more secure?
                Context.Password = String.Empty;

                Plugin.SavePluginSettings(Settings);

                Window.GetWindow(this).Close();
            }
            catch (Exception ex)
            {
                Plugin.PlayniteApi.Dialogs.ShowErrorMessage(ex.Message);
            }
        }
    }
}
