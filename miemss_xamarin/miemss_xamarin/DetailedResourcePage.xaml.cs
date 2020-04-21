using miemss_xamarin.Models;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailedResourcePage : ContentPage
    {
        Stream fileStream;
        public DetailedResourcePage()
        {
            InitializeComponent();

            initBrowser();


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
    
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("miemss_xamarin.Assets.playbook.pdf");
            //Load the PDF
         pdfViewerControl.LoadDocument(fileStream);

        }


        public void initBrowser()
        {
            //See IBaseUrl.cs for information on using IBaseUrl interface



            string path = DependencyService.Get<IBaseUrl>().Get();
            string url = Path.Combine(path, "HTML/MDMedicalProtocols2019.html");

        }
    }
}