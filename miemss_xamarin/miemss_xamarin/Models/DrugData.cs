using MetalPerformanceShaders;
using System;
using System.Collections.Generic;
using System.Text;

namespace miemss_xamarin.Models
{
    public static class DrugData
    {
        public static IList<Drug> Drugs { get; private set; }
        static DrugData()
        {
            Drugs = new List<Drug>();

            Drugs.Add(new Drug
            {
                Name = "Acetaminophen",
                Details = "Patients ages 2 years and above judged to be in mild to moderate discomfort (e.g., 2–5 on FACES scale).",
                Path = "miemss_xamarin.Assets.ALS-ACETAMINOPHEN.pdf",
                Category = "ALS",
                PediatricDosageDescription = "2-4 years: Unit dose 160 mg/5 mL. 5-12 years: TWO unit doses of 160 mg/5 ml.",
                AdultDosageDescription = "13 years and above: FOUR unit doses of 160 mg/5 mL each for a total of 640 mg/20 mL OR in a form of 325 mg pill or tablet x2 for a total of 650 mg with sips of water as tolerated by the patient.",
                HasCalculator = false


            });


            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol)",
                Details = "Poisoning by mouth.",
                Path = "miemss_xamarin.Assets.ALS-ACTIVATED CHARCOAL.pdf",
                Category = "ALS",
                PediatricDosageDescription = "1 gram/kg",
                AdultDosageDescription = "1 gram/kg",
                HasCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "gram/kg"

            });

            Drugs.Add(new Drug
            {
                Name = "Albuterol",
                Details = "Signs and symptoms of repiratory distress. Bronchospasm/wheezing associated with: asthma, chronic bronchitis, emphysema, allergic reactions (anaphylaxis).",
                Path = "miemss_xamarin.Assets.ALS-ALBUTEROL.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Patient may receive a maximum of 2 doses (4 puffs) over a 30-minute period. Additional doses may be administered with medical consultation.",
                AdultDosageDescription = "Patient may receive a maximum of 2 doses (4 puffs) over a 30-minute period. Additional doses may be administered with medical consultation.",
                HasCalculator = false

            });

            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "Chest pain when acute myocardial infarction is suspected.",
                Path = "miemss_xamarin.Assets.ALS-ASPIRIN.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Not indicated.",
                AdultDosageDescription = "324mg or 325 mg chewed.",
                HasCalculator = false

            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine(1:1,000)",
                Details = "(1) Moderate to severe allergic reaction with respiratory distress or mild allergic reaction with history of life-threatening allergic reaction. " +
                "(2) Pediatric patients with severe asthma.",
                Path = "miemss_xamarin.Assets.ALS-EPINEPHRINE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "(1) Patients 5 years of age or greater: 0.5 mg in 0.5 mL IM. " + "Patients less than 5 years of age: 0.15 mg in 0.15 mL IM",
                AdultDosageDescription = "0.5 mg in 0.5 mL IM.",
                HasCalculator = false

            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine Auto-Injector",
                Details = "(1) Moderate to severe allergic reaction with respiratory distress" + 
                " or mild allergic reaction with history of life-threatening allergic reaction. " 
                + "(2) Pediatric patients with severe asthma.",
                Path = "miemss_xamarin.Assets.ALS-EPINEPHRINE AUTO-INJECTOR.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Less than 5 years of age: 0.15 mg IM in the lateral thigh via epinephrine auto-injector or manual administration 0.15 in 0.15 mL IM. " +
                "5 years and greater: administer 0.3 mg IM in the lateral thigh via epinephrine auto-injector or manual administration 0.5 mg in 0.5 mL IM.",
                AdultDosageDescription = "5 years and greater: administer 0.3 mg IM in the lateral thigh via epinephrine auto-injector or manual administration 0.5 mg in 0.5 mL IM.",
                HasCalculator = false


            });

            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "To reverse respiratory depression induced by opioid/narcotic agent.",
                Path = "miemss_xamarin.Assets.ALS-NALOXONE (NARCAN).pdf",
                Category = "ALS",
                PediatricDosageDescription = "(child age 28 days to adult): Administer 2mg IN, dividing administration of the dose equally between the nares to a mamximum of 1 mL per nare"
                + " or administer 4 mg/0.1 mL in one nare. " + "Repeat as necessary to maintain respiratory activity.",
                AdultDosageDescription = "Administer 2mg IN, dividing administration of the dose equally betweent the nares to a maximum of 1 mL per nare, "
                + "OR administer 4mg/0.1 mL IN in one nare. " + "Repeat as necessary to maintain respiratory activity.",
                HasCalculator = false


            });

            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin",
                Details = " Patient must have own prescribed sublingual nitroglycerin. Chest pain.",
                Path = "miemss_xamarin.Assets.ALS-NITROGLYCERIN.pdf",
                Category = "ALS",
                PediatricDosageDescription = "(Nitroglycerin contraindicated for children under age 13.)",
                AdultDosageDescription = "One tablet or one spray sublingually. (a) Repeat in 3 to 5 minutes if chest pain persists. "
                + "(b) Maximum of three doses (a combination of patient-administered and EMT-administered) of nitroglycerin.",
                HasCalculator = false

            });

            Drugs.Add(new Drug
            {
                Name = "Oral Glucose",
                Details = "Altered mental status with known diabetic history. Unconscious for an unknown reason.",
                Path = "miemss_xamarin.Assets.ALS-ORAL GLUCOSE.pdf",
                Category = "ALS",
                PediatricDosageDescription = " Administer 10-15 grams of glucose paste between the gum and cheek; " +
                "this may be accomplished through several small administrations. Consider single additional dose of glucose paste if not improved after 10 minutes.",
                AdultDosageDescription = "Administer 10-15 grams of glucose paste between the gum and cheek. Consider esingle additional dose of glucose paste if not improved after 10 minutes.",
                HasCalculator = false


            });

            Drugs.Add(new Drug
            {
                Name = "Oxygen",
                Details = "(1) If evidence of hypoxia. (2) Respiratory distress. (3) Cardiopulmonary arrest. (4) Trauma. (5) Suspected CO exposure. (6) Dyspena.",
                Path = "miemss_xamarin.Assets.ALS-OXYGEN.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Administer 12–15 lpm via NRB mask or 2-6 lpm via nasal cannula, as needed." +
                "CO exposure: Administer 100 % oxygen via NRB mask. Maintain SpO2 at 100 %. ",
                AdultDosageDescription = "Administer 12–15 lpm via NRB mask or 2–6 lpm via nasal cannula, as needed. " +
                "CO exposure: Administer 100 % oxygen via NRB mask. Maintain SpO2 at 100 %. ",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Acetaminophen",
                Details = "Patients ages 2 years and above judged to be in mild to moderate discomfort (e.g., 2-5 on FACES scale).",
                Path = "miemss_xamarin.Assets.BLS-ACETAMINOPHEN.pdf",
                Category = "BLS",
                PediatricDosageDescription = "(1) 2-4 years: Unit dose 160 mg/5 mL. (2) 5-12 years: TWO unit doses of 160 mg/5mL each for a total of 320 mg/10 mL.",
                AdultDosageDescription = "13 years and above: FOUR unit doses of 160 mg/5 mL each for a total of 640 mg/20 mL" +
                "or in a form of 325 mg pill or tablet x2 for a total of 650 mg with sips of water as tolerated by the patient.",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol) ",
                Details = "Poisoning by mouth.",
                Path = "miemss_xamarin.Assets.BLS-ACTIVATED CHARCOAL.pdf",
                Category = "BLS",
                PediatricDosageDescription = "1 gram/kg",
                AdultDosageDescription = "1 gram/kg",
                HasCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "gram/kg"


            });
            Drugs.Add(new Drug
            {
                Name = "Adenosine ",
                Details = "Used to treat narrow complex tachycardia, PSVT with WPW. Slows conduction through the AV node. ",
                Path = "miemss_xamarin.Assets.BLS-ADENOSINE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "0.1mg/kg rapid IVP/IO; maximum initial dose 6 mg. Second and third doses: 0.2mg/kg rapid IVP/IO; maximum single additional dose 12 mg.",
                AdultDosageDescription = "6 mg rapid IVP bolus followed by a rapid flush. Give 12 mg if no response within 2 minutes. Give 12 mg more if no response within another 1-2 minutes.",
                HasCalculator = true,
                AdultDosage = 6,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Albuterol",
                Details = "Signs and symptoms of respiratory distress. Bronchospasm/wheezing associated with: asthma, chronic bronchitis, emphysema, allergic reaction.",
                Path = "miemss_xamarin.Assets.BLS-ALBUTEROLSULFATE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Patient may receive a maximum of 2 doses (4 puffs) over a 30-minute period.",
                AdultDosageDescription = "Patient may receive a maximum of 2 doses (4 puffs) over a 30-minute period.",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Amiodarone",
                Details = "Prolongs duration and refractory period of action potential. Slows electrical conduction, electrical impulse generation from sinoatrial node, and conduction through accessory pathways. Also dilates blood vessels.",
                Path = "miemss_xamarin.Assets.BLS-AMIODARONE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Pediatric with pulse: 5 mg/kg IV/IO over 20 minutes (mixed in 50 - 100 mL of approved diluent)." +
                "pediatric without pulse: 5 mg/kg IV/IO; max single dose 300 mg. May repeat twice to a maximum of 15 mg/kg.",
                AdultDosageDescription = "Adult with pulse: 150 mg IV/IO over 10 minutes (mixed in 50 - 100 mL of approved diluent). May repeat once." +
                "Adult without pulse VF/VT/(torsades after magnesium sulfate): 300 mg IV/IO. May repeat one time.",
                HasCalculator = true,
                PediatricDosage = 5,
                AdultDosage = 150,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "Platelet inhibitor. Anti-inflammatory.",
                Path = "miemss_xamarin.Assets.BLS-ASPIRIN.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Not indicated",
                AdultDosageDescription = "324 mg or 325 mg chewed",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Atropine Sulfate",
                Details = "Parasympatholytic (vagolytic action), Anticholingergic (accelerates the heart rate)",
                Path = "miemss_xamarin.Assets.BLS-ATROPINESULFATE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Bradycardia: Administer 0.02 mg/kg IV/IO; maximum single dose 0.5 mg; ET 0.04-0.06 mg/kg, dilute 5 mL; repeat once." +
                "Organophosphate poisoning: administer 0.02 mg/kg IVP/IO or IM every 5-10 minutes.",
                AdultDosageDescription = "Bradycarcdia: Administer 0.5 - 1 mg IVP repeated every 3-5 minutes to a total dose of 0.05 mg/kg." + "Organophosphate poisoning: Administer 2-4 mg IVP or IM every 5-10 minutes.",
                HasCalculator = true,
                PediatricDosage = 0.02,
                AdultDosage = 0.05,
                DoseUnit = "mg/kg"
                

            });
            Drugs.Add(new Drug
            {
                Name = "Atrovent",
                Details = "Anticholinergic (parasympatholytic) bronchodilator, Bronchodilator is site-specific, not systemic. Dries respiratory tact secretions. Most effective in combination with a beata-adrenergic bronchodilator.",
                Path = "miemss_xamarin.Assets.BLS-ATROVENT.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Single administration ONLY. In combination with albuterol, nebulized aerosol is connected to 6-8 lpm of oxygen. (a) Less than 1 year of age: contraindicated. (b) Age 1 year but less than 2 years: 250 mcg (1.25 mL) by nebulized aerosol. (c) 500 mcg (2.5 mL) by nebulized aerosol.",
                AdultDosageDescription = "Single administration ONLY, 500 mcg (2.5 mL) by nebulized aerosol connected to 6-8 lpm of oxygen incombinatin with albuterol 2.5 mg",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Calcium Chloride",
                Details = "Increases cardiact contractile state and ventricular automaticity.",
                Path = "miemss_xamarin.Assets.BLS-CALCIUM CHLORIDE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Administer 20 mg/kg (0.2 mL/kg (0.2 mL/kg) SLOW IVP/IO (50 mg/min) maximum dose 1 gram.",
                AdultDosageDescription = "Administer 0.5-1 gram SLOW IVP over 10 minutes. Maximum dose 1 gram." +
                "Administer 500 mg SLOW IVP for: hypotension following dltiazem administration. Respiratory depression, decreased reflexes, flaccid paralysis, and apnea following magnesium sulfate administration.",
                HasCalculator = true,
                PediatricDosage = 20,
                AdultDosage = 0.5,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Dexamethasone ",
                Details = "Moderate to severe asthma exacerbation. Croup. Anaphylaxis.",
                Path = "miemss_xamarin.Assets.BLS-DEXAMETHASONE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "(a) Asthma: 0.5 mg/kg PO (preferred) or IV to a maximum of 10 mg (b) Croup: 0.5 mg/kg PO/IM/IV to a maximum of 10 mg",
                AdultDosageDescription = "10 mg IV (preferred, if established) or PO",
                HasCalculator = true,
                PediatricDosage = 0.5,
                AdultDosage = 10,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Dextrose ",
                Details = "A water-soluble monosaccharide found in corn syrup and honey. Restores circulating blood sugar and is rapidly utilized following IV injection.",
                Path = "miemss_xamarin.Assets.BLS-DEXTROSE.pdf",
                Category = "BLS",
                AdultDosageDescription = "(a) If blood glucose is less than 70 mg/dL, administer 10% dextrose in 50mL (5 grams) boluses, one minute apart, to a maximum of 250 mL or 25 grams of 50% dextrose IVP, until:" +
                "(i) the patient has a return ot normal mental status, and (ii) the patient's blood glucose is at least 90 mg/dL. (iii)" +
                " If, following 250 mL of 10% dextrose or 25 grams of 50^% dextrose, patient has persistently altered mental status and blood glucose less than 90 mg/dL, repeat dosing regimen in (a).",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Diazepam",
                Details = "Sedation, hypnosis, alleviation of anxiety, muscle relaxation.",
                Path = "miemss_xamarin.Assets.BLS-DIAZEPAM.pdf",
                Category = "BLS",
                AdultDosageDescription = "Administer 2.5-10mg in 2.5 mg increments SLOW IVP/IM (IM requires all providers to obtain medical consultation.). Maximum total dose 10 mg." +
                "Severe nerve agent exposure: Administer 10 mg IM.",
                PediatricDosageDescription = "Administer 0.1 mg/kg in 2.5 mg increments SLOW IVP/IO/IM (IM requires all providers to obtain medical consutation.) Maximum total dose 5 mg. REctal Dose: Administer up to 0.2 mg/kg; maximum total dose 10mg." +
                " Severe nerve agent exposure: greater than 30kg, Administer 10 mg via auto-injuector or 0.1 mg/kg IM, maximum of 10 mg.",
                HasCalculator = true,
                AdultDosage = 2.5,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Diphenhydramine Hydrochloride ",
                Details = "(1) Allergic reaction (2) Anaphylaxis (3) Dystonic reactions",
                Path = "miemss_xamarin.Assets.BLS-DIPHENHYDRAMINE HYDROCHLORIDE.pdf",
                Category = "BLS",
                AdultDosageDescription = "Administer 25-50 mg SLOW IVP or IM",
                PediatricDosageDescription = "ADminister 1 mg/kg SLOW IV/IO or IM",
                HasCalculator = true,
                AdultDosage = 25,
                PediatricDosage = 1,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Dopamine Hydrochloride",
                Details = "(1) Cardiogenic shock (2) Septic shock (3) Anaphylactic shock (4) Hypovolemic shock after sufficient volume replacement.",
                Path = "miemss_xamarin.Assets.BLS-DOPAMINE HYDROCHLORIDE.pdf",
                Category = "BLS",
                AdultDosageDescription = "Administer 2-20 mcg/kg/min IV drip titrated to BP of 100 systolic or medical consultation selected BP; initial infusion rate 2-5 mcg/kg/min",
                PediatricDosageDescription = "Administer 2-20 mcg/kg/min IV drip titrated age specific BP or medical consultation selected BP; initial infusion rate is 2 mcg/kg/min",
                HasCalculator = true,
                AdultDosage = 2,
                PediatricDosage = 2,
                DoseUnit = "mcg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Epinephrine ",
                Details = "The administration of ephinephrine causes increases in: Systemic vascular resistance.",
                Path = "miemss_xamarin.Assets.BLS-EPINEPHRINE.pdf",
                Category = "BLS",
                AdultDosageDescription = "Mix 1 mg of epinephrine (either 1:1,000 or 1:10,000) in a 1 liter bag of LR IV/IO. Initiate an infusion with a wide open macro drip titrating to a systolic pressure of greater than 90 mmHg. When drip administered, this will be reported as an exceptional call.",
                PediatricDosageDescription = "Less than 5 years of age: administer 0.15 mg in 0.15 mL IM. 5 years and greater: administer 0.5 mg in 0.5 mL IM.",
                HasCalculator = false


            });
            Drugs.Add(new Drug
            {
                Name = "Fentanyl ",
                Details = "Synthetic opiod binds with opiate receptors in the CNS, altering both perception and emotional response to pain.",
                Path = "miemss_xamarin.Assets.BLS-FENTANYL.pdf",
                Category = "BLS",
                AdultDosageDescription = "Administer 1 mcg/kg to a maximum initial dose of 200 mcg. Reassess in 5-10 minutes. If pain remains moderate to severe, then administer a second dose of fentanyl 1mcg/kg to a maximum dose of 200 mcg",
                PediatricDosageDescription = "Administer 1 mcg/kg to a maximum initial dose of 200 mcg. Reassess in 5-10 minutes. IF pain remains moderate to severe, thena dminister a second dose of fentanyl 1 mcg/kg to a maximum dose of 200 mcg.",
                HasCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "mcg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Glucagon ",
                Details = "Hormone synthesized by the pancreas.",
                Path = "miemss_xamarin.Assets.BLS-GLUCAGON.pdf",
                Category = "BLS",
                AdultDosageDescription = "Administer 1 mg IM/IN (Medical consult for additional dosing to a maximum of 3 mg IM).",
                PediatricDosageDescription = "(i) 1 mg IM/IN ( 5 years of age up to patient's 18th birthday) (ii) 0.5 mg IM/IN (28 days-4 years of age)",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Haloperidol (Haldol) ",
                Details = "An effective anxiolytic agent. Very effective in the management of aggressive and violent patients.",
                Path = "miemss_xamarin.Assets.BLS-HALOPERIDOL (HALDOL).pdf",
                Category = "BLS",
                AdultDosageDescription = "No description available.",
                PediatricDosageDescription = "No description available.",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Ketamine",
                Details = "(1) The patient reports moderate to severe pain. (2) The patient displaying signs and symptoms of excited delirium syndrome.",
                Path = "miemss_xamarin.Assets.BLS-KETAMINE.pdf",
                Category = "BLS",
                AdultDosageDescription = "Pain Management: Administer 0.2 mg/kg IV/IO over 1-2 minutes. Maximum single dose 20 mg. See more information for further details.",
                PediatricDosageDescription = "Pain Management: Administer 0.2 mg/kg IV/IO over 102 minutes. Maximum single dose 20 mg. See more information for further details.",
                HasCalculator = true,
                AdultDosage = 0.2,
                PediatricDosage = 0.2,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Lactated Ringer's ",
                Details = "Isotonic crystalloid solution.",
                Path = "miemss_xamarin.Assets.BLS-LACTATED RINGER’S.pdf",
                Category = "BLS",
                AdultDosageDescription = "(a) KVO. (b) Initiated IV LR fluid therapy (20 mL/kg bolus). (c) Titrate to a systolic pressure of 100 mmHg.",
                PediatricDosageDescription = "(a) KVO. (b) If age-related vital signs and patient's condition indicate hypoperfusion, administer initial fluid bolus of 20 mL/kg LR IV/IO. See more information for further details.",
                HasCalculator = true,
                AdultDosage = 20,
                PediatricDosage = 20,
                DoseUnit = "mL/kg"


            });
            Drugs.Add(new Drug
            {
                Name = "Lidocaine ",
                Details = "Anesthesia for IO infusions.",
                Path = "miemss_xamarin.Assets.BLS-LIDOCAINE.pdf",
                Category = "BLS",
                AdultDosageDescription = "With an IO infusion: to prevent or treat pain during an IO infusion in patients great than or equal to 13 years of age, administer 20-40 mg (102 mL) of 2% (preservative free) lidocaine IO.",
                PediatricDosageDescription = "IO infusion in patients less than 13 years ofage: To prevent or treat a pain during an IO infusion for pateints under 13 yeares of age, consult a pediatric base station.",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Magnesium Sulfate ",
                Details = "Physiologic calcium channel blocker and also blocks neuromuscular transmission.",
                Path = "miemss_xamarin.Assets.BLS-MAGNESIUM SULFATE.pdf",
                Category = "BLS",
                AdultDosageDescription = "Seizure activity associated wtih pregnancy 4 grams IV/IO over 10 minutes (mixed in 50-100 mL of approved diluent)",
                PediatricDosageDescription = "Seizure activity associated with pregnancy 4 grams IV/IO over 10 minutes (mixed in 50-100 mL of approved diluent).",
                HasCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 50,
                DoseUnit = "mg/kg"


            });
            Drugs.Add(new Drug
            {
                Name = "Midazolam ",
                Details = "Sedative, hypnotic, anticonvulsant.",
                Path = "miemss_xamarin.Assets.BLS-MIDAZOLAM.pdf",
                Category = "BLS",
                AdultDosageDescription = "0.1 mg/kg in 2 mg increments SLOW IVP over 1-2 minutes per increment with maximum single dose 5 mg.",
                PediatricDosageDescription = "0.1 mg/kg in 2 mg increments. SLOW IVP over 1-2 minutes per increment to a maximum single dose of 5 mg.",
                HasCalculator = true,
                AdultDosage = 0.1,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Morphine Sulfate ",
                Details = "(Optional supplement protocol.) Decreases pain perception and anxiety.",
                Path = "miemss_xamarin.Assets.BLS-MORPHINE SULFATE.pdf",
                Category = "BLS",
                AdultDosageDescription = "Administer 0.1 mg/kg to a maximum initial dose of 20 mg.",
                PediatricDosageDescription = "Administer 0.1 mg/kg to a maximum initial dose of 20 mg",
                HasCalculator = true,
                AdultDosage = 0.1,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "Reverses all effects due to opioid (morphine-like) agents. This drug will reverse the respiratory depression and all central and peripheral nervous system effects.",
                Path = "miemss_xamarin.Assets.BLS-NALOXONE.pdf",
                Category = "BLS",
                AdultDosageDescription = "Administer 0.4 - 2 mg IVP/IO (titrated)/IM/IN",
                PediatricDosageDescription = "aDMINISTER 0.1 MG/KG ivp/io (TITRATED/IM/IN).",
                HasCalculator = true,
                AdultDosage = 0.4,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin ",
                Details = "Vasodilator-effect on veins more than arteries.",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN.pdf",
                Category = "BLS",
                AdultDosageDescription = "With history of nitroglycerin use: administer nitroglycerin: 0.4 mg SL.",
                PediatricDosageDescription = "Requires medical consultation from Pediatric Base Station.",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin Paste ",
                Details = "Nitroglycerin paste contains a 2% solution of nitroglycerin in a special absorbent paste.When placed on the skin, nitroglycerin is absorbedinto the systemic circulation.In many cases, it may be preferred over nitroglycerin tablets because of its longer duration of action.",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN PASTE.pdf",
                Category = "BLS",
                PediatricDosageDescription = " Requires medical consultation from Pediatric Base Station.",
                AdultDosageDescription = " 1 inch of the NTG paste is applied. Measuring applicators are supplied.",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Ondansetron ",
                Details = "A selective blocking agent of serotonin 5-HT3 receptor type.",
                Path = "miemss_xamarin.Assets.BLS-ONDANSETRON.pdf",
                Category = "BLS",
                PediatricDosageDescription = "28 days to 12 years old: 0.1 mg/kg SLOW IV over 2-5 minutes. Patients who are 13 to 18 years old: 8 mg ODT or 8 mg SLOW IV over 2-5 minutes.",
                AdultDosageDescription = " 8 mg SLOW IV over 2-5 minutes or 4-8 mg IM or 8 mg orally disintegrating tablet (ODT)",
                HasCalculator = false
            });
            Drugs.Add(new Drug
            {
                Name = "Oxygen ",
                Details = "If evidence of hypoxia (less than 94% SpO2). Respiratory distress. Cardiopulmonary arrest. Trauma. Suspected CO exposure. Dyspenea.",
                Path = "miemss_xamarin.Assets.BLS-OXYGEN.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Administer 12-15 lpm via NRB mask or 2-6 lpm via nasal cannula, as needed. CO exposure: Administer 100% oxygen via NRB mask. Maintain SpO2 at 100%.",
                AdultDosageDescription = "Administer 12-15 lpm via NRB mask or 2-6 lpm via nasal cannula, as needed. CO exposure: Administer 100% oxygen via NRB mask. Maintain SpO2 at 100%.",
                HasCalculator = false

            });
            Drugs.Add(new Drug
            {
                Name = "Sodium Bicarbonate ",
                Details = "Sodium bicarbonate corrects acidosis.",
                Path = "miemss_xamarin.Assets.BLS-SODIUM BICARBONATE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Administer 1 mEq/kg IVP/IO; for patients less than 1 year of age, must be diluted (1:1) with LR.",
                AdultDosageDescription = "Administer 1 mEq/kg IVP bolus initially with 0.5 mEq/kg at 10- minute intervals.",
                HasCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "mEq/kg"

            });
            Drugs.Add(new Drug
            {
                Name = "Verapamil  ",
                Details = "Narrow complex symptomatic atrial fibrillation or atrial flutter.",
                Path = "miemss_xamarin.Assets.BLS-VERAPAMIL.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Contraindicated for patients less than 18 years of age.",
                AdultDosageDescription = "2.5 - 10 mg slow IV over 2 minutes; if response is not adequate, repeat in 15 minutes with a dosage of 2.5 - 10 mg slow IV over 2 minutes with medical consultation.",
                HasCalculator = false

            });

        }

    }
}



