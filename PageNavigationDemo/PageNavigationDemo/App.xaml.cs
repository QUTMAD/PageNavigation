using PageNavigationDemo.ViewModels;
using PageNavigationDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PageNavigationDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var firstVm = new FirstViewModel();
            var firstPage = new FirstPage { ViewModel = firstVm };

            MainPage = new NavigationPage(firstPage);
        }

        protected override void OnStart()
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
