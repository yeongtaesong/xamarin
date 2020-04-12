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

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResourcePage : ContentPage
    {
        private List<ResourceGroup> _allGroups;
        private List<ResourceGroup> _expandedGroups;
        public ResourcePage()
        {
            InitializeComponent();
            _allGroups = ResourceGroup.All;
            UpdateListContent();



        }

        private void HeaderTapped(object sender, EventArgs e)
        {
            int selectedIndex = _expandedGroups.IndexOf(
                ((ResourceGroup)((Button)sender).CommandParameter));
            _allGroups[selectedIndex].Expanded = !_allGroups[selectedIndex].Expanded;
            UpdateListContent();
        }

        private void UpdateListContent()
        {
            _expandedGroups = new List<ResourceGroup>();

            foreach (ResourceGroup resource in _allGroups)
            {
                //assigns only the heading to the ResourceGroup - will only display heading on page initialization
                ResourceGroup newGroup = new ResourceGroup(resource.Heading);

                //if button is pressed, expanded = true and sections will be added
                if (resource.Expanded)
                {
                    foreach (Section section in resource)
                    {
                        newGroup.Add(section);
                    }
                }
                _expandedGroups.Add(newGroup);
            }
            ResourceView.ItemsSource = _expandedGroups;
        }

        //Initialize Page so that only headers are showing. Use ResourceGroup.All to obtain original list.
        private List<ResourceGroup> InitializePage(List<ResourceGroup> List)
        {
            List<ResourceGroup> InitialList = new List<ResourceGroup>();
            foreach (ResourceGroup resource in List)
            {
                //Only headers are created - no sections will be shown
                ResourceGroup temp = new ResourceGroup(resource.Heading);
                InitialList.Add(temp);
            }
            return InitialList;
        }

    }




}