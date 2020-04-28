using miemss_xamarin.Data;
using miemss_xamarin.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    public partial class App : Application
    {

        static LocalDatabase database;
        public static LocalDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new LocalDatabase();
                }
                return database;
            }
        }

        public App()
        {
            
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQzODcxQDMxMzgyZTMxMmUzMFlDZEhoQjdVc2dCQVphRUkvYk15Q2hXS3VpQkdQMFVMa2kvbmdZZGp2UDQ9");

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Database.InitializeDatabase();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        async void CreateDatabaseItem()
        {

        }
    }
}
