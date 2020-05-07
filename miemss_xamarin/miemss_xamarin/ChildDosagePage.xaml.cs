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
    public partial class ChildDosagePage : ContentPage
    {
        public ChildDosagePage()
        {
            InitializeComponent();
            DisplayAlert("Message", this.Title, "ok");
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

            }
            else if (unit == "kg")
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
    }
}