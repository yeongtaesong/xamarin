using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatsPage : ContentPage
    {
        public ChatsPage()
        {
            InitializeComponent();
            WebView.Source = "https://www.miemssalert.com/chats/Default.aspx?hdRegion=3&hdReportRegion=III&hdReport=Hospital%20Summary%20Reportr";
        }
    }
}