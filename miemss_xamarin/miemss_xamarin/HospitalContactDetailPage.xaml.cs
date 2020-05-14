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
        // Open  Map to display a location
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
        // Open Phone Dialer to make a phone call

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
        //Open Browser to display a website
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
        // On address tapped, it will capture location
        private async void OnAddressTapGestureRecognizerTapped (object sender, EventArgs e)
        {
            var Label = (Label)sender;
            var locations = await Geocoding.GetLocationsAsync(Label.Text);
            var location = locations?.FirstOrDefault();

        // Execute to open map command
            await ExecuteMapCommand(location, Label.Text);
        }

        //On phone number tapped, it will capture phone number
        private async void OnPhoneTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var Label = (Label)sender;

        //Execute to open phone Command
            await ExecutePhoneCommand(Label.Text);
        }
        //On website tapped, it will capture weba address
        private async void OnWebTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var Label = (Label)sender;
            Uri myUri = new Uri(Label.Text); 
        //Execute to open web command
            await ExecuteWebCommand(Label.Text);
        }

        void ProcessException(Exception ex)
        {
            if (ex != null)
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}