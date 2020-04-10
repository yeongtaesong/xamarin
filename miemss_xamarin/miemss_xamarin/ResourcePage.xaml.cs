using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResourcePage : ContentPage
    {
        public ResourcePage()
        {
          
            InitializeComponent();
            initBrowser();
        }
        public void initBrowser()
        {
            //See IBaseUrl.cs for information on using IBaseUrl interface
            string path = DependencyService.Get<IBaseUrl>().Get();
            string url = Path.Combine(path, "HTML/playbook.html");
            WebView.Source = url;
        }
    }

}