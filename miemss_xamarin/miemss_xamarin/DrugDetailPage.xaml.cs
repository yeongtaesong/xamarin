using miemss_xamarin.Models;
using miemss_xamarin.ViewModel;
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
            var page = new DrugCalculator(drug);
            page.Title = "Adult Dosage";
            if (drug != null)
            {
                DrugCalculatorViewModel.Shared = new DrugCalculatorViewModel(drug);
                page.BindingContext = DrugCalculatorViewModel.Shared;
            }
            await Navigation.PushAsync(page);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            
            var drug = (Drug)DrugDetails.BindingContext;
            var page = new ChildDosagePage(drug);
            page.Title ="Pediatric Dosage";
            if (drug != null)
            {
                DrugCalculatorViewModel.Shared = new DrugCalculatorViewModel(drug);
                page.BindingContext = DrugCalculatorViewModel.Shared;
            }
            await Navigation.PushAsync(page);
        }
    }
}