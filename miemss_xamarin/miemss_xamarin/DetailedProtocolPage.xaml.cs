using miemss_xamarin.Models;
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
    public partial class DetailedProtocolPage : ContentPage
    {
        Stream fileStream;
        public DetailedProtocolPage()
        {
            InitializeComponent();
        }

        //When DetailedProtocolPage appears, PDF is displayed with Syncfusion PDF viewer
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var protocol = ((Protocol)this.BindingContext); //Get protocol user selected
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(protocol.Path);
            pdfViewerControl.LoadDocument(fileStream);  //Load the PDF

        }
    }
}