using miemss_xamarin.Models;
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
        //Button for dosage calculation
        private void Button_OnClicked(object sender, EventArgs e)
        {

            double dosage = Convert.ToDouble(Dosage.Text);
            double weight = Convert.ToDouble(Weight.Text);

            string unit = (string)CalculateButton.BindingContext;
           if (unit == "lb")
            {
                double calculation = dosage * (weight * 0.45359237);
                calculation = Math.Round(calculation, 3);
                CalculationLabel.Text = "Calculated dosage: " + calculation.ToString() + "mg";

            } else if (unit == "kg")
            {
                double calculation = dosage * weight;
                calculation = Math.Round(calculation, 3);
                CalculationLabel.Text = "Calculated dosage: " + calculation.ToString() + "mg";
            }
            else
            {
                DisplayAlert("Message", "Please select a unit.", "ok");
            }
        }

        //Button to show/hide calculator
       async private void Calculator_OnClicked(object sender, EventArgs e)
        {



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
    }
}