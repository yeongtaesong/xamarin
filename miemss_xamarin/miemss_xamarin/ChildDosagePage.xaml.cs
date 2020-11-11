using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using miemss_xamarin.Models;
using miemss_xamarin.SQLiteTables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
   
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChildDosagePage : ContentPage
    {
        PrimaryDrug Drug;
        List<ChildDosage> dosages;
        ChildDosage dosage;

        public ChildDosagePage(ChildDosage drug)
        {
            InitializeComponent();        
            //Task<List<ChildDosage>> task = App.LocalDatabase.GetChildDosages(drug);

            //dosages = task.Result;
            this.dosage = drug;

            BindingContext = dosage;
            if (dosage.HasMaxDose)
            {
                max.Text = "Maximum Dose: " + dosage.MaxDose + " " + dosage.DoseUnit;
            }
        }
        //Button for dosage calculation
        private void Button_OnClicked(object sender, EventArgs e)
        {

            if (Dosage.Text == "" || Weight.Text == "")
            {
                DisplayAlert("Error", "Please type in a number.", "Ok");
            }
            else
            {
                decimal value;

                if (!Decimal.TryParse(Dosage.Text, out value) || !Decimal.TryParse(Weight.Text, out value))
                {
                    DisplayAlert("Error", "Field should not contain a negative value", "Ok");
                    return;
                }
                double dosage = Convert.ToDouble(Dosage.Text);
                double weight = Convert.ToDouble(Weight.Text);

                Calculate(dosage, weight);
            }
        }
        private void Calculate(double dosage, double weight)
        {

            string text = "";
            double calculation = 0;

            string unit = (string)CalculateButton.BindingContext;
            if (unit == "lb")
            {
                calculation = dosage * (weight * 0.45359237);
                calculation = Math.Round(calculation, 3);
                text = "Calculated dosage: " + calculation.ToString() + " " + (string)CalculationLabel.BindingContext;
            }
            else if (unit == "kg")
            {
                calculation = dosage * weight;
                calculation = Math.Round(calculation, 3);
                text = "Calculated dosage: " + calculation.ToString() + " " + (string)CalculationLabel.BindingContext;
            }
            else
            {
                DisplayAlert("Message", "Please select a unit.", "ok");
            }
            if (this.dosage.HasMaxDose)
            {
                if (calculation > this.dosage.MaxDose)
                {
                    text = "Calculated dosage: " + "NA" + (string)CalculationLabel.BindingContext;
                    string alertMessage = "Dosage is too high. Maximum dosage is " + this.dosage.MaxDose;
                    DisplayAlert("Message", alertMessage, "ok");
                    return;
                }             
            }
            CalculationLabel.Text = text;
        }

        
    }
}