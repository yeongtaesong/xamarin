﻿using miemss_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrugDetailPage : ContentPage
    {
        public DrugDetailPage()
        {
            InitializeComponent();
        }



        //Button to navigate to Drug PDF information
        async private void Information_OnClicked(object sender, EventArgs e)
        {
            var drug = (Drug)DrugDetails.BindingContext;

            if (drug != null)
            {
                var page = new PDFDrugPage();
                page.BindingContext = drug;
                await Navigation.PushAsync(page);
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var drug = (Drug)DrugDetails.BindingContext;
            var page = new DrugCalculator();
            page.Title = "Adult Dosage";
            if (drug != null)
            {
                page.BindingContext = drug;
            }
            await Navigation.PushAsync(page);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var page = new ChildDosagePage();
            var drug = (Drug)DrugDetails.BindingContext;
            page.Title = "Child Dosage";
            if (drug != null)
            {
                page.BindingContext = drug;
            }
            await Navigation.PushAsync(page);
        }
    }
}