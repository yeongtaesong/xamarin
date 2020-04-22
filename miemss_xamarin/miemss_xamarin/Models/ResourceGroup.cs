using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.Schema;
using Xamarin.Forms;

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
        { get; set; }

        public ResourceGroup(string heading)
        {
            Heading = heading;
        }

        public static List<ResourceGroup> All { private set; get; }

        static ResourceGroup()
        {

            string path = DependencyService.Get<IBaseUrl>().Get();
            string url = Path.Combine(path, "HTML/playbook/");

            List<ResourceGroup> Groups = new List<ResourceGroup>
            {
                new ResourceGroup("Dispatch/Responder Actions")
                {
                    new Section {Name = "General Principles - Call Taking/Dispatch", Path=(url+"EMS_infectious_playbook3.html") },
                    new Section {Name = "General Principles - Response", Path=(url+"EMS_infectious_playbook4.html")},
                    new Section {Name = "Dispatch Screening Algorithm", Path=(url+"EMS_infectious_playbook5.html")},
                    new Section {Name = "General PPE Considerations", Path=(url+"EMS_infectious_playbook7.html")}
                },
                new ResourceGroup("Standard Precautions")
                {
                    new Section {Name = "Example Diseases", Path=(url+"index.html")},
                    new Section {Name = "Goal of Precautions", Path=(url+"index.html")},
                },
                new ResourceGroup("Contact Precautions")
                {
                    new Section {Name = "Example Diseases", Path=(url+"index.html")},
                    new Section {Name = "Goal of Precautions", Path=(url+"index.html")},
                },
                new ResourceGroup("Droplet Precautions")
                {
                    new Section {Name = "Example Diseases", Path=(url+"index.html")},
                    new Section {Name = "Goal of Precautions", Path=(url+"index.html")},
                },
                new ResourceGroup("Airborne Precautions")
                {
                    new Section {Name = "Example Diseases", Path=(url+"index.html")},
                    new Section {Name = "Goal of Precautions", Path=(url+"index.html")},
                },
                new ResourceGroup("Special Respiratory Precautions")
                {
                    new Section {Name = "Example Diseases", Path=(url+"index.html")},
                    new Section {Name = "Goal of Precautions", Path=(url+"index.html")},
                },
                new ResourceGroup("EVD/VHF Precautions")
                {
                    new Section {Name = "Example Diseases", Path=(url+"index.html")},
                    new Section {Name = "Goal of Precautions", Path=(url+"index.html")},
                },
                new ResourceGroup("Resources/Special Considerations")
                {
                    new Section {Name = "Hand Hygiene", Path=(url+"index.html")},
                    new Section {Name = "Pandemic Influenze", Path=(url+"index.html")},
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
