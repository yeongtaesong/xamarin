using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;

namespace miemss_xamarin.Models
{
    class ProtocolGroup : List<Protocol>, INotifyPropertyChanged
    {

        public string Heading { get; set; }
        public List<Protocol> Sections => this;
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

        public ProtocolGroup(string heading)
        {
            Heading = heading;
        }

        public static List<ProtocolGroup> All { private set; get; }

        static ProtocolGroup()
        {
            List<ProtocolGroup> Groups = new List<ProtocolGroup>
            {
                new ProtocolGroup("General Information")
                {
                    new Protocol {Name = "General Provisions"},
                    new Protocol {Name = "Important Numbers"},
                },
                new ProtocolGroup("General Patient Care")
                {
                    new Protocol {Name = "Aged-Related Vital Signs"},              
                },
                new ProtocolGroup("Treatment Protocols")
                {
                    new Protocol {Name = "Bause/Neglect"},
                    new Protocol {Name = "Altered Mental Status"},
                },
                new ProtocolGroup("Appendices")
                {
                    new Protocol {Name = "Glossary"},
                    new Protocol {Name = "Procedures, Medical Devices, and Medications for EMS"},
                },
                new ProtocolGroup("Jurisdictional Optional Supplemental Programs/Protocols")
                {
                    new Protocol {Name = "Cyanide Poisoning"},
                    new Protocol {Name = "Glycoprotein lib/llla Antagonist Infusions"},
                },
                new ProtocolGroup("Research Protocols")
                {
                    new Protocol {Name = "Intentionally Omitted"},
                    new Protocol {Name = "LAMS Stroke Research Protocol"},
                },
                new ProtocolGroup("Weapons of Mass Destruction Supplement")
                {
                    new Protocol {Name = "Weapons of Mass Destruction Supplement"},
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
