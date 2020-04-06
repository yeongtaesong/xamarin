using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;

/*TODO: */

namespace miemss_xamarin
{
    

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            initBrowser();

        }

        public void initBrowser()
        {
            string path = DependencyService.Get<IBaseUrl>().Get();
            string url = Path.Combine(path, "HTML/page1.html");
            WebView.Source = url;
        }

    }


}

