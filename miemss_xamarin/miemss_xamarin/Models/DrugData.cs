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
                Details = "Patients ages 2 years and above judged to be in mild to moderate discom-fort (e.g., 2–5 on FACES scale).",
                Path = "miemss_xamarin.Assets.ALS-ACETAMINOPHEN.pdf",
                Category = "ALS"

            });

            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol)",
                Details = "Poisoning by mouth",
                Path = "miemss_xamarin.Assets.ALS-ACTIVATED CHARCOAL.pdf",
                Category = "ALS"

            });

            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "Chest pain when acute myocardial infarction is suspected.",
                Path = "miemss_xamarin.Assets.ALS-ASPIRIN.pdf",
                Category = "ALS"

            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine(1:1,000)",
                Details = "Moderate to severe allergic reaction with respiratory distress or mild allergic reaction with history of life-threatening allergic reaction.",
                Path = "miemss_xamarin.Assets.ALS-EPINEPHRINE.pdf",
                Category = "ALS"

            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine Auto-Injector",
                Details = "Moderate to severe allergic reaction with respiratory distress or mild allergic reaction with history of life-threatening allergic reaction.",
                Path = "miemss_xamarin.Assets.ALS-EPINEPHRINE AUTO-INJECTOR.pdf",
                Category = "ALS"


            });

            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "Reverses all effects due to opioid (morphine-like) agents. This drug will reverse the respiratory depression and all central and peripheral nervous system effects.",
                Path = "miemss_xamarin.Assets.ALS-NALOXONE (NARCAN).pdf",
                Category = "ALS"


            });

            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin",
                Details = " Patient must have own prescribed sublingual nitroglycerin. Chest pain.",
                Path = "miemss_xamarin.Assets.ALS-NITROGLYCERIN.pdf",
                Category = "ALS"

            });

            Drugs.Add(new Drug
            {
                Name = "Oral Glucose",
                Details = "Altered mental status with known diabetic history. Unconscious for an unknown reason.",
                Path = "miemss_xamarin.Assets.ALS-ORAL GLUCOSE.pdf",
                Category = "ALS"


            });

            Drugs.Add(new Drug
            {
                Name = "Oxygen",
                Details = "Increases oxygen content of the blood. Improves tissue oxygenation. Decreases energy expended for respiratiohn.",
                Path = "miemss_xamarin.Assets.ALS-OXYGEN.pdf",
                Category = "ALS"

            });
            Drugs.Add(new Drug
            {
                Name = "Acetaminophen",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ACETAMINOPHEN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol) ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ACTIVATED CHARCOAL.pdf",
                Category = "BLS"


            });
            Drugs.Add(new Drug
            {
                Name = "Adenosine ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ADENOSINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Albuterol ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ALBUTEROLSULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Amiodarone",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-AMIODARONE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ASPIRIN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Atropine Sulfate",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ATROPINESULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Atrovent",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ATROVENT.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Calcium Chloride",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-CALCIUM CHLORIDE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Dexamethasone ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DEXAMETHASONE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Dextrose ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DEXTROSE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Diazepam",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DIAZEPAM.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Diphenhydramine Hydrochloride ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DIPHENHYDRAMINE HYDROCHLORIDE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Dopamine Hydrochloride",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DOPAMINE HYDROCHLORIDE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Epinephrine ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-EPINEPHRINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Fentanyl ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-FENTANYL.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Glucagon ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-GLUCAGON.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Haloperidol (Haldol) ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-HALOPERIDOL (HALDOL).pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Ketamine",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-KETAMINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Lactated Ringer's ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-LACTATED RINGER’S.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Lidocaine ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-LIDOCAINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Magnesium Sulfate ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-MAGNESIUM SULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Midazolam ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-MIDAZOLAM.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Morphine Sulfate ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-MORPHINE SULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Naloxone ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-NALOXONE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin Paste ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN PASTE.pdf",
                Category = "BLS"
            });
            Drugs.Add(new Drug
            {
                Name = "Ondansetron ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ONDANSETRON.pdf",
                Category = "BLS"
            });
            Drugs.Add(new Drug
            {
                Name = "Oxygen ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-OXYGEN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Sodium Bicarbonate ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-SODIUM BICARBONATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Verapamil  ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-VERAPAMIL.pdf",
                Category = "BLS"

            });

        }

    }
}



