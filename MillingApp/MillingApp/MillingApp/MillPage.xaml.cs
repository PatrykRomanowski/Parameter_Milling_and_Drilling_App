﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private void Frez1_Clicked(object sender, EventArgs e)
        {
            MillingParameter.cutterType = 1;
            Navigation.PushAsync(new StellGradePage());
            
        }

        private void Frez2_Clicked(object sender, EventArgs e)
        {
            MillingParameter.cutterType = 2;
            Navigation.PushAsync(new StellGradePage());
        }
    }

}