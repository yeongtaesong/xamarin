using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using miemss_xamarin.Models;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EMRCPage : ContentPage
    {
        //Display Important Numbers 
        public EMRCPage()
        {
            InitializeComponent();
            //Set listview from EMRCData from "Models" folder
            listView.ItemsSource = EMRCData.EMRCs;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            /// DO NOTHING
        }

        //Open Phone Dialer to make a call
        async void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var resource = ((ListView)sender).SelectedItem as EMRC;

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

        //Capture a phone numbers from the list 
        private async void OnPhoneTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var Label = (Label)sender;

            await ExecutePhoneCommand(Label.Text);
        }
        void ProcessException(Exception ex)
        {
            if (ex != null)
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }

    }
}