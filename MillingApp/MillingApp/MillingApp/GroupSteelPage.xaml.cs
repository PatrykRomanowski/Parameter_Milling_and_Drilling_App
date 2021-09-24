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

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToolSizePage());
            MillingParameter.groupOfStell = 2;
        }
    }
}