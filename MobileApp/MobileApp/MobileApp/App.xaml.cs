using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    public partial class App : Application
    {
        public static string FilePath;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TermList())
            {
                BarBackgroundColor = Color.FromHex("#003057"),
                BarTextColor = Color.White
            };
            
        }
        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TermList())
            {
                BackgroundColor = Color.FromHex("#003057"),
                BarTextColor=Color.White
            };
            FilePath = filePath;

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
