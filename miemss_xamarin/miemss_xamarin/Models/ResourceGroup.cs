using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;

namespace miemss_xamarin.Models
{
    class ResourceGroup : List<Section>, INotifyPropertyChanged
    {

        public string Heading { get; set; }
        public List<Section> Sections => this;
        private bool _expanded;

        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;
                    OnPropertyChanged("Expanded");
                    OnPropertyChanged("StateIcon");
                }
            }
        }

        public string StateIcon
        { get; set;}

        public ResourceGroup(string heading)
        {
            Heading = heading;
        }

        public static List<ResourceGroup> All { private set; get; }

        static ResourceGroup()
        {
            List<ResourceGroup> Groups = new List<ResourceGroup>
            {
                new ResourceGroup("Dispatch/Responder Actions")
                {
                    new Section {Name = "General Principles - Call Taking/Dispatch"},
                    new Section {Name = "General Principles - Response"},
                },
                new ResourceGroup("Standard Precautions")
                {
                    new Section {Name = "Example Diseases"},
                    new Section {Name = "Goal of Precautions"},
                },
                new ResourceGroup("Contact Precautions")
                {
                    new Section {Name = "Example Diseases"},
                    new Section {Name = "Goal of Precautions"},
                },
                new ResourceGroup("Droplet Precautions")
                {
                    new Section {Name = "Example Diseases"},
                    new Section {Name = "Goal of Precautions"},
                },
                new ResourceGroup("Airborne Precautions")
                {
                    new Section {Name = "Example Diseases"},
                    new Section {Name = "Goal of Precautions"},
                },
                new ResourceGroup("Special Respiratory Precautions")
                {
                    new Section {Name = "Example Diseases"},
                    new Section {Name = "Goal of Precautions"},
                },
                new ResourceGroup("EVD/VHF Precautions")
                {
                    new Section {Name = "Example Diseases"},
                    new Section {Name = "Goal of Precautions"},
                },
                new ResourceGroup("Resources/Special Considerations")
                {
                    new Section {Name = "Hand Hygiene"},
                    new Section {Name = "Pandemic Influenze"},
                },
            };
            All = Groups;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
