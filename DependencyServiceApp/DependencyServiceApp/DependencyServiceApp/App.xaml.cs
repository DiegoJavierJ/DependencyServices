using DependencyServiceApp.Services;
using DependencyServiceApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DependencyServiceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new CustomPage();
            MainPage = new TabbedCustomPage();

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
