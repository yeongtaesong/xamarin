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

        //Initialize Page so that only headers are showing. Use ResourceGroup.All to obtain original list.
        private List<ProtocolGroup> InitializePage(List<ProtocolGroup> List)
        {
            List<ProtocolGroup> InitialList = new List<ProtocolGroup>();
            foreach (ProtocolGroup protocols in List)
            {
                //Only headers are created - no sections will be shown
                ProtocolGroup temp = new ProtocolGroup(protocols.Heading);
                InitialList.Add(temp);
            }
            return InitialList;
        }

    }




}