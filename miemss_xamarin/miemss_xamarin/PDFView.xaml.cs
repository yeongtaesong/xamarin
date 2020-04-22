using miemss_xamarin.Models;
using Syncfusion.SfPdfViewer.XForms;
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
    public partial class PDFView : ContentPage
    {
        Stream fileStream;
        public PDFView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var resource = ((Resource)this.BindingContext);
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(resource.Path);
            //Load the PDF
            pdfViewerControl.LoadDocument(fileStream);

        }


    }
}