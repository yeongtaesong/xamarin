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
                new ProtocolGroup("I. General Information")
                {
                    new Protocol {Name = "General Provisions", Path="miemss_xamarin.Assets.I_A_1-2.pdf"},
                    new Protocol {Name = "Important Numbers", Path="miemss_xamarin.Assets.I_B_3-4.pdf"},
                    new Protocol {Name = "Maryland Trauma and Specialty Referral Centers", Path="miemss_xamarin.Assets.I_C_5-8.pdf"},
                    new Protocol {Name = "Protocol Key", Path="miemss_xamarin.Assets.I_D_10.pdf"},
                    new Protocol {Name = "Protocol Usage Flow Diagram", Path="miemss_xamarin.Assets.I_E_11.pdf"},
                    new Protocol {Name = "Protocol Variation Procedure", Path="miemss_xamarin.Assets.I_F_12.pdf"},
                    new Protocol {Name = "Inablity to Carry Out Physician Order", Path="miemss_xamarin.Assets.I_G_13.pdf"},
                    new Protocol {Name = "Physician Orders for Extraordinary Care (New '20)", Path="miemss_xamarin.Assets.I_H_14.pdf"},

                },
                new ProtocolGroup("II. General Patient Care")
                {
                    new Protocol {Name = "Age-Related Normal Vital Signs", Path="miemss_xamarin.Assets.II_generalpatientcare.pdf" }
                },
                new ProtocolGroup("III. Treatment Protocols")
                {
                    new Protocol {Name = "Abuse/Neglect", Path="miemss_xamarin.Assets.III_A.pdf"},
                    new Protocol {Name = "Altered Mental Status", Path="miemss_xamarin.Assets.III_B_C.pdf"},
                    new Protocol {Name = "Apparent Life-Threatening Event (ALTE)", Path="miemss_xamarin.Assets.III_D_40.pdf"},
                    new Protocol {Name = "Behavioral Emergencies", Path="miemss_xamarin.Assets.III_E_41-42.pdf"},
                    new Protocol {Name = "Cardiac Emergencies (New '20)", Path="miemss_xamarin.Assets.III_F_S.pdf"},
                    new Protocol {Name = "Environmental Emergencies", Path="miemss_xamarin.Assets.III_T_Z.pdf"},
                    new Protocol {Name = "Nausea and Vomiting", Path="miemss_xamarin.Assets.III_AA_104.pdf"},
                    new Protocol {Name = "Obstetrical/Gynecological Emergencies", Path="miemss_xamarin.Assets.III_BB_DD.pdf"},
                    new Protocol {Name = "Overdose/Poisoning", Path="miemss_xamarin.Assets.III_EE_KK.pdf"},
                    new Protocol {Name = "Pain Management", Path="miemss_xamarin.Assets.III_LL_128-132.pdf"},
                    new Protocol {Name = "Respiratory Distress (New '20)", Path="miemss_xamarin.Assets.III_MM_RR.pdf"},
                    new Protocol {Name = "Sepsis", Path="miemss_xamarin.Assets.III_SS_TT.pdf"},
                    new Protocol {Name = "Shock", Path="miemss_xamarin.Assets.III_UU_153-155.pdf"},
                    new Protocol {Name = "Stroke", Path="miemss_xamarin.Assets.III_VV.pdf"},
                    new Protocol {Name = "Syncope", Path="miemss_xamarin.Assets.III_VV2_160.pdf"},
                    new Protocol {Name = "Trauma (New '20)", Path="miemss_xamarin.Assets.III_WW~DDD.pdf"},

                },
                new ProtocolGroup("IV. Appendices")
                {
                    new Protocol {Name = "Glossary", Path="miemss_xamarin.Assets.IV_A_181-187.pdf"},
                    new Protocol {Name = "Procedures, Medical Devices, and Medications for EMS", Path="miemss_xamarin.Assets.IV_B_188-191.pdf"},
                    new Protocol {Name = "BLS Pharmacology", Path="miemss_xamarin.Assets.IV_BLS.pdf"},
                    new Protocol {Name = "ALS Pharmacology (New '20)", Path="miemss_xamarin.Assets.IV_ALS.pdf"},
                    new Protocol {Name = "Procedures", Path="miemss_xamarin.Assets.IV_E_procedure.pdf"},
                    new Protocol {Name = "Procedures: Airway Management", Path="miemss_xamarin.Assets.IV_E_Airway.pdf"},
                    new Protocol {Name = "Procedures: Electrical Therapy", Path="miemss_xamarin.Assets.IV_electricalT.pdf"},
                    new Protocol {Name = "Other Procedures", Path="miemss_xamarin.Assets.IV_other.pdf"},
                    new Protocol {Name = "Interfacility (New '20)", Path="miemss_xamarin.Assets.IV_interfacility.pdf"},
                    new Protocol {Name = "Pilot Programs (New '20)", Path="miemss_xamarin.Assets.IV_pilot.pdf"},
                },

                new ProtocolGroup("V. Jurisdictional Optional Supplemental Programs/Protocols")
                {
                    new Protocol {Name = "Airway Mgmt: Bi-Level Positive Airway Pressure (BiPAP)", Path="miemss_xamarin.Assets.V_A_359.pdf"},
                    new Protocol {Name = "Airway Mgmt: Laryngeal Mask Airway with Design to Facilitate Hospital", Path="miemss_xamarin.Assets.V_B_360.pdf"},
                    new Protocol {Name = "Airway Mgmt: Video Laryngoscopy", Path="miemss_xamarin.Assets.V_C_361-362.pdf"},
                    new Protocol {Name = "Antimicrobial Infusion for Interfacility Transport  ", Path="miemss_xamarin.Assets.V_D_363-364.pdf"},
                    new Protocol {Name = "BLS Glucometer", Path="miemss_xamarin.Assets.V_E_365.pdf"},
                    new Protocol {Name = "Cyanide Poisoning", Path="miemss_xamarin.Assets.V_F_366-369.pdf"},
                    new Protocol {Name = "EMT Acquisition of 12-Lead Electrocardiography", Path="miemss_xamarin.Assets.V_G_370-372.pdf"},
                    new Protocol {Name = "Glycoprotein Ilb/Illa Antagonist Infusion", Path="miemss_xamarin.Assets.V_H.pdf"},
                    new Protocol {Name = "Heparin Infusion for Interfacility Transport", Path="miemss_xamarin.Assets.V_I.pdf"},
                    new Protocol {Name = "Intranasal Naloxone for Commercial Service BLS Clinicians", Path="miemss_xamarin.Assets.V_J_377-382.pdf"},
                    new Protocol {Name = "MARK I/ Duo Dote Kits (Atropine and 2-PAM Auto-injectors)", Path="miemss_xamarin.Assets.V_K.pdf"},
                    new Protocol {Name = "Maryland Vaccination and Testing Program", Path="miemss_xamarin.Assets.V_L_388-392.pdf"},
                    new Protocol {Name = "Mechanical CPR", Path="miemss_xamarin.Assets.V_M_394-395.pdf"},
                    new Protocol {Name = "Mobile Integrated Community Health Program", Path="miemss_xamarin.Assets.V_N_397-401.pdf"},
                    new Protocol {Name = "Naloxone Leave Behind Protocol", Path="miemss_xamarin.Assets.V_O_403.pdf"},
                    new Protocol {Name = "Pelvic Stabilization Binder Device", Path="miemss_xamarin.Assets.V_P_404-405.pdf"},
                    new Protocol {Name = "Rapid Sequence Intubation - Adult (New '20)", Path="miemss_xamarin.Assets.V_Q_406-411.pdf"},
                    new Protocol {Name = "Rapid Sequence Intubation - Pediatric  ", Path="miemss_xamarin.Assets.V_R_412-417.pdf"},
                    new Protocol {Name = "Rapid Sequence Intubation - Pharmacology (New '20)", Path="miemss_xamarin.Assets.V_S.pdf"},
                    new Protocol {Name = "Specialty Care Paramedic", Path="miemss_xamarin.Assets.V_T_424-427.pdf"},
                    new Protocol {Name = "Surgical Cricothyroidotomy", Path="miemss_xamarin.Assets.V_U_429.pdf"},
                    new Protocol {Name = "Tactical EMS", Path="miemss_xamarin.Assets.V_V_430-450.pdf"},
                    new Protocol {Name = "Transport of Acute Ventilated Interfacility Patients", Path="miemss_xamarin.Assets.V_W_452-453.pdf"},
                    new Protocol {Name = "Transport of Chronic and Scene Ventilated Patients", Path="miemss_xamarin.Assets.V_X_454-456.pdf"},
                    new Protocol {Name = "Transport to Freestanding Emergency Medical Facility (Bulle Rock)", Path="miemss_xamarin.Assets.V_Y_457.pdf"},
                    new Protocol {Name = "Transport to Freestanding Emergency Medical Facility (Base/Non-Base)", Path="miemss_xamarin.Assets.V_Z_458.pdf"},
                    new Protocol {Name = "Viral Pandemic: Triage Protocol (New '20)", Path="miemss_xamarin.Assets.V_AA_460-461.pdf"},
                    new Protocol {Name = "Wilderness Emergency Medical Services Protocols", Path="miemss_xamarin.Assets.V_BB_462-486.pdf"},
                },
                new ProtocolGroup("VI. Research Protocols")
                {
                   new Protocol {Name = " Research Protocols", Path="miemss_xamarin.Assets.VI_research.pdf"},
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
