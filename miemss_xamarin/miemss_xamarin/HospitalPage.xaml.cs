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
            //BindingContext = hospitalContact;


            var hospitalsResults = hospitalContact.HospitalContacts;
            var hospitalsGroupedByRegion = hospitalsResults.GroupBy(HospitalContact => HospitalContact.Region);

            foreach (var group in hospitalsGroupedByRegion)
            {
                System.Console.WriteLine("Hospitals from " + group.Key + ":");
                RegionList.Add(new RegionGroup(group.Key, group));

                /**
                foreach (var hospital in group)
                {
                    System.Console.WriteLine("* region: " + hospital.Region + " name: " + hospital.Name);
                } 
                **/
            }

            foreach (var hospital in RegionList)
            {
                System.Console.WriteLine("* region: " + hospital.RegionName);
            }

            BindingContext = this;

        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
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

