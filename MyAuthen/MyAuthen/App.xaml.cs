using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAuthen
{
    public partial class App : Application
    {
        public static string DatabasPath;

        public App(string databasPath)
        {
            InitializeComponent();

            DatabasPath = databasPath;

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
