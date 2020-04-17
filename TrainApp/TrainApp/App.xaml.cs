using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TrainApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            AppCenter.Start("e3951cda-d38e-4518-b600-cd5c00d2f390", typeof(Push));

            //MainPage = new NavigationPage(new Registered());
            MainPage = new NavigationPage(new MainPage());
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
