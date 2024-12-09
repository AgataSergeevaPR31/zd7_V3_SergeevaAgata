using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(0,0);

            MainPage = new NavigationPage(new Registration());
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
