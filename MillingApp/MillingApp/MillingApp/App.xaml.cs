using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text;
using System.IO;
using System.Reflection;

namespace MillingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());


          //  NavigationPage.SetHasBackButton(this, false);

            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Gold;

           
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
