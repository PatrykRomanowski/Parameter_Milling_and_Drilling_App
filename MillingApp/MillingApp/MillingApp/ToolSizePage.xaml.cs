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

    public partial class ToolSizePage : ContentPage
    {
        // tutaj mam stworzyć instancję klasy i odpowiedni konstruktor
        bool sizeClicked = false;

        public ToolSizePage()
        {
            InitializeComponent();
        }

        private void Button1mmToll_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 1;
            Navigation.PushAsync(new resoultPage());
        }

        private void ButtonTwoFlutes_Clicked(object sender, EventArgs e)
        {
            if (MillingParameter.numberofFlutes != 2)
            {
                Button2Flutes.BackgroundColor = Color.Purple;
                Button3Flutes.BackgroundColor = Color.Gold;
                Button4Flutes.BackgroundColor = Color.Gold;

                MillingParameter.numberofFlutes = 2;
                FlutesClicked = true;
            }
        }

        private void ButtonThreeFlutes_Clicked(object sender, EventArgs e)
        {
            if (MillingParameter.numberofFlutes != 3)
            {
                Button3Flutes.BackgroundColor = Color.Purple;
                Button2Flutes.BackgroundColor = Color.Gold;
                Button4Flutes.BackgroundColor = Color.Gold;

                MillingParameter.numberofFlutes = 3;
                FlutesClicked = true;
            }

        }

        private void ButtonFourFlutes_Clicked(object sender, EventArgs e)
        {
            if (MillingParameter.numberofFlutes != 4)
            {
                Button4Flutes.BackgroundColor = Color.Purple;
                Button3Flutes.BackgroundColor = Color.Gold;
                Button2Flutes.BackgroundColor = Color.Gold;

                FlutesClicked = true;
                MillingParameter.numberofFlutes = 4;
            }
        }
        
       
    }
}