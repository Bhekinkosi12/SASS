using SASS.ViewModels;
using SASS.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SASS.Views.Authentication;
using SASS.Views.Main;
using SASS.Views.Notification;
using SASS.Views.Profile;
using SASS.Views.Settings;

namespace SASS
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));
            Routing.RegisterRoute(nameof(MainPage),typeof(MainPage));
            Routing.RegisterRoute(nameof(NotificationPage), typeof(NotificationPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(BookPage), typeof(BookPage));

           
        }

    }
}
