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
using miemss_xamarin.Models;
using ListView = Xamarin.Forms.ListView;

/*In order to edit items from list of Drugs, go to DrugData*/

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrugPage : ContentPage
    {
        public DrugPage()
        {

            this.BindingContext = new DrugsPageViewModel();
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        //Set listview 
        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        async void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            
            listView.ItemsSource = await App.Database.GetItemAsync(e.NewTextValue);

        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var drug = ((ListView)sender).SelectedItem as Drug;
            if (drug != null)
            {
                var page = new DrugDetailPage();
                page.BindingContext = drug;
                await Navigation.PushAsync(page);
            }
        }
       async private void Button_OnClicked(object sender, EventArgs e)
        {

            var page = new DrugCalculator();
            await Navigation.PushAsync(page);



        }
    }
}