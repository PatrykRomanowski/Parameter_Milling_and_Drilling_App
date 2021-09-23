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
        public ToolSizePage()
        {
            InitializeComponent();
        }

        private void Button1mmToll_Clicked(object sender, EventArgs e)
        {
            MillingParameter.sizeTool = 1;
            Navigation.PushAsync(new resoultPage());
        }
    }
}