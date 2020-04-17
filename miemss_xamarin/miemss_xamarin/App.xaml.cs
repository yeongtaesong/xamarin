using miemss_xamarin.Data;
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
            Database.AddItems();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
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
