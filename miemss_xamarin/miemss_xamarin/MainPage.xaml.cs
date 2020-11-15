using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using miemss_xamarin.Data;
using miemss_xamarin.Interfaces;
using miemss_xamarin.SQLiteTables;
using SQLite;
using Xamarin.Forms;

namespace miemss_xamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer

    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            TestDatabase();
        }

        public async void TestDatabase()
        {
            Task<List<ChildDosage>> task = App.LocalDatabase.GetChildDosages();
            Debug.WriteLine(task.Result);
        }

        protected override void OnAppearing()
        {
            //Initialize database when app starts up. 
            App.Database.InitializeDatabase();
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        //Protocol Page
        private async void ProtocolPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProtocolsPage());
        }

        //Hospital Directories Page
        private async void HospitalDirectories_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HospitalPage());
        }

        //EMS Resources
        private async void EMSResourcePage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResourcePage());
        }

        //Medications 
        private async void MedicationsPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrugSelectionPage());
        }

        //Regions
        private async void RegionsPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegionPage());
        }

        //Button for Calendar 
        private async void CalendarPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarPage() );
        }

        //CHATS-Alert
        private async void ChatsPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatsPage());
        }

        //Important Numbers Page
        private async void NumbersPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EMRCPage());
        }

    }
}
