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
    public partial class DrugCalculator : ContentPage
    {
        public DrugCalculator()
        {
            InitializeComponent();
        }


        private void Button_OnClicked(object sender, EventArgs e)
        {

            //calculate dosage by multiplying "dosage" by body weight. Need to ask for exact calculation for dosage.
            double dosage = Convert.ToDouble(Dosage.Text);
            double weight = Convert.ToDouble(Weight.Text);

            double calculation = dosage * weight;

            CalculationLabel.Text = "Calculated dosage: " + calculation.ToString();



        }
    }
}