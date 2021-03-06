﻿//using MetalPerformanceShaders;
using System.Collections.Generic;

/*INSTRUCTIONS:
 * You may add records to the database here. This will follow the Drug.cs model
 *and will be stored on the local SQLite database upon starting up app. 
 If you want the text to be on a new line, type "\n" which means newline.*/

namespace miemss_xamarin.Models
{
    public static class DrugData
    {
        public static IList<Drug> Drugs { get; private set; }
        static DrugData()
        {
            Drugs = new List<Drug>();
            //BASIC LIFE SUPPORT (BLS)
            Drugs.Add(new Drug
            {
                //Drug name
                Name = "Acetaminophen", 
                //Description of drug - based on the indications on the protocol
                Details = "Patients ages 2 years and above judged to be in mild to moderate discomfort (e.g., 2–5 on FACES scale).",
                //Path to pdf page on project directory. PDF should always be in Assets folder
                Path = "miemss_xamarin.Assets.BLS-ACETAMINOPHEN.pdf",
                //Drug either ALS or BLS
                Category = "BLS",
                //Description based on dosage on protocol page
                PediatricDosageDescription = "Less than 2 years of age: Not indicated\n2-4 years: Unit dose 160 mg/5 mL\n5-12 years: TWO unit doses of 160 mg/5 ml",
                //Description based on dosage on protocol page
                AdultDosageDescription = "13 years and above: FOUR unit doses of 160 mg/5 mL each for a total of 640 mg/20 mL OR 325 mg pill or tablet x2 for a total of 650 mg",
                //If drug requires calculator, boolean will indicate 
                HasCalculator = false,
                //Check if dosage has a minimum or maximum
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol)",
                Details = "Poisoning by mouth.",
                Path = "miemss_xamarin.Assets.BLS-ACTIVATED CHARCOAL.pdf",
                Category = "BLS",
                PediatricDosageDescription = "MCR: 1 gram/kg orally",
                AdultDosageDescription = "MCR: 1 gram/kg orally",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "gram/kg",
                Unit = "gram",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            Drugs.Add(new Drug
            {
                Name = "Albuterol",
                Details = "(1) Signs and symptoms of repiratory distress.\n(2) Bronchospasm/wheezing associated with:\n\t(a) asthma\n\t(b) chronic bronchitis\n\t(c) emphysema\n\t(d) allergic reactions (anaphylaxis).",
                Path = "miemss_xamarin.Assets.BLS-ALBUTEROL.pdf",
                Category = "BLS",
                PediatricDosageDescription = "2 doses (4 puffs) over 30 minute period (MCR for additional doses).",
                AdultDosageDescription = "2 doses (4 puffs) over 30 minute period (MCR for additional doses).",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"

            });

            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "Suspected Acute Coronary Syndrome and/or ST Elevation MI (STEMI)",
                Path = "miemss_xamarin.Assets.BLS-ASPIRIN.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Not indicated.",
                AdultDosageDescription = "324mg or 325 mg chewed.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine (1:1,000)",
                Details = "(1) Moderate to severe allergic reaction with respiratory distress" +
                       " or mild allergic reaction with history of life-threatening allergic reaction.\n"
                       + "(2) Pediatric patients with severe asthma.",
                Path = "miemss_xamarin.Assets.BLS-EPINEPHRINE AUTO-INJECTOR.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Patients 5 years of age or greater: 0.5 mg in 0.5 mL IM\nPatients less than 5 years of age: 0.15 mg in 0.15 mL IM",
                AdultDosageDescription = "Adult: 0.5 mg in 0.5 mL IM",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine Auto-Injector",
                Details = "(1) Moderate to severe allergic reaction with respiratory distress" + 
                " or mild allergic reaction with history of life-threatening allergic reaction.\n" 
                + "(2) Pediatric patients with severe asthma.",
                Path = "miemss_xamarin.Assets.BLS-EPINEPHRINE AUTO-INJECTOR.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Patients less than 5 years of age: 0.15 mg IM auto-injector OR manual 0.15 mg in 0.15 mL IM (1:1,000) (MCR for additional doses)\nPatients 5 years of age or older: 0.3 mg IM auto-injector OR manual 0.5 mg in 0.5 mL IM (1:1,000) (MCR for additional doses)",
                AdultDosageDescription = "Patients 5 years of age or older: 0.3 mg IM auto-injector OR manual 0.5 mg in 0.5 mL IM (1:1,000) (MCR for additional doses)",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
           

            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "To reverse respiratory depression induced by opioid/narcotic agent.",
                Path = "miemss_xamarin.Assets.BLS-NALOXONE.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Less than 28 days: Contraindicated.\n"
                + "Aged 28 days to adult: 2 mg IN, dividng administration of the dose equally between the nares to a maximum of 1 mL per nare, OR administer 4 mg/0.1 mL IN one nare.\nRepeat as necessary to maintain respiratory activity.",
                AdultDosageDescription = "2 mg IN, dividing administration of the dose equally between the nares to a maximum of 1 mL per nare OR administer 4 mg/0.1 mL IN in one nare.\nRepeat as necessary to maintain respiratory activity.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin",
                Details = " Patient must have own prescribed sublingual nitroglycerin. Chest pain.",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Not indicated for children under 13 years of age",
                AdultDosageDescription = "1 tablet/spray sublingually; repeat in 3-5 minutes; maximum of 3 doses (patient-administered and EMT-administered)(MCR for additional doses; BP must begreater than 90 systolic and pulse must greater than 60 bpm)",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            Drugs.Add(new Drug
            {
                Name = "Oral Glucose",
                Details = "(1) Altered mental status with known diabetic history\n(2) Unconscious for an unknown reason.",
                Path = "miemss_xamarin.Assets.BLS-ORAL GLUCOSE.pdf",
                Category = "BLS",
                PediatricDosageDescription = " Administer 10-15 grams of glucose paste between the gum and cheek. " +
                "Consider single additional dose of glucose paste if not improved after 10 minutes.",
                AdultDosageDescription = "Administer 10-15 grams of glucose paste between the gum and cheek. Consider esingle additional dose of glucose paste if not improved after 10 minutes.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            //Drugs.Add(new Drug
            //{
            //    Name = "MARK I/ DuoDote (CHEMPACK)",
            //    Details = "",
            //    Path = "miemss_xamarin.Assets.ALS-ORAL GLUCOSE.pdf",
            //    Category = "BLS",
            //    PediatricDosageDescription = "Mild:\n< 10 kg: Atropine 0.5 mg\n10-25 kg: Atropine 1 mg IM\n26-50 kg: Atropine 2 mg IM\n>50 kg: Atropine 2 mg IM\nMay repeat every 3-5 minutes until symptoms resolve\n" +
            //    "Moderate:\n<10 kg: Atropine 1 mg IM and Pralidoxime (2PAM) 600 mg IM\n10-25 kg: Atropine 2 mg IM and Pralidoxime (2PAM) 600 mg IM\n26-50 kg: Atropine 2 mg IM and Pralidoxime (2PAM) 1200 mg IM\n>50 kg: Atropine 2 mg IM and pralidoxime (2PAM) 1200 m IM\nMay repeat every 3-5 minutes until symptoms resolve.\n" +
            //    "Severe:\nUp to 25 kg: Atropine 2mg IM and Pralidoxime (2PAM) 600 mg IM and either diazepam 2.5 mg IM or midazolam 2.5 mg IM.\n26-50 kg: atropine 4 mg IM and Pralidoxime (2PAM) 1200 mg IM and either diazepam 5 mg IM or midazolam 5 mg IM\n>50 kg: Atropine 6 mg IM and Pralidoxime (2PAM) 1800 mg IM and either diazepam 10 mg IM or midazolam 10 mg IM\nNOTE: each DuoDate or MARK 1 kit contains 2 mg Atropine and 600 mg pralidoxime",
            //    AdultDosageDescription = "Mild:\nAtropine 2 mg IM and Pralidoxime (2PAM) 600 mg IM. May repeat every 3-5 minutes until symptoms resolve.\n" + "Moderate:\nAtropine 4 mg IM Pralidoxime (2PAM) 1800 mg IM and either diazeparn 10 mg IM or midazolam 10 mg IM\nMay repeat every 3-5 minutes until symptoms resolve\nNote: each DuoDote or MARK 1 kit contains 2 mg Atropine and 600 mg pralidoxime.",
            //    HasCalculator = false
            //});

            Drugs.Add(new Drug
            {
                Name = "Oxygen",
                Details = "(1) If evidence of hypoxia.\n(2) Respiratory distress.\n(3) Cardiopulmonary arrest.\n(4) Trauma.\n(5) Suspected CO exposure.\n(6) Dyspena.",
                Path = "miemss_xamarin.Assets.BLS-OXYGEN.pdf",
                Category = "BLS",
                PediatricDosageDescription = "Administer 12–15 lpm via NRB mask or 2-6 lpm via nasal cannula, as needed.",
                AdultDosageDescription = "Administer 12–15 lpm via NRB mask or 2–6 lpm via nasal cannula, as needed.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            //ALS DRUGS
            Drugs.Add(new Drug
            {
                Name = "Acetaminophen",
                Details = "Patients ages 2 years and above judged to be in mild to moderate discomfort (e.g., 2-5 on FACES scale).",
                Path = "miemss_xamarin.Assets.ALS-ACETAMINOPHEN.pdf",
                Category = "ALS",
                PediatricDosageDescription = "(1) Less than 2 years of age: Not indicated\n(2)2-4 years: Unit dose 160 mg/5 mL.\n(3) 5-12 years: TWO unit doses of 160 mg/5mL each for a total of 320 mg/10 mL.",
                AdultDosageDescription = "13 years and above: FOUR unit doses of 160 mg/5 mL each for a total of 640 mg/20 mL " +
                "or in a form of 325 mg pill or tablet x2 for a total of 650 mg with sips of water as tolerated by the patient.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol) ",
                Details = "Poisoning by mouth.",
                Path = "miemss_xamarin.Assets.ALS-ACTIVATED CHARCOAL.pdf",
                Category = "ALS",
                PediatricDosageDescription = " 1 gram/kg orally.\nConsider consultation with Poison Center",
                AdultDosageDescription = " 1 gram/kg orally.\nConsider consultation with Poison Center",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "gram/kg",
                Unit = "gram",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Adenosine ",
                Details = "(1) To slow the rate of narrow complex tachycardia\n(2) Is only effective on SVT/PSVT\n(3) No effect on ventricular tachycardia, atrial fibrillation, or flutter\n(4) In stable, wide complex tachycardia (possible ventricular tachycardia) for pediatric with caution.",
                Path = "miemss_xamarin.Assets.ALS-ADENOSINE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "0.1 mg/kg rapid IVP/IO; maximum initial dose 6 mg\n0.2 mg/kg for 2nd/3rd doses;maximum single additional 12 mg dose, ",
                AdultDosageDescription = "6 mg rapid IVP/IO\n12 mg rapid within 2 mins,if no reponses" +
                "\n12 mg rapid within another 1~2 mins,if no reponses",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                AdultDosage = 6,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "initial,repeat dose"
            });
            Drugs.Add(new Drug
            {
                Name = "Albuterol",
                Details = "(1) To reverse bronchospasm (wheezing)\n(2) Hyperkalemia",
                Path = "miemss_xamarin.Assets.ALS-ALBUTEROL.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Bronchospasm: May repeat one time;connect to 6-8 lpm of oxygen; \n(a)Less than 2 years of age: 1.25 mg by nebulized aerosol\n" +
                "(b)2 years of age or older: 2.5 mg by nebulized aerosol\n Hyperkalemia:\n (a)Less than 2 years of age: 1.25 mg by nebulized aerosol\n(b)2 years of age or older: 2.5 mg by nebulized aerosol",
                AdultDosageDescription = "Bronchospasm:\n2.5 mg by nebulized aerosol connected to 6-8 lpm of oxygen; may repeat one time\nHyperkalemia: 20 mg (if available) by nebulized aerosol connected to 6-8 lpm of oxygen",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Amiodarone",
                Details = "(1) Prevent recurrence of ventricular fibrillation/tachycardia after defibrillation\n(2) Ventricular tachycardia (VT)\n(3) Ventricular fibrillation (VF)",
                Path = "miemss_xamarin.Assets.ALS-AMIODARONE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Pediatric with pulse: 5 mg/kg IV/IO over 20 minutes (mixed in 50 - 100 mL of approved diluent).\n" +
                "Pediatric without pulse: 5 mg/kg IV/IO; max single dose 300 mg. May repeat twice to a maximum of 15 mg/kg.",
                AdultDosageDescription = "Adult with pulse: 150 mg IV/IO over 10 minutes (mixed in 50 - 100 mL of approved diluent). May repeat once.\n" +
                "Adult without pulse VF/VT/(torsades after magnesium sulfate): 300 mg IV/IO. May repeat one time. 150 mg IV/IO",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                PediatricDosage = 5,
                AdultDosage = 150,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = true,
                CategoryList = "default",
                ChildMinDose = 5,
                ChildMaxDose = 300
            }); ;
            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "Suspected Acute Coronary Syndrome and/or ST Elevation MI (STEMI)",
                Path = "miemss_xamarin.Assets.ALS-ASPIRIN.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Not indicated",
                AdultDosageDescription = "324 mg or 325 mg chewed",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Atropine Sulfate",
                Details = "(1) Symptomatic bradycardia\n(2) Organophosphate poisoning\n(3) Nerve agents",
                Path = "miemss_xamarin.Assets.ALS-ATROPINESULFATE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Bradycardia: 0.02 mg/kg IV/IO; 0.04-0.06 mg/kg ET, dilute 5 mL\nMCR: Organophosphate poison: 0.02 mg/kg IVP/IO or IM every 5-10 minutes",
                AdultDosageDescription = "Bradycardia:0.5-1 mg IVP every 3-5 minutes; maximum 0.04 mg/kg\n" + "MCR: Organophosphate poisoning: 2-6 mg IVP/IM every 5-10 minutes (depending on severity; see MARK 1 / DuoDote)",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                PediatricDosage = 0.02,
                AdultDosage = 0.05,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
           
            Drugs.Add(new Drug
            {
                Name = "Calcium Chloride",
                Details = "(1) Hyperkalemia\n(2) Hypocalcemia\n(3) To treat adverse effects caused by calcium channel blocker overdose\n(4) Hypotension secondary to diltiazem administration\n" +
                "(5) Respiratory depression, decreased reflexes, flaccid paralysis, and apnea following magnesium sulfate administration",
                Path = "miemss_xamarin.Assets.ALS-CALCIUM CHLORIDE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Administer 20 mg/kg (0.2 mL/kg) SLOW IVP/IO (50 mg/min); maximum 1 gram",
                AdultDosageDescription = "Administer 0.5-1 gram slow IVP; over 10 minutes; maximum dose 1 gram\nAdminister 500 mg SLOW IVP for: hypotension following diltiazem administration\n" +
                "Respiratory depression, decreased reflexes, flaccid paralysis, and apnea following magnesium sulfate administration",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                PediatricDosage = 20,
                AdultDosage = 0.5,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = true,
                ChildMaxDose = 1000,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Dexamethasone ",
                Details = "(1)Moderate to severe asthma exacerbation\n(2) Croup\n(3) Anaphylaxis",
                Path = "miemss_xamarin.Assets.ALS-DEXAMETHASONE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "0.5 mg/kg by mouth (preferred) or IV to a maximum of 10 mg (IM site may be used for croup)",
                AdultDosageDescription = "10 mg IV (preferred, if established) or by mouth",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                PediatricDosage = 0.5,
                AdultDosage = 10,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = true,
                CategoryList = "default",
                ChildMaxDose = 10
            });
            Drugs.Add(new Drug
            {
                Name = "Dextrose ",
                Details = "Correction of altered mental status due to low blood sugar (hypoglycemia) seizures and cardiac arrest",
                Path = "miemss_xamarin.Assets.ALS-DEXTROSE.pdf",
                Category = "ALS",
                AdultDosageDescription = "Administer D10 (10% dextrose) in 50 mL (5 grams) IV boluses, one min apart, to a maximum of 250 mL OR administer D50 (50% dextrose)-50 mL (25 grams) IVP",
                PediatricDosageDescription="Less than 28 days of age: 2 mL/kg of D10W IV/IO\n28 days of age up to 18th birthday: 2-4 mL/kg D10W IV/IO; maximum 25 grams",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                PediatricDosage =2,
                AdultDosage=0,
                DoseUnit="mL/kg",
                Unit="mL",
                HasMinMaxAdultDose = true,
                HasMinMaxChildDose = true,
                CategoryList = "default",
                ChildMaxDose = 25,
                AdultMaxDose = 250
            });
            Drugs.Add(new Drug
            {
                Name = "Diazepam",
                Details = "(1) Sustained and/or recurrent seizures\n(2) Severe nerve agent exposure",
                Path = "miemss_xamarin.Assets.ALS-DIAZEPAM.pdf",
                Category = "ALS",
                AdultDosageDescription = "Seizures: 2.5 mg-10 mg in 2.5 mg increments SLOW IVP/IM (MCR for IM dosing); maximum total dose of 10 mg\nSevere nerve agent exposure: 10 mg IM",
                PediatricDosageDescription = "Seizures: 0.1 mg/kg in 2.5 mg increments SLOW IVP/IO/IM  (MCR for IM dosing); maximum total dose of 5 mg\n Rectal dose: 0.2 mg/kg; maximum total dose of 10 mg\nSevere nerve agent exposure: Greater than 30 kg/66 lbs: administer 10 mg via auto-injector or 0.1 mg/kg IM; maximum 10 mg",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                AdultDosage = 2.5,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = true,
                CategoryList = "default",
                ChildMaxDose = 5,
               
            });

            Drugs.Add(new Drug
            {
                Name = "Diltiazem",
                Details = "Symptomatic atrial fibrillation and atrial flutter",
                Path = "miemss_xamarin.Assets.ALS-DILTIAZEM.pdf",
                Category = "ALS",
                AdultDosageDescription = "(a) 0.25 mg/kg (maximum dose 20 mg) by IV bolus administered SLOW IV over 2 minutes; if response is not adequate, repeat in 15 minutes with a dosage of 0.35 mg/kg (maximum dose 25 mg) over 2 minutes.\n" +
                "For patients older than 50 years of age, borderline blood pressure, known renal failure, or CHF, consider initial bolus 5-10 administered IV over 2 minutes.",
                PediatricDosageDescription = "MCR: contraindicated for children less than 18 years of age. If needed, consult Pediatric Base Station.",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 0.25,
                PediatricDosage = 0,
                DoseUnit = "mg/kg",
                Unit = "mg",
                CategoryList = "initial,default",
                HasMinMaxAdultDose = true,
                HasMinMaxChildDose = false,
                AdultMaxDose =20
            });
            Drugs.Add(new Drug
            {
                Name = "Diphenhydramine Hydrochloride ",
                Details = "(1) Allergic reaction \n(2) Anaphylaxis\n(3) Dystonic reactions",
                Path = "miemss_xamarin.Assets.ALS-DIPHENHYDRAMINE HYDROCHLORIDE.pdf",
                Category = "ALS",
                AdultDosageDescription = "Administer 25-50 mg SLOW IVP or IM",
                PediatricDosageDescription = "Administer 1 mg/kg SLOW IV or IM",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                AdultDosage = 25,
                PediatricDosage = 1,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = true,
                CategoryList = "default",
                ChildMinDose = 25,
                ChildMaxDose = 50
            });
            Drugs.Add(new Drug
            {
                Name = "Dopamine Hydrochloride",
                Details = "(1) Cardiogenic shock\n(2) Septic shock\n(3) Anaphylactic shock\n(4) Hypovolemic shock after sufficient volume replacement.",
                Path = "miemss_xamarin.Assets.ALS-DOPAMINE.pdf",
                Category = "ALS",
                AdultDosageDescription = "MCR:\nAdminister 2-20 mcg/kg/min IV drip titrated to BP of 100 systolic or medical consultation selected BP; initial infusion rate 2-5 mcg/kg/min",
                PediatricDosageDescription = "MCR:\nAdminister 2-20 mcg/kg/min IV drip titrated age specific BP or medical consultation selected BP; initial infusion rate is 2 mcg/kg/min",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 0,
                PediatricDosage = 0,
                DoseUnit = "mcg/kg",
                Unit = "mcg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Epinephrine 1:10,000/1:1,000",
                Details = "(1) Medical cardiac arrest and pediatric traumatic arrest\n(2) Moderate to severe allergic reaction/anaphylaxis\n(3) IV push epinephrine should be reserved for cardiact arrest patients\n" +
                "(4) Epinephrine infusion(IV/IO) should be reserved for patients in shock refractory to fluid bolus or for patients in anaphylactic shock\n(5) Severe asthma\n(6) Respiratory stridor (suspected croup)",
                Path = "miemss_xamarin.Assets.ALS-EPINEPHRINE.pdf",
                Category = "ALS",
                AdultDosageDescription = "Administer 1 mg (1:10,000) IVP/IO every 4 minutes to a maximum of 4 doses for the initial arrest.\nIf arrest recurs following any period of ROSC, administer a maximum of 2 additional doses",
                PediatricDosageDescription = "Administer 0.01 mg/kg (0.1 mL/kg) of 1:10,000 IVP/IO every 4 minutes to a maximum of 4 doses for the initial arrest.\nIf arrest recurs following any period of ROSC, administer a maximum of 2 additional doses.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Fentanyl",
                Details = "Onset of action 2-3 minutes after IV dose and effects last 30 minutes to 1 hour.",
                Path = "miemss_xamarin.Assets.ALS-FENTANYL.pdf",
                Category = "ALS",
                AdultDosageDescription = "Administer 1 mcg/kg to a maximum initial dose of 200 mcg (max 1 mL per nare). Reassess in 5-10 minutes.\n If pain remains moderate to severe, then administer a second dose of fentanyl 1mcg/kg to a maximum dose of 200 mcg",
                PediatricDosageDescription = "Administer 1 mcg/kg to a maximum initial dose of 200 mcg (max 1 mL per nare). Reassess in 5-10 minutes.\n If pain remains moderate to severe, then  administer a second dose of fentanyl 1 mcg/kg to a maximum dose of 200 mcg.",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "mcg/kg",
                Unit = "mcg",
                HasMinMaxAdultDose = true,
                HasMinMaxChildDose = true,
                AdultMaxDose = 200,
                ChildMaxDose = 200,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Glucagon ",
                Details = "(1) Patients with altered mental status who are suspected of being hypoglycemic where IV access is not obtainable\n(2) Beta blocker overdose",
                Path = "miemss_xamarin.Assets.ALS-GLUCAGON.pdf",
                Category = "ALS",
                AdultDosageDescription = "Hypoglycemia: 1 mg IM/IN (MCR for additional doses, up to a maximum of 3 mg)\nMCR: Beta-blocker OD: 1 mg IVP every 5 minutes.",
                PediatricDosageDescription = "Hypoglycemia:\n28 days of age to 4 years of age: 0.5 mg IM/IN\n5 years of age up to 18th birthday: 1 mg IM/IN; (MCR for additional doses, up to maximum 3 mg)\nMCR: Beta-blocker OD:\n28 days of age to 4 years of age: 0.5 mg IVP every 5 minutes\n5 years of age up to 18th birthday: 1 mg IVP every 5 minutes",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Haloperidol (Haldol) ",
                Details = "Chemical restraint for violent, agitated, and aggressive patients who present a danger to themselves or to others and who cannot be safely managed other? wise. Most violent/agitated patients can be handled with verbal or physical restraint alone.",
                Path = "miemss_xamarin.Assets.ALS-HALOPERIDOL.pdf",
                Category = "ALS",
                AdultDosageDescription = "(a) Patients 18-69 years of age:\n5 mg IM or IV\n(b) Patients greater than 69 years of age:\n2.5 mg IV or IV",
                PediatricDosageDescription = "(a) Child less than 5 years of age:\ncontraindicated\n(b) Child 5-12 years of age:\0.05 mg/kg IM or IV, max of 2.5 mg\n(c) Patients 13 up to 18th birthday\n2.5-5 mg IM or IV",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                AdultDosage = 0,
                PediatricDosage = 0.05,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"

            });

            Drugs.Add(new Drug
            {
                Name = "Ipratropium(Atrovent)",
                Details = "Anticholinergic (parasympatholytic) bronchodilator, Bronchodilator is site-specific, not systemic. Dries respiratory tract secretions. Most effective in combination with a beta-adrenergic bronchodilator.",
                Path = "miemss_xamarin.Assets.ALS-IPRATROPIUM.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Less than 1 year of age: contraindicated\n1 to less than 2 years of age: 250 mcg (1.25 mL) by nebulized aerosol\n2 years of age or older: 500 mcg (2.5 mL) by nebulized aerosol",
                AdultDosageDescription = "Single administration ONLY, 500 mcg (2.5 mL) by nebulized aerosol connected to 6-8 lpm of oxygen in combination with albuterol 2.5 mg",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            //Drugs.Add(new Drug
            //{
            //    Name = "Ipraropium(Atrovent)",
            //    Details = "(1) Allergic reactions/anaphylaxis\n(2) Bronchial asthma\n(3) Reversible bronchospasms associated with chronic bronchitis and emphysema",
            //    Path = "miemss_xamarin.Assets.ALS-ATROVENT.pdf",
            //    Category = "ALS",
            //    PediatricDosageDescription = "Single administration ONLY. In combination with albuterol, nebulized aerosol is connected to 6-8 lpm of oxygen. (a) Less than 1 year of age: contraindicated. (b) Age 1 year but less than 2 years: 250 mcg (1.25 mL) by nebulized aerosol. (c) 500 mcg (2.5 mL) by nebulized aerosol.",
            //    AdultDosageDescription = "Single administration ONLY, 500 mcg (2.5 mL) by nebulized aerosol connected to 6-8 lpm of oxygen incombinatin with albuterol 2.5 mg",
            //    HasCalculator = false
            //});

            Drugs.Add(new Drug
            {
                Name = "Ketamine",
                Details = "(1) The patient reports moderate to severe pain.\n(2) The patient displaying signs and symptoms of excited delirium syndrome\n(3) Ventilatory difficulty secondary to bucking or combativeness in intubated patients\n(4) CPR-induced awareness",
                Path = "miemss_xamarin.Assets.ALS-KETAMINE.pdf",
                Category = "ALS",
                AdultDosageDescription = "Pain Management: Administer 0.2 mg/kg IV/IO over 1-2 minutes. Maximum single dose 20 mg. See more information for further details.",
                PediatricDosageDescription = "Pain Management: Administer 0.2 mg/kg IV/IO over 102 minutes. Maximum single dose 20 mg. See more information for further details.",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 0.2,
                PediatricDosage = 0.2,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Ketorolac",
                Details = "a) Management of moderate to severe acute pain\nb) Consider as a first line medication for renal stones/colic\nc) Burns - mild to moderate\nd) Non-traumatic neuromuscular pain",
                Path = "miemss_xamarin.Assets.ALS-KETOROLAC.pdf",
                Category = "ALS",
                AdultDosageDescription = "Administer single dose of 15 mg IV only. No repeat doses.\nIf IV is unavailable: Administer single dose of 30 mg IM. No repeat doses.",
                PediatricDosageDescription = "(1) Newly born to 2 years of age: Contraindicated\n(2) Age 2 to patients who have not reached their 18th birthday: Administer 0.5 mg/kg IV only to a maximum total dose of 15 mg. No repeat doses.\nIf IV is unavailable: Administer 1 mg/kg IM to a maximum total dose of 30 mg. No repeat doses.",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                AdultDosage = 0,
                PediatricDosage = 0.5,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Lactated Ringer's ",
                Details = "(1) Hypovolemia (limitation in multiple/severe trauma without head injury)\n(2) Keep vein open\n(3) Fluid boluses",
                Path = "miemss_xamarin.Assets.ALS-LACTATED RINGER'S.pdf",
                Category = "ALS",
                AdultDosageDescription = "(i) For patients with multiple/severe trauma but without head injury: Administer small boluses of LR (maximum single bolus of 250 mL prior to additional blood pressure check) to achieve and maintain a systolic bloodpressure of greater than or equal to 90mmHg.\n" +
                "(ii) For multiple/severe trauma with head injury: Administer small boluses of LR (maximum single bolus of 250 mL prior to additional blood pressure check) to achieve and maintain a systolic blood pressure greater than or equal to 110 mmHg.\n"+
                "(iii) For all other patients: Titrate to a systolic pressure of 90 mmHg. Maximum dose 2,000 mL without medical consultation.",
                PediatricDosageDescription = "(a) KVO\n(b) If age-related vital signs and patient's condition indicate hypoperfusion, administer initial fluid bolus of 20 mL/kg LR IV/IO. Fluid boluses for neonates and volume-sensitive children are 10 mL/kg.\n" +
                "(c) If patient's condition does not improve, administer the second fluid bolus of 20 mL/kg LR/IV/IO.\n(d) Third and subsequent fluid boluses at 20 mL/kg LR IV/IO with medical consultation.",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 20,
                PediatricDosage = 20,
                DoseUnit = "mL/kg",
                Unit = "mL",
                HasMinMaxAdultDose = true,
                HasMinMaxChildDose = false,
                AdultMaxDose =2000,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Lidocaine ",
                Details = "(1) Anesthesia for IO infusions\n(2) Nasal tracheal intubation\n",
                Path = "miemss_xamarin.Assets.ALS-LIDOCAINE.pdf",
                Category = "ALS",
                AdultDosageDescription = "With an IO infusion: to prevent or treat pain during an IO infusion in patients greater than or equal to 13 years of age, administer 20-40 mg (1~2 mL) of 2% (preservative free) lidocaine IO.",
                PediatricDosageDescription = "IO infusion in patients less than 13 years of age: To prevent or treat a pain during an IO infusion for patients under 13 yeares of age, consult a pediatric base station.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Magnesium Sulfate ",
                Details = "(1) Torsades de pointes\n(2) Seizures with pregnancy\n(3) Refractory VF and VT after amiodarone administration\n(4) Moderate to severe asthma/bronchospasm exacerbation",
                Path = "miemss_xamarin.Assets.ALS-MAGNESIUM SULFATE.pdf",
                Category = "ALS",
                AdultDosageDescription = "Seizure activity associated wtih pregnancy 4 grams IV/IO over 10 minutes (mixed in 50-100 mL of approved diluent)",
                PediatricDosageDescription = "Seizure activity associated with pregnancy 4 grams IV/IO over 10 minutes (mixed in 50-100 mL of approved diluent).",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 50,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Midazolam ",
                Details = "(1) Sustained and/or recurrent seizures\n(2) Precardioversion to reduce anxiety\n(3) Awake patient requiring transcutaneous pacing (TCP)\n(4) Nasal Tracheal Intubation\n(5) Implanted Cardioverter Defibrillator (ICD) Malfunction",
                Path = "miemss_xamarin.Assets.ALS-MIDAZOLAM.pdf",
                Category = "ALS",
                AdultDosageDescription = "0.1 mg/kg in 2 mg increments SLOW IVP over 1-2 minutes per increment with maximum single dose 5 mg.",
                PediatricDosageDescription = "0.1 mg/kg in 2 mg increments. SLOW IVP over 1-2 minutes per increment to a maximum single dose of 5 mg.",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 0.1,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = true,
                AdultMaxDose = 5,
                HasMinMaxChildDose = true,
                ChildMaxDose = 5,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Morphine Sulfate ",
                Details = "(1) The patient reports moderate to severe pain.\n(2) In the clinician's judgement the patient will benefit from treatment with an opioid analgesic, including patients who are MOLST and/or EMS/DNR patients or being pre-medicated for a procedure\n(3) Pulmonary Edema/Congestive Heart Failure (pediatric only)",
                Path = "miemss_xamarin.Assets.ALS-MORPHINE SULFATE.pdf",
                Category = "ALS",
                AdultDosageDescription = "Administer 0.1 mg/kg to a maximum initial dose of 20 mg.",
                PediatricDosageDescription = "Administer 0.1 mg/kg to a maximum initial dose of 20 mg",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 0.1,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = true,
                HasMinMaxChildDose = true,
                AdultMaxDose = 20,
                ChildMaxDose = 20,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "To reverse respiratory depression induced by opioids.",
                Path = "miemss_xamarin.Assets.ALS-NALOXONE.pdf",
                Category = "ALS",
                AdultDosageDescription = "Administer 0.4 - 2 mg IVP/IO (titrated)/IM/IN (Max 1mL each nare for IN administration)",
                PediatricDosageDescription = "Administer 0.1 mg/kg IVP/IO (titrated)/IM/IN.",
                HasCalculator = true,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                AdultDosage = 0.4,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg",
                Unit = "mg",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = true,
                ChildMaxDose = 2,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin ",
                Details = "(1)For treatment of angina\n(2) Congestive heart failure, acute pulmonary edema.",
                Path = "miemss_xamarin.Assets.ALS-NITROGLYCERIN.pdf",
                Category = "ALS",
                AdultDosageDescription = "If patient has a prescription or previous history of nitroglycerin use, administer nitroglycerin: 0.4 mg SL(may repeat dose 2 times at 3–5 minute intervals)\n" +
                "May be repeated if symptoms persist, BP is greater than 90 mmHg, and pulse is greater than 60 bpm, to a maximum dose of 1.2 mg",
                PediatricDosageDescription = "Requires medical consultation from Pediatric Base Station.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin Paste ",
                Details = "Patients in respiratory distress with moderate or severe symptoms and elevated systolic blood pressure.",
                Path = "miemss_xamarin.Assets.ALS-NITROGLYCERIN PASTE.pdf",
                Category = "ALS",
                PediatricDosageDescription = " Requires medical consultation from Pediatric Base Station.",
                AdultDosageDescription = " 1 inch of the NTG paste is applied. Measuring applicators are supplied.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"

            });
            Drugs.Add(new Drug
            {
                Name = "Ondansetron ",
                Details = "(1) Prevention and control of nausea and/or vomiting\n(2) Ondansetron can be administered in an effort to reduce the nausea or vomiting complications associated with certain existing injuries, medical illness, or medication side effects (e.g., penetrating eye injury, high risk for aspiration, or following opioid administration).",
                Path = "miemss_xamarin.Assets.ALS-ONDANSETRON.pdf",
                Category = "ALS",
                PediatricDosageDescription = "28 days to 12 years old: 0.1 mg/kg SLOW IV over 2-5 minutes. Patients who are 13 to 18 years old: 8 mg ODT or 8 mg SLOW IV over 2-5 minutes.",
                AdultDosageDescription = " 8 mg SLOW IV over 2-5 minutes or 4-8 mg IM or 8 mg orally disintegrating tablet (ODT)",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = true,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                AdultDosage = 0.1,
                PediatricDosage = 0.1,
                DoseUnit = "mg/kg",
                Unit = "mg",
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Oxygen ",
                Details = "(1) If evidence of hypoxia (less than 94% SpO2)\n(2) Respiratory distress\n(3) Cardiopulmonary arrest\n(4) Trauma\n(5) Suspected CO exposure\n(6) Dyspenea.",
                Path = "miemss_xamarin.Assets.ALS-OXYGEN.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Administer 12-15 lpm via NRB mask or 2-6 lpm via nasal cannula, as needed. CO exposure: Administer 100% oxygen via NRB mask. Maintain SpO2 at 100%.",
                AdultDosageDescription = "Administer 12-15 lpm via NRB mask or 2-6 lpm via nasal cannula, as needed. CO exposure: Administer 100% oxygen via NRB mask. Maintain SpO2 at 100%.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"

            });
            Drugs.Add(new Drug
            {
                Name = "Sodium Bicarbonate ",
                Details = "(1) used in cardiac arrest only after more definitive treatments\n(2) Hyperkalemia\n(3) Tricyclic and phenobarbital overdose\n",
                Path = "miemss_xamarin.Assets.ALS-SODIUM BICARBONATE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Administer 1 mEq/kg IVP/IO; for patients less than 1 year of age, must be diluted (1:1) with LR.",
                AdultDosageDescription = "Administer 1 mEq/kg IVP bolus initially with 0.5 mEq/kg at 10- minute intervals.",
                HasCalculator = true,
                HasAdultCalculator = true,
                HasPediatricCalculator = true,
                AdultDosage = 1,
                PediatricDosage = 1,
                DoseUnit = "mEq/kg",
                Unit = "mEq",
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });

            Drugs.Add(new Drug
            {
                Name = "Terbutaline ",
                Details = "(1) Asthma\n(2) Reversible airway obstruction associated with bronchitis or emphysema.",
                Path = "miemss_xamarin.Assets.ALS-TERBUTALINE.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Patients less than 12 years of age: Not indicated.",
                AdultDosageDescription = "Patients 12 years of age and older:\nAdminister 0.25 mg IM. May repeat one time after 15 minutes if there is not adequate improvement. Maximum total dose 0.5 mg IM.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
            Drugs.Add(new Drug
            {
                Name = "Verapamil  ",
                Details = "Narrow complex symptomatic atrial fibrillation or atrial flutter.",
                Path = "miemss_xamarin.Assets.ALS-VERAPAMIL.pdf",
                Category = "ALS",
                PediatricDosageDescription = "Contraindicated for patients less than 18 years of age.",
                AdultDosageDescription = "2.5 - 10 mg slow IV over 2 minutes; if response is not adequate, repeat in 15 minutes with a dosage of 2.5 - 10 mg slow IV over 2 minutes with medical consultation.",
                HasCalculator = false,
                HasAdultCalculator = false,
                HasPediatricCalculator = false,
                HasMinMaxAdultDose = false,
                HasMinMaxChildDose = false,
                CategoryList = "default"
            });
      

        }

    }
}



