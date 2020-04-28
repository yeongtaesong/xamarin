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

        private void Button_OnClicked(object sender, EventArgs e)
        {
            string unit = (string)CalculateButton.BindingContext;
           if (unit == "lb")
            {
                double dosage = Convert.ToDouble(Dosage.Text);
                double weight = Convert.ToDouble(Weight.Text);

                double calculation = dosage * (weight * 0.45359237);
               calculation = Math.Round(calculation, 3);

                CalculationLabel.Text = "Calculated dosage: " + calculation.ToString();

            } else if (unit == "kg")
            {
                double dosage = Convert.ToDouble(Dosage.Text);
                double weight = Convert.ToDouble(Weight.Text);

                double calculation = dosage * weight;

                CalculationLabel.Text = "Calculated dosage: " + calculation.ToString();
            }
            else
            {
                DisplayAlert("Message", "Please select a unit.", "ok");
            }


        }
        private void Calculator_OnClicked(object sender, EventArgs e)
        {



        }
    }
}