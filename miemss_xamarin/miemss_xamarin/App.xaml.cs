using miemss_xamarin.Data;
using miemss_xamarin.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

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
            AppCenter.Start("android=dbd99ee7-6e16-4ee5-b666-5a69b0077fc1;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
