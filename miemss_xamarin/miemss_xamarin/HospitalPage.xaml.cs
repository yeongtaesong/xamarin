using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;
using miemss_xamarin.Models;
using ListView = Xamarin.Forms.ListView;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HospitalPage : ContentPage
    {
        public ObservableCollection<RegionGroup> RegionList { get; set; } = new ObservableCollection<RegionGroup>();

        public HospitalPage()
        {
            InitializeComponent();

            var hospitalContact = new HospitalContactViewModel();
            var hospitalsResults = hospitalContact.HospitalContacts;
            var hospitalsGroupedByRegion = hospitalsResults.GroupBy(HospitalContact => HospitalContact.Region);

            RegionList.Clear();
            foreach (var group in hospitalsGroupedByRegion)
            {
                RegionList.Add(new RegionGroup(group.Key, group));
            }

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            // DO NOTHING
        }
        
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var hospitalcontact = ((ListView)sender).SelectedItem as HospitalContact;
            if (hospitalcontact != null)
            {
                var page = new HospitalContactDetailPage();
                page.BindingContext = hospitalcontact;
                await Navigation.PushAsync(page);
            }
        }
    }
}

