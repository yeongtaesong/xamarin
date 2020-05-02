using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrugSelectionPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public DrugSelectionPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Advanced Life Support (ALS)",
                "Basic Life Support (BLS)"
            };


        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Message", "you clicked me!", "ok");
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            DisplayAlert("Message", "you clicked me!", "ok");
        }
    }
}
