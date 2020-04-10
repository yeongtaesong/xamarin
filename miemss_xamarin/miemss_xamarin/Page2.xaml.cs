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

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            //go to initBrowser() function to change html file name
            initBrowser();

        }

        //Set webview reference to local html file
        public void initBrowser()
        {
            //See IBaseUrl.cs for information on using IBaseUrl interface
            string path = DependencyService.Get<IBaseUrl>().Get();
            string url = Path.Combine(path, "HTML/healthcare/index.html");
            WebView.Source = url;
        }
    }
}
