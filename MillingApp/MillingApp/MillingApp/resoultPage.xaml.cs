using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;

namespace MillingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class resoultPage : ContentPage
    {
    
        public resoultPage()
        {
            MillingParameter millResoult = new MillingParameter();

            InitializeComponent();

            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("MillingApp.fileTxt.fanarOpti230.txt");
            var text = "";
        
            using (var reader = new StreamReader(stream))
            {
               for (int i=0; i<MillingParameter.groupOfStell; i++)
                {
                    text = reader.ReadLine();
                }
            }
            if (string.IsNullOrEmpty(text))
            {
                DisplayAlert("ALERT", "this tool cannot be used for this type of steel ", "OK");
            }
            string[] toolSize = text.Split(new char[] { ' ' });
           

           // resoultVc.Text = toolSize[MillingParameter.cutterType + 1];

        }



    }
}