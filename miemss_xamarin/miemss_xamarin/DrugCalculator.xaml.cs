using miemss_xamarin.Models;
using miemss_xamarin.SQLiteTables;
using miemss_xamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrugCalculator : ContentPage
    {
        PrimaryDrug Drug;
        List<AdultDosage> dosages;
        AdultDosage dosage;

        public DrugCalculator(AdultDosage dosage)
        {
            InitializeComponent();

            //Task<List<AdultDosage>> task = App.LocalDatabase.GetAdultDosages(drug);

            //dosages = task.Result;
            this.dosage = dosage;

            BindingContext = dosage;
            if (dosage.HasMaxDose)
            {
                max.Text = "Maximum Dose: " + dosage.MaxDose + " " + dosage.Unit;
            }



        }
        //Button for dosage calculation
        private void Button_OnClicked(object sender, EventArgs e)
        {
            //checks if there is input when button is clicked
            if (Dosage.Text == "" || Weight.Text == "")
            {
                DisplayAlert("Error", "Field is empty.", "Ok");
                return;
            } else
            {
                decimal value;

                if (!Decimal.TryParse(Dosage.Text, out value) || !Decimal.TryParse(Weight.Text, out value ))
                {
                    DisplayAlert("Error", "Field should not contain a negative value", "Ok");
                    return;
                }

                double dosage = Convert.ToDouble(Dosage.Text);
                double weight = Convert.ToDouble(Weight.Text);
                Calculate(dosage, weight);

            }
        }

        //Calculate dosage based on kg or lb 
        private void Calculate(double dosage, double weight)
        {
             
            double calculation = 0;

            //makes calculation based on unit selected. If no unit is selected, error message is displayed
            string unit = (string)CalculateButton.BindingContext;
            if (unit == "lb")
            {
                calculation = dosage * (weight * 0.45359237);
                calculation = Math.Round(calculation, 3);
                CalculationLabel.Text = "Calculated dosage: " + calculation.ToString() + " " + (string)CalculationLabel.BindingContext;

            }
            else if (unit == "kg")
            {
                calculation = dosage * weight;
                calculation = Math.Round(calculation, 3);
                CalculationLabel.Text = "Calculated dosage: " + calculation.ToString() + " " + (string)CalculationLabel.BindingContext;
            }
            else
            {
                DisplayAlert("Message", "Please select a unit.", "ok");
            }
            if (this.dosage.HasMaxDose)
            {
                if (calculation > this.dosage.MaxDose)
                {
                    CalculationLabel.Text = "Calculated dosage: " + " NA " + (string)CalculationLabel.BindingContext;
                    string alertMessage = "Dosage is too high. Maximum dosage is " + this.dosage.MaxDose + " " + this.dosage.Unit;
                    DisplayAlert("Message", alertMessage, "ok");
                    return;
                }

            }

        }
        //End calculator function ----
    }
}