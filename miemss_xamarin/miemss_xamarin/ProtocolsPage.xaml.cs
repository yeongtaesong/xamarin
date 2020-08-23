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
using miemss_xamarin.ViewModel;
using System.Diagnostics;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProtocolsPage : ContentPage
    {
        ProtocolViewModel viewModel = new ProtocolViewModel();
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
            var group = (ProtocolGroup)((StackLayout)sender).BindingContext;
            int selectedIndex = _expandedGroups.IndexOf(group);
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
                newGroup.StateIcon = "arrow_right_circle.png";

                //if button is pressed, expanded = true and sections will be added
                if (protocols.Expanded)
                {
                    foreach (Protocol protocol in protocols)
                    {
                        newGroup.Add(protocol);
                    }
                    newGroup.StateIcon = "arrow_down_circle.png";
                }
                _expandedGroups.Add(newGroup);
            }
            ProtocolsView.ItemsSource = _expandedGroups;
        }
        //Does nothing - only OnItemSelected can perform action
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
        //If item is selected, user is redirected to DetailedProtocolPage
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Get item user selected
            var  protocol = ((ListView)sender).SelectedItem as Protocol;

            if (protocol != null)
            {
                var page = new DetailedProtocolPage();
                page.BindingContext = protocol;
                page.Title = protocol.Name;
                await Navigation.PushAsync(page);
            }
        }
    }
}