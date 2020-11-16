using miemss_xamarin.Data;
using miemss_xamarin.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using PCLStorage;
using SQLite.Net.Interop;

namespace miemss_xamarin
{
    public partial class App : Application
    {
        public string DatabasePath;
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

        public static MiemssLocalDatabase LocalDatabase { get; private set; }

        public App(string dbPath, ISQLitePlatform sqlitePlatform)
        {
            LocalDatabase = new MiemssLocalDatabase(dbPath);         
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQzODcxQDMxMzgyZTMxMmUzMFlDZEhoQjdVc2dCQVphRUkvYk15Q2hXS3VpQkdQMFVMa2kvbmdZZGp2UDQ9");

            MainPage = new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
