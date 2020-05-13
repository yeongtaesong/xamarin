using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrugSelectionPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public DrugSelectionPage()
        {
            InitializeComponent();
        }

        private async void ALSList_Tapped(object sender, EventArgs e)
        {
            var page = new DrugPage();
            page.BindingContext = await App.Database.GetItemsByCategory("ALS");
            await Navigation.PushAsync(page);
        }

        private async void BLSList_Tapped(object sender, EventArgs e)
        {
            var page = new DrugPage();
            page.BindingContext = await App.Database.GetItemsByCategory("BLS");
            await Navigation.PushAsync(page);
        }
    }
}
