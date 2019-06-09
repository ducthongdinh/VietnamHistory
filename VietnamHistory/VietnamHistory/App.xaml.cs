using VietnamHistory.Services;
using VietnamHistory.Views;
using Xamarin.Forms;
using VietnamHistory.Data;
using System.Collections.Generic;
using VietnamHistory.Models;
using System.Diagnostics;

namespace VietnamHistory
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();            
        }

        async protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
