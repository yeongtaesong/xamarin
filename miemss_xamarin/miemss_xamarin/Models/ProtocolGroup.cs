using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;

/*Edit Protocol Page list items here. Items are generated through the 
 *static method ProtocolGroup(). This model also allow for the creation
 *of groups and subgroups for the Protcol Page.
 
 *ProtocolGroup is the header and Protocol is the group within the header. These
 *items are displayed on ProtocolPage.xaml*/

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
                    new Protocol {Name = "General Provisions", Path="miemss_xamarin.Assets.general Info-provision.pdf"},
                    new Protocol {Name = "Important Numbers", Path="miemss_xamarin.Assets.general Info-important no.pdf"},
                    new Protocol {Name = "Health Care Facility Codes", Path="miemss_xamarin.Assets.general Info-healthcare code.pdf"},
                    new Protocol {Name = "Maryland Trauma and Specialty Referral Centers", Path="miemss_xamarin.Assets.general Info-MD trauma.pdf"},
                    new Protocol {Name = "ProtocolKey/UsageFlowDiagram/VariationProcedure", Path="miemss_xamarin.Assets.general Info-protocol key.pdf"},
                    new Protocol {Name = "Inablity to Carry Out Physician Order", Path="miemss_xamarin.Assets.general Info-inability to.pdf"},
                    new Protocol {Name = "Physician Orders for Extraordinary Care", Path="miemss_xamarin.Assets.general Info-physician order~.pdf"},
                    new Protocol {Name = "Quality Review Procedure for Pilot Programs", Path="miemss_xamarin.Assets.general Info-quality review.pdf"},
                    new Protocol {Name = "Proposed Protocol Submission Request Policy/Template", Path="miemss_xamarin.Assets.general Info-proposed protocol~.pdf"},

                },
                new ProtocolGroup("II. General Patient Care")
                {
                    new Protocol {Name = "General Patient Care", Path="miemss_xamarin.Assets.general_patient_care.pdf" }
                },
                new ProtocolGroup("III. Treatment Protocols")
                {
                    new Protocol {Name = "Abuse/Neglect", Path="miemss_xamarin.Assets.Treatment Protocols-A.pdf"},
                    new Protocol {Name = "Altered Mental Status", Path="miemss_xamarin.Assets.Treatment Protocols-B~C.pdf"},
                    new Protocol {Name = "Apparent Life-Threatening Event (ALTE)", Path="miemss_xamarin.Assets.Treatment Protocols-D.pdf"},
                    new Protocol {Name = "Behavioral Emergencies", Path="miemss_xamarin.Assets.Treatment Protocols-E.pdf"},
                    new Protocol {Name = "Cardiac Emergencies", Path="miemss_xamarin.Assets.Treatment Protocols-F~S.pdf"},
                    new Protocol {Name = "Environmental Emergencies", Path="miemss_xamarin.Assets.Treatment Protocols-T~Z.pdf"},
                    new Protocol {Name = "Nausea and Vomiting", Path="miemss_xamarin.Assets.Treatment Protocols-AA.pdf"},
                    new Protocol {Name = "Non-Traumatic Shock", Path="miemss_xamarin.Assets.Treatment Protocols-BB.pdf"},
                    new Protocol {Name = "Obstetrical/Gynecological Emergencies", Path="miemss_xamarin.Assets.Treatment Protocols-CC~EE.pdf"},
                    new Protocol {Name = "Overdose/Poisoning", Path="miemss_xamarin.Assets.Treatment Protocols-FF~LL.pdf"},
                    new Protocol {Name = "Pain Management", Path="miemss_xamarin.Assets.Treatment Protocols-MM.pdf"},
                    new Protocol {Name = "Allergies/Resperatory Distress", Path="miemss_xamarin.Assets.Treatment Protocols-NN~RR.pdf"},
                    new Protocol {Name = "Sepsis", Path="miemss_xamarin.Assets.Treatment Protocols-SS~TT.pdf"},
                    new Protocol {Name = "Stroke", Path="miemss_xamarin.Assets.Treatment Protocol-UU.pdf"},
                    new Protocol {Name = "Syncope", Path="miemss_xamarin.Assets.Treatment Protocols-UU2.pdf"},
                    new Protocol {Name = "Trauma", Path="miemss_xamarin.Assets.Treatment Protocols-VV~CCC.pdf"},

                },
                new ProtocolGroup("IV. Appendices")
                {
                    new Protocol {Name = "Glossary", Path="miemss_xamarin.Assets.Appendices-A.pdf"},
                    new Protocol {Name = "Procedures, Medical Devices, and Medications for EMS", Path="miemss_xamarin.Assets.Appendices-B.pdf"},
                    new Protocol {Name = "BLS Pharmacology", Path="miemss_xamarin.Assets.Appendices-C.pdf"},
                    new Protocol {Name = "ALS Pharmacology", Path="miemss_xamarin.Assets.Appendices-D.pdf"},
                    new Protocol {Name = "Procedures", Path="miemss_xamarin.Assets.Appendices-E.pdf"},
                    new Protocol {Name = "Electrical Therapy", Path="miemss_xamarin.Assets.Appendices-E.electrical therapy.pdf"},
                    new Protocol {Name = "Interfacility Transport", Path="miemss_xamarin.Assets.Appendices-E.interfacility.pdf"},
                    new Protocol {Name = "Other Procedures", Path="miemss_xamarin.Assets.Appendices-E.other procedures.pdf"},
                    new Protocol {Name = "Pilot Programs", Path="miemss_xamarin.Assets.Appendices-E.pilot program.pdf"},
                },

                new ProtocolGroup("V. Jurisdictional Optional Supplemental Programs/Protocols")
                {
                    new Protocol {Name = "Cyanide Poisoning", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-A.pdf"},
                    new Protocol {Name = "Glycoprotein Ilb/Illa Antagonist Infusion", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-B.pdf"},
                    new Protocol {Name = "Intranasal Naloxone for Commercial Service BLS Providers", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-C.pdf"},
                    new Protocol {Name = "Heparin Infusion for Interfacility Transport", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-D.pdf"},
                    new Protocol {Name = "Laryngeal Mask Airway with Design to Facilitate Hospital", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-E.pdf"},
                    new Protocol {Name = "Bi-Level Positive Airway Pressure (BiPAP)", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-F.pdf"},
                    new Protocol {Name = "BLS Glucometer", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-G.pdf"},
                    new Protocol {Name = "Antimicrobial Infusion for Interfacility Transport", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-H.pdf"},
                    new Protocol {Name = "MARK I/ Duo Dote Kits (Atropine and 2-PAM Auto-injectors)", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-I.pdf"},
                    new Protocol {Name = "Specialty Care Paramedic", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-J.pdf"},
                    new Protocol {Name = "Mechanical CPR", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-K.pdf"},
                    new Protocol {Name = "Pelvic Stabilization Binder Device", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-L.pdf"},
                    new Protocol {Name = "Transport of Acute Ventilated Interfacility Patients", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-M.pdf"},
                    new Protocol {Name = "Transport of Chronic and Scene Ventilated Patients", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-N.pdf"},
                    new Protocol {Name = "EMT Acquisition of 12-Lead Electrocardiography", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-O.pdf"},
                    new Protocol {Name = "Wilderness Emergency Medical Services Protocols", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-P.pdf"},
                    new Protocol {Name = "Maryland Vaccination and Testing Program", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-Q.pdf"},
                    new Protocol {Name = "Mobile Integrated Community Health Program (NEW ’19)", Path="miemss_xamarin.Assets.Jurisdictional Optional Program-Q.pdf"},
                },
                new ProtocolGroup("VI. Research Protocols")
                {
                   new Protocol {Name = " Research Protocols", Path="miemss_xamarin.Assets.Research Protocol.pdf"},
                },
        //         new ProtocolGroup("VII. Weapons of Mass Destruction Supplement")
        //        {
        //           new Protocol {Name = " Weapons of Mass Destruction Supplement", Path="miemss_xamarin.Assets.Weapons of Mass Destruction Supplement.pdf"},
        //        },
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
