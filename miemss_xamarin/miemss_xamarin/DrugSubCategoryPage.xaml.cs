using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using miemss_xamarin.SQLiteTables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrugSubCategoryPage : ContentPage
    {

        public DrugSubCategoryPage(List<AdultDosage> dosages)
        {
            InitializeComponent();
            MyListView.ItemsSource = dosages;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            AdultDosage dosage = e.Item as AdultDosage;
            var page = new DrugCalculator(dosage);
            page.Title = "Adult Dosage";

      
            await Navigation.PushAsync(page);



            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
