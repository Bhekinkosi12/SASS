﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSApp.Views.Institutions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SASSApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(InstitutionsPage), typeof(InstitutionsPage));
        }
    }
}