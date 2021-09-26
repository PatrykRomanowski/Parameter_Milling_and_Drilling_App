using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MillingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupSteelPage : ContentPage
    {
        public GroupSteelPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            MillingParameter.groupOfStell = 1;
            colorButton();
            stell.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }

        private async void stainless_stell_Clicked(object sender, EventArgs e)
        {
            MillingParameter.groupOfStell = 2;
            colorButton();
            stainless_stell.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }

        private async void cast_iron_Clicked(object sender, EventArgs e)
        {
            MillingParameter.groupOfStell = 3;
            colorButton();
            cast_iron.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }

        private async void non_ferrous_Clicked(object sender, EventArgs e)
        {
            MillingParameter.groupOfStell = 4;
            colorButton();
            non_ferrous.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }

        private async void heat_resistant_Clicked(object sender, EventArgs e)
        {
            MillingParameter.groupOfStell = 5;
            colorButton();
            heat_resistant.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }

        private async void hard_metals_Clicked(object sender, EventArgs e)
        {
            MillingParameter.groupOfStell = 6;
            colorButton();
            hard_metals.BackgroundColor = Color.Purple;
            await Task.Delay(1000);
            newPage();
        }


        public void colorButton()
        {
            stell.BackgroundColor = Color.Gold;
            stainless_stell.BackgroundColor = Color.Gold;
            cast_iron.BackgroundColor = Color.Gold;
            non_ferrous.BackgroundColor = Color.Gold;
            heat_resistant.BackgroundColor = Color.Gold;
            hard_metals.BackgroundColor = Color.Gold;
        }

        public void newPage()
        {
            Navigation.PushAsync(new ToolSizePage());
        }

    }
}