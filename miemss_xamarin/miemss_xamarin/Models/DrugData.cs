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
                Name = "ALS-Acetaminophen",
                Details = "Patients ages 2 years and above judged to be in mild to moderate discom-fort (e.g., 2–5 on FACES scale).",
                Path = "miemss_xamarin.Assets.ALS-ACETAMINOPHEN.pdf"

            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Activated Charcoal (Without Sorbitol)",
                Details = "Poisoning by mouth",
                Path = "miemss_xamarin.Assets.ALS-ACTIVATED CHARCOAL.pdf"

            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Aspirin",
                Details = "Chest pain when acute myocardial infarction is suspected.",
                Path = "miemss_xamarin.Assets.ALS-ASPIRIN.pdf"

            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Epinephrine(1:1,000)",
                Details = "Moderate to severe allergic reaction with respiratory distress or mild allergic reaction with history of life-threatening allergic reaction.",
                Path = "miemss_xamarin.Assets.ALS-EPINEPHRINE.pdf"

            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Epinephrine Auto-Injector",
                Details = "Moderate to severe allergic reaction with respiratory distress or mild allergic reaction with history of life-threatening allergic reaction.",
                Path = "miemss_xamarin.Assets.ALS-EPINEPHRINE AUTO-INJECTOR.pdf"


            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Naloxone",
                Details = "Reverses all effects due to opioid (morphine-like) agents. This drug will reverse the respiratory depression and all central and peripheral nervous system effects.",
                Path = "miemss_xamarin.Assets.ALS-NALOXONE (NARCAN).pdf"


            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Nitroglycerin",
                Details = " Patient must have own prescribed sublingual nitroglycerin. Chest pain.",
                Path = "miemss_xamarin.Assets.ALS-NITROGLYCERIN.pdf"

            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Oral Glucose",
                Details = "Altered mental status with known diabetic history. Unconscious for an unknown reason.",
                Path = "miemss_xamarin.Assets.ALS-ORAL GLUCOSE.pdf"


            });

            Drugs.Add(new Drug
            {
                Name = "ALS-Oxygen",
                Details = "Increases oxygen content of the blood. Improves tissue oxygenation. Decreases energy expended for respiratiohn.",
                Path = "miemss_xamarin.Assets.ALS-OXYGEN.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Acetaminophen",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ACETAMINOPHEN.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Activated Charcoal (Without Sorbitol) ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ACTIVATED CHARCOAL.pdf"


            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Adenosine ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ADENOSINE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Albuterol ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ALBUTEROLSULFATE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Amiodarone",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-AMIODARONE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Aspirin",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ASPIRIN.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Atropine Sulfate",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ATROPINESULFATE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Atrovent",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ATROVENT.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Calcium Chloride",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-CALCIUM CHLORIDE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Dexamethasone ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DEXAMETHASONE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Dextrose ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DEXTROSE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Diazepam",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DIAZEPAM.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Diphenhydramine Hydrochloride ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DIPHENHYDRAMINE HYDROCHLORIDE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Dopamine Hydrochloride",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-DOPAMINE HYDROCHLORIDE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Epinephrine ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-EPINEPHRINE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Fentanyl ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-FENTANYL.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS- Glucagon ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-GLUCAGON.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Haloperidol (Haldol) ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-HALOPERIDOL (HALDOL).pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Ketamine",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-KETAMINE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Lactated Ringer's ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-LACTATED RINGER’S.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Lidocaine ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-LIDOCAINE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Magnesium Sulfate ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-MAGNESIUM SULFATE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Midazolam ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-MIDAZOLAM.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Morphine Sulfate ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-MORPHINE SULFATE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Naloxone ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-NALOXONE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Nitroglycerin ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Nitroglycerin Paste ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN PASTE.pdf"
            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Ondansetron ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-ONADANSETRON (ZOFRAN).pdf"
            });
            Drugs.Add(new Drug
            {
                Name = "BLS- Oxygen ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-OXYGEN.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Sodium Bicarbonate ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-SODIUM BICARBONATE.pdf"

            });
            Drugs.Add(new Drug
            {
                Name = "BLS-Verapamil  ",
                Details = "",
                Path = "miemss_xamarin.Assets.BLS-VERAPAMIL.pdf"

            });

        }

    }
}



