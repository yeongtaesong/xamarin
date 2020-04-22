﻿using miemss_xamarin.Models;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResourcePage : ContentPage
    {
        Stream fileStream;
        public ResourcePage()
        {
            InitializeComponent();
            listView.ItemsSource = ResourceData.Resources;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            /// DO NOTHING
        }

       async void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var resource = ((ListView)sender).SelectedItem as Resource;

            if(resource.IsWebView)
            {
                var page = new WebViewPage();
                page.BindingContext = resource;
                await Navigation.PushAsync(page);
            } else
            {
                var page = new PDFView();
                page.BindingContext = resource;
                await Navigation.PushAsync(page);

            }
        }

    }
}