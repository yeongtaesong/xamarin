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
                new ProtocolGroup("I.General Information")
                {
                    new Protocol {Name = "General Provisions"},
                    new Protocol {Name = "Important Numbers"},
                    new Protocol {Name = "Health Care Facility Codes"},
                    new Protocol {Name = "Maryland Trauma and Specialty Referral Centers"},
                    new Protocol {Name = "ProtocolKey/UsageFlowDiagram/VariationProcedure"},
                    new Protocol {Name = "Inablity to Carry Out Physician Order"},
                    new Protocol {Name = "Physician Orders for Extraordinary Care"},
                    new Protocol {Name = "Quality Review Procedure for Pilot Programs"},
                    new Protocol {Name = "Physician Orders for Extraordinary Care"},
                    new Protocol {Name = "Proposed Protocol Submission Request Policy/Template"},

                },
                new ProtocolGroup("II. General Patient Care")
                {
                    new Protocol {Name = "Aged-Related Vital Signs"},              
                },
                new ProtocolGroup("III. Treatment Protocols")
                {
                    new Protocol {Name = "Abuse/Neglect"},
                    new Protocol {Name = "Altered Mental Status"},
                    new Protocol {Name = "Apparent Life-Threatening Event (ALTE)"},
                    new Protocol {Name = "Behavioral Emergencies "},
                    new Protocol {Name = "Cardiac Emergencies "},
                    new Protocol {Name = "Environmental Emergencies "},
                    new Protocol {Name = "Nausea and Vomiting "},
                    new Protocol {Name = "Non-Traumatic Shock "},
                    new Protocol {Name = "Obstetrical/Gynecological Emergencies "},
                    new Protocol {Name = "Overdose/Poisoning"},
                    new Protocol {Name = "Pain Management "},
                    new Protocol {Name = "Respiratory Distress "},
                    new Protocol {Name = "Sepsis "},
                    new Protocol {Name = "Stroke "},
                    new Protocol {Name = "Syncope "},
                    new Protocol {Name = "Trauma "},

                },
                new ProtocolGroup("IV. Appendices")
                {
                    new Protocol {Name = "Glossary"},
                    new Protocol {Name = "Procedures, Medical Devices, and Medications for EMS"},
                    new Protocol {Name = "Procedure-Accessing Central Venous Catheters and Devices"},
                    new Protocol {Name = "Procedure-Airway Management Procedures"},
                    new Protocol {Name = "Procedure-Electrical Therapy Procedures "},
                    new Protocol {Name = "Procedure-Other Procedures "},
                    new Protocol {Name = "Interfacility"},
                    new Protocol {Name = "Pilot Programs "},
                },

                new ProtocolGroup("V. Jurisdictional Optional Supplemental Programs/Protocols")
                {
                    new Protocol {Name = "Cyanide Poisoning"},
                    new Protocol {Name = "Glycoprotein lib/llla Antagonist Infusions"},
                    new Protocol {Name = "Intranasal Naloxone for Commercial Service BLS Providers "},
                    new Protocol {Name = "Heparin Infusion for Interfacility Transport"},
                    new Protocol {Name = "Laryngeal Mask Airway with Design to Facilitate Hospital "},
                    new Protocol {Name = "Bi-Level Positive Airway Pressure (BiPAP) "},
                    new Protocol {Name = "BLS Glucometer "},
                    new Protocol {Name = "Antimicrobial Infusion for Interfacility Transport  "},
                    new Protocol {Name = "MARK I/ Duo Dote Kits (Atropine and 2-PAM Auto-injectors)"},
                    new Protocol {Name = "Specialty Care Paramedic "},
                    new Protocol {Name = "Mechanical CPR "},
                    new Protocol {Name = "Pelvic Stabilization Binder Device  "},
                    new Protocol {Name = "Transport of Acute Ventilated Interfacility Patients  "},
                    new Protocol {Name = "Transport of Chronic and Scene Ventilated Patients "},
                    new Protocol {Name = "EMT Acquisition of 12-Lead Electrocardiography"},
                    new Protocol {Name = "Wilderness Emergency Medical Services Protocols "},
                    new Protocol {Name = "Maryland Vaccination and Testing Program  "},
                    new Protocol {Name = "Mobile Integrated Community Health Program (NEW ’19) "},
                },
                new ProtocolGroup("VI. Research Protocols")
                {
                   new Protocol {Name = " Research Protocols"},
                },
                new ProtocolGroup("VII. Weapons of Mass Destruction Supplement")
                {
                   new Protocol {Name = " vWeapons of Mass Destruction Supplement"},
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
