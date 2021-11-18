using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    public partial class App : Application
    {
        public static string _databaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            //this creates a parent page that displays the main page and utilize a Navigation page
            MainPage = new NavigationPage(new MainPage());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            _databaseLocation = databaseLocation;

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
