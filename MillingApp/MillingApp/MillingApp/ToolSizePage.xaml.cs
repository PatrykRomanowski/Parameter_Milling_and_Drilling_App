using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace MillingApp

{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ToolSizePage : ContentPage
    {

        bool sizeClick = false;
        bool flutesClick = false;


        public ToolSizePage()
        {
            InitializeComponent();

        }

        private void ButtonTwoFlutes_Clicked(object sender, EventArgs e)
        {
            if (MillingParameter.numberofFlutes != 2)
            {
                Button2Flutes.BackgroundColor = Color.Purple;
                Button3Flutes.BackgroundColor = Color.Gold;
                Button4Flutes.BackgroundColor = Color.Gold;
                flutesClick = true;
                MillingParameter.numberofFlutes = 2;
                nextPage();
            }
        }

        private void ButtonThreeFlutes_Clicked(object sender, EventArgs e)
        {
            if (MillingParameter.numberofFlutes != 3)
            {
                Button3Flutes.BackgroundColor = Color.Purple;
                Button2Flutes.BackgroundColor = Color.Gold;
                Button4Flutes.BackgroundColor = Color.Gold;
                flutesClick = true;
                MillingParameter.numberofFlutes = 3;
                nextPage();
            }
        }

        private void ButtonFourFlutes_Clicked(object sender, EventArgs e)
        {
            if (MillingParameter.numberofFlutes != 4)
            {
                Button4Flutes.BackgroundColor = Color.Purple;
                Button3Flutes.BackgroundColor = Color.Gold;
                Button2Flutes.BackgroundColor = Color.Gold;
                flutesClick = true;
                MillingParameter.numberofFlutes = 4;
                nextPage();
            }
        }
        private void Button1mmToll_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 1;
            MillingParameter.diameterTool = 1;
            colorbuttonAndBoolClick();
            Button1mm.BackgroundColor = Color.Purple;
            nextPage();
        }
        private void Button1_5mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 2;
            MillingParameter.diameterTool = 1.5;
            colorbuttonAndBoolClick();
            Button15mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button2mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 3;
            MillingParameter.diameterTool = 2;
            colorbuttonAndBoolClick();
            Button2mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button2_5mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 4;
            MillingParameter.diameterTool = 2.5;
            colorbuttonAndBoolClick();
            Button25mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button3mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 5;
            MillingParameter.diameterTool = 3;
            colorbuttonAndBoolClick();
            Button3mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button4mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 6;
            MillingParameter.diameterTool = 4;
            colorbuttonAndBoolClick();
            Button4mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button5mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 7;
            MillingParameter.diameterTool = 5;
            colorbuttonAndBoolClick();
            Button5mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button6mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 8;
            MillingParameter.diameterTool = 6;
            colorbuttonAndBoolClick();
            Button6mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button8mm_Clicked(object sender, EventArgs e)
        {
            Button8mm.BackgroundColor = Color.Purple;
            MillingParameter.diameterTool = 8;
            MillingParameter.sizeTool = 9;
            colorbuttonAndBoolClick();
            nextPage();
        }

        private void Button10mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 10;
            MillingParameter.diameterTool = 10;
            colorbuttonAndBoolClick();
            Button10mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button12mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 11;
            MillingParameter.diameterTool = 12;
            colorbuttonAndBoolClick();
            Button12mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button14mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 12;
            MillingParameter.diameterTool = 14;
            colorbuttonAndBoolClick();
            Button14mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button16mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 13;
            MillingParameter.diameterTool = 16;
            colorbuttonAndBoolClick();
            Button16mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button18mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 14;
            MillingParameter.diameterTool = 18;
            colorbuttonAndBoolClick();
            Button18mm.BackgroundColor = Color.Purple;
            nextPage();
        }

        private void Button20mm_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 15;
            MillingParameter.diameterTool = 20;
            colorbuttonAndBoolClick();
            Button20mm.BackgroundColor = Color.Purple;
            nextPage();
        }
        public void colorbuttonAndBoolClick()
        {
            sizeClick = true;
            Button1mm.BackgroundColor = Color.Gold;
            Button15mm.BackgroundColor = Color.Gold;
            Button2mm.BackgroundColor = Color.Gold;
            Button25mm.BackgroundColor = Color.Gold;
            Button3mm.BackgroundColor = Color.Gold;
            Button4mm.BackgroundColor = Color.Gold;
            Button5mm.BackgroundColor = Color.Gold;
            Button6mm.BackgroundColor = Color.Gold;
            Button8mm.BackgroundColor = Color.Gold;
            Button10mm.BackgroundColor = Color.Gold;
            Button12mm.BackgroundColor = Color.Gold;
            Button14mm.BackgroundColor = Color.Gold;
            Button16mm.BackgroundColor = Color.Gold;
            Button18mm.BackgroundColor = Color.Gold;
            Button20mm.BackgroundColor = Color.Gold;
        }

        public void nextPage()
        {
            if (flutesClick == true && sizeClick == true)
            {
                Thread.Sleep(500);
                Navigation.PushAsync(new resoultPage());
            }
        }

    }
}
