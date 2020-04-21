using miemss_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using miemss_xamarin.Models;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProtocolsPage : ContentPage
    {
        private List<ProtocolGroup> _allGroups;
        private List<ProtocolGroup> _expandedGroups;
        public ProtocolsPage()
        {
            InitializeComponent();
            _allGroups = ProtocolGroup.All;
            UpdateListContent();
          



        }

        //If header is tapped, list is expanded - finds index value of ResourceGroup
        private void HeaderTapped(object sender, EventArgs e)
        {
            int selectedIndex = _expandedGroups.IndexOf(
                ((ProtocolGroup)((Button)sender).CommandParameter));
            _allGroups[selectedIndex].Expanded = !_allGroups[selectedIndex].Expanded;
            UpdateListContent();
        }

        private void UpdateListContent()
        {
            _expandedGroups = new List<ProtocolGroup>();

            foreach (ProtocolGroup protocols in _allGroups)
            {
                //assigns only the heading to the ResourceGroup - will only display heading on page initialization
                ProtocolGroup newGroup = new ProtocolGroup(protocols.Heading);
                newGroup.StateIcon = "expand.png";

                //if button is pressed, expanded = true and sections will be added
                if (protocols.Expanded)
                {
                    foreach (Protocol protocol in protocols)
                    {
                        newGroup.Add(protocol);
                    }
                    newGroup.StateIcon = "collapse.png";
                }
                _expandedGroups.Add(newGroup);
            }
            ProtocolsView.ItemsSource = _expandedGroups;
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var  protocol = ((ListView)sender).SelectedItem as Protocol;
            if (protocol != null)
            {
                var page = new DetailedProtocolPage();
                page.BindingContext = protocol;
                await Navigation.PushAsync(page);
            }
        }

    }

}