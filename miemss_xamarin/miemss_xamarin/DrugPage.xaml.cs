﻿using System;
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
using miemss_xamarin.SQLiteTables;

/*In order to edit items from list of Drugs, go to DrugData*/
namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrugPage : ContentPage
    {
        public DrugPage()
        {
            InitializeComponent();
        }

        //Drug list will display items from ALS or BLS list on appearing
        protected override async void OnAppearing()
        {
            base.OnAppearing();
           listView.ItemsSource = ((List<PrimaryDrug>)this.BindingContext);
            List<PrimaryDrug> list = (List<PrimaryDrug>)this.BindingContext;
            string category = list[0].Category;
            DrugContentPage.Title = category + " Medications";
        }

        //Set listview 
        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        //As user adds input to search, druglist updates based on text input
        async void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            List<PrimaryDrug> list = (List<PrimaryDrug>)this.BindingContext;
            string category = list[0].Category;

            listView.ItemsSource = await App.Database.GetItemByCategory(e.NewTextValue, category);

        }

        //On item selected, user will be redirected to DrugDetailedPage of item selected
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var drug = ((ListView)sender).SelectedItem as PrimaryDrug;
            if (drug != null)
            {
                var page = new DrugDetailPage();
                page.BindingContext = drug;
                page.Title = drug.Category + " Medication";
                await Navigation.PushAsync(page);
            }
        }
    }
}