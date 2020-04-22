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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var protocol = ((Protocol)this.BindingContext);
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(protocol.Path);
            //Load the PDF
            pdfViewerControl.LoadDocument(fileStream);

        }
    }
}