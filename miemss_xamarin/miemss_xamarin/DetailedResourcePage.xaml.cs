using miemss_xamarin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailedResourcePage : ContentPage
    {
        public DetailedResourcePage()
        {
            InitializeComponent();

            initBrowser();


        }
        public void initBrowser()
        {
            //See IBaseUrl.cs for information on using IBaseUrl interface



            string path = DependencyService.Get<IBaseUrl>().Get();
            string url = Path.Combine(path, "HTML/MDMedicalProtocols2019.html");

        }
    }
}