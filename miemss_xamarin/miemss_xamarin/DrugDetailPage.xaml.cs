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

            //calculate dosage by multiplying "dosage" by body weight. Need to ask for exact calculation for dosage.
            double input = Convert.ToDouble(Entry.Text);
            double dosage = ((Drug)this.BindingContext).Dosage;

            double calculation = input * dosage;

                CalculationLabel.Text = "Calculated dosage: " + calculation.ToString();
            

            
        }
    }
}