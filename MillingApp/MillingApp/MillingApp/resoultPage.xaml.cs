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

            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            var text = "";

            Stream stream = assembly.GetManifestResourceStream("MillingApp.fileTxt.fanarOpti230.txt");


            InitializeComponent();

            switch(MillingParameter.cutterType)
            {
                case 1:
                    stream = assembly.GetManifestResourceStream("MillingApp.fileTxt.fanarOpti230.txt");
                    break;
                case 2:
                     stream = assembly.GetManifestResourceStream("MillingApp.fileTxt.hsseOpti.txt");
                    break;
            }


            // Stream stream = assembly.GetManifestResourceStream("MillingApp.fileTxt.fanarOpti230.txt");
        
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

            resoultVc.Text = toolSize[0];
            resoultFz.Text = toolSize[MillingParameter.sizeTool];
            var resoulN = (int)millResoult.resoultN(Int32.Parse(toolSize[0]));
            resoultN.Text = resoulN.ToString();
            var resoultVf = (int)millResoult.resoultVf(Convert.ToDouble(toolSize[MillingParameter.sizeTool]), resoulN);
            resoultVfVf.Text = resoultVf.ToString();
                }
       
    }
}