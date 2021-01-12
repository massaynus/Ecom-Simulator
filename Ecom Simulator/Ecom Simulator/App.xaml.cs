using Ecom_Simulator.Services;
using Ecom_Simulator.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecom_Simulator
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
