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
    public partial class StellGradePage : ContentPage
    {
        public StellGradePage()
        {
            InitializeComponent();

            Label_Text.Text = MillingParameter.cutterType.ToString();


            
        }
    }
}