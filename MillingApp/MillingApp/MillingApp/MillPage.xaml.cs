using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MillingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MillPage : ContentPage
    {

        public MillPage()
        {
            InitializeComponent();
        }

        private async void Frez1_Clicked(object sender, EventArgs e)
        {
            MillingParameter.cutterType = 1;
            colorButton();
            Frez1.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }

        private async void Frez2_Clicked(object sender, EventArgs e)
        {
            MillingParameter.cutterType = 2;
            colorButton();
            Frez2.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }
        public void colorButton()
        {
            Frez1.BackgroundColor = Color.Gold;
            Frez2.BackgroundColor = Color.Gold;
        }

        public void newPage()
        {
            Navigation.PushAsync(new GroupSteelPage());
        }
    }



}