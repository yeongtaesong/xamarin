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
                Dosage = 0.02
            });

            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol)",
                Details = "Poisoning by mouth",
                Dosage = 0.04
            });

            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "Chest pain when acute myocardial infarction is suspected.",
                Dosage = 0.25
            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine(1:1,000)",
                Details = "Moderate to severe allergic reaction with respiratory distress or mild allergic reaction with history of life-threatening allergic reaction.",
                Dosage = 0.5
            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine Auto-Injector",
                Details = "Moderate to severe allergic reaction with respiratory distress or mild allergic reaction with history of life-threatening allergic reaction.",
                Dosage = 0.94
                
            });

            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "Reverses all effects due to opioid (morphine-like) agents. This drug will reverse the respiratory depression and all central and peripheral nervous system effects.",
                Dosage = 0.45
                
            });

            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin",
                Details = " Patient must have own prescribed sublingual nitroglycerin. Chest pain.",
                Dosage = 0.78
            });

            Drugs.Add(new Drug
            {
                Name = "Oral Glucose",
                Details = "Altered mental status with known diabetic history. Unconscious for an unknown reason.",
                Dosage = 0.55
            });

            Drugs.Add(new Drug
            {
                Name = "Oxygen",
                Details = "Increases oxygen content of the blood. Improves tissue oxygenation. Decreases energy expended for respiratiohn.",
                Dosage = 0.33
            });

        }

    }
}



