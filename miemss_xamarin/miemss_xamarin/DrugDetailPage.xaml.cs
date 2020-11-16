using miemss_xamarin.Models;
using miemss_xamarin.SQLiteTables;
using miemss_xamarin.ViewModel;
using System;
using miemss_xamarin.Data;
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
            var drug = (PrimaryDrug)DrugDetails.BindingContext;

            if (drug != null)
            {
                var page = new PDFDrugPage();
                page.BindingContext = drug;
                await Navigation.PushAsync(page);
            }
        }

        /// <summary>
        /// Navigate to Adult Dosage calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var drug = (PrimaryDrug)DrugDetails.BindingContext;

            Task<List<AdultDosage>> task = App.LocalDatabase.GetAdultDosages(drug);
            var drugCount = task.Result.Count();

            if (drugCount == 1 )
            {
                AdultDosage dosage = task.Result.FirstOrDefault();
                var page = new DrugCalculator(dosage);
                page.Title = "Adult Dosage";
                if (drug != null)
                {
                    // DrugCalculatorViewModel.Shared = new DrugCalculatorViewModel(drug);
                    // page.BindingContext = drug;
                }
                await Navigation.PushAsync(page);
            }
            else
            {
                var page = new DrugSubCategoryPage(task.Result);
                page.BindingContext = task.Result;

                await Navigation.PushAsync(page);
            }
        }

        /// <summary>
        /// navigate to Pediatric Dosage Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            var drug = (PrimaryDrug)DrugDetails.BindingContext;

            Task<List<ChildDosage>> task = App.LocalDatabase.GetChildDosages(drug);
            var drugCount = task.Result.Count();

            if (drugCount == 1)
            {
                ChildDosage dosage = task.Result.FirstOrDefault();
                var page = new ChildDosagePage(dosage);
                page.Title = "Child Dosage";
                if (drug != null)
                {
                    // DrugCalculatorViewModel.Shared = new DrugCalculatorViewModel(drug);
                    // page.BindingContext = drug;
                }
                await Navigation.PushAsync(page);
            }
            else
            {
                var page = new ChildDoseSubCategoryPage(task.Result);
                page.BindingContext = task.Result;

                await Navigation.PushAsync(page);
            }
        }
    }
}