<<<<<<< Updated upstream
﻿using miemss_xamarin.Models;
using System;
=======
﻿using System;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
    

>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            var protocol = ((Protocol)this.BindingContext);
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(protocol.Path);
            //Load the PDF
            pdfViewerControl.LoadDocument(fileStream);

        }

=======
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("miemss_xamarin.Assets.playbook.pdf");
            //Load the PDF
            pdfViewerControl.LoadDocument(fileStream);
        }
>>>>>>> Stashed changes
    }
}