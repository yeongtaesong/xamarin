using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;
using miemss_xamarin.Models;
using ListView = Xamarin.Forms.ListView;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            BindingContext = new HospitalContactViewModel();

        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var hospitalcontact = ((ListView)sender).SelectedItem as HospitalContact;
            if (hospitalcontact != null)
            {
                var page = new HospitalContactDetailPage();
                page.BindingContext = hospitalcontact;
                await Navigation.PushAsync(page);
            }
        }
    }
}