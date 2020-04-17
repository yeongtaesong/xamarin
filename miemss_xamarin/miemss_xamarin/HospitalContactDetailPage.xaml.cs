using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using miemss_xamarin.Models;



namespace miemss_xamarin
{
    public partial class HospitalContactDetailPage : ContentPage
    {
        public HospitalContactDetailPage()
        {
            InitializeComponent();

        }

        async Task ExecuteMapCommand(Location location, string address)
        {
            try
            {
                var options = new MapLaunchOptions { Name = address };
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }
        async Task ExecutePhoneCommand(string phoneNumber)
        {
            try
            {
                PhoneDialer.Open(phoneNumber);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }
        async Task ExecuteWebCommand(string website)
        {
            try
            {
                Uri myURL = new Uri(website);
                await Launcher.OpenAsync(myURL);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }

        private async void OnAddressTapGestureRecognizerTapped (object sender, EventArgs e)
        {
            var Label = (Label)sender;
            var locations = await Geocoding.GetLocationsAsync(Label.Text);
            var location = locations?.FirstOrDefault();

            await ExecuteMapCommand(location, Label.Text);
        }

        private async void OnPhoneTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var Label = (Label)sender;

            await ExecutePhoneCommand(Label.Text);
        }

        private async void OnWebTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var Label = (Label)sender;
            Uri myUri = new Uri(Label.Text); 

            await ExecuteWebCommand(Label.Text);
        }

        void ProcessException(Exception ex)
        {
            if (ex != null)
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}