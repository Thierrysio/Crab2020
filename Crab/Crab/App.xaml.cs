﻿using Crab.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Crab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MaintenanceView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
