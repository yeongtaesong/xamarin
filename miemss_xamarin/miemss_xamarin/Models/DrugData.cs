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
                Details = "Patients ages 2 years and above judged to be in mild to moderate discomfort (e.g., 2-5 on FACES scale).",
                Path = "miemss_xamarin.Assets.BLS-ACETAMINOPHEN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol) ",
                Details = "Poisoning by mouth.",
                Path = "miemss_xamarin.Assets.BLS-ACTIVATED CHARCOAL.pdf",
                Category = "BLS"


            });
            Drugs.Add(new Drug
            {
                Name = "Adenosine ",
                Details = "Used to treat narrow complex tachycardia, PSVT with WPW. Slows conduction through the AV node. ",
                Path = "miemss_xamarin.Assets.BLS-ADENOSINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Albuterol",
                Details = "Signs and symptoms of respiratory distress. Bronchospasm/wheezing associated with: asthma, chronic bronchitis, emphysema, allergic reaction.",
                Path = "miemss_xamarin.Assets.BLS-ALBUTEROLSULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Amiodarone",
                Details = "Prolongs duration and refractory period of action potential. Slows electrical conduction, electrical impulse generation from sinoatrial node, and conduction through accessory pathways. Also dilates blood vessels.",
                Path = "miemss_xamarin.Assets.BLS-AMIODARONE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "Platelet inhibitor. Anti-inflammatory.",
                Path = "miemss_xamarin.Assets.BLS-ASPIRIN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Atropine Sulfate",
                Details = "Parasympatholytic (vagolytic action), Anticholingergic (accelerates the heart rate)",
                Path = "miemss_xamarin.Assets.BLS-ATROPINESULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Atrovent",
                Details = "Anticholinergic (parasympatholytic) bronchodilator, Bronchodilator is site-specific, not systemic. Dries respiratory tact secretions. Most effective in combination with a beata-adrenergic bronchodilator.",
                Path = "miemss_xamarin.Assets.BLS-ATROVENT.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Calcium Chloride",
                Details = "Increases cardiact contractile state and ventricular automaticity.",
                Path = "miemss_xamarin.Assets.BLS-CALCIUM CHLORIDE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Dexamethasone ",
                Details = "Moderate to severe asthma exacerbation. Croup. Anaphylaxis.",
                Path = "miemss_xamarin.Assets.BLS-DEXAMETHASONE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Dextrose ",
                Details = "A water-soluble monosaccharide found in corn syrup and honey. Restores circulating blood sugar and is rapidly utilized following IV injection.",
                Path = "miemss_xamarin.Assets.BLS-DEXTROSE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Diazepam",
                Details = "Sedation, hypnosis, alleviation of anxiety, muscle relaxation.",
                Path = "miemss_xamarin.Assets.BLS-DIAZEPAM.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Diphenhydramine Hydrochloride ",
                Details = "Antihistamine.",
                Path = "miemss_xamarin.Assets.BLS-DIPHENHYDRAMINE HYDROCHLORIDE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Dopamine Hydrochloride",
                Details = "Alpha and beta adrenergic receptor stimulation.",
                Path = "miemss_xamarin.Assets.BLS-DOPAMINE HYDROCHLORIDE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Epinephrine ",
                Details = "The administration of ephinephrine causes increases in: Systemic vascular resistance.",
                Path = "miemss_xamarin.Assets.BLS-EPINEPHRINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Fentanyl ",
                Details = "Synthetic opiod binds with opiate receptors in the CNS, altering both perception and emotional response to pain.",
                Path = "miemss_xamarin.Assets.BLS-FENTANYL.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Glucagon ",
                Details = "Hormone synthesized by the pancreas.",
                Path = "miemss_xamarin.Assets.BLS-GLUCAGON.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Haloperidol (Haldol) ",
                Details = "An effective anxiolytic agent. Very effective in the management of aggressive and violent patients.",
                Path = "miemss_xamarin.Assets.BLS-HALOPERIDOL (HALDOL).pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Ketamine",
                Details = "Hypnotic analgesic.",
                Path = "miemss_xamarin.Assets.BLS-KETAMINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Lactated Ringer's ",
                Details = "Isotonic crystalloid solution.",
                Path = "miemss_xamarin.Assets.BLS-LACTATED RINGER’S.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Lidocaine ",
                Details = "Anesthesia for IO infusions.",
                Path = "miemss_xamarin.Assets.BLS-LIDOCAINE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Magnesium Sulfate ",
                Details = "Physiologic calcium channel blocker and also blocks neuromuscular transmission.",
                Path = "miemss_xamarin.Assets.BLS-MAGNESIUM SULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Midazolam ",
                Details = "Sedative, hypnotic, anticonvulsant.",
                Path = "miemss_xamarin.Assets.BLS-MIDAZOLAM.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Morphine Sulfate ",
                Details = "(Optional supplement protocol.) Decreases pain perception and anxiety.",
                Path = "miemss_xamarin.Assets.BLS-MORPHINE SULFATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "Reverses all effects due to opioid (morphine-like) agents. This drug will reverse the respiratory depression and all central and peripheral nervous system effects.",
                Path = "miemss_xamarin.Assets.BLS-NALOXONE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin ",
                Details = "Vasodilator-effect on veins more than arteries.",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin Paste ",
                Details = "Nitroglycerin paste contains a 2% solution of nitroglycerin in a special absorbent paste.When placed on the skin, nitroglycerin is absorbedinto the systemic circulation.In many cases, it may be preferred over nitroglycerin tablets because of its longer duration of action.",
                Path = "miemss_xamarin.Assets.BLS-NITROGLYCERIN PASTE.pdf",
                Category = "BLS"
            });
            Drugs.Add(new Drug
            {
                Name = "Ondansetron ",
                Details = "A selective blocking agent of serotonin 5-HT3 receptor type.",
                Path = "miemss_xamarin.Assets.BLS-ONDANSETRON.pdf",
                Category = "BLS"
            });
            Drugs.Add(new Drug
            {
                Name = "Oxygen ",
                Details = "Increases oxygen content of the blood. Improves tissue oxygenation.",
                Path = "miemss_xamarin.Assets.BLS-OXYGEN.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Sodium Bicarbonate ",
                Details = "Sodium bicarbonate corrects acidosis.",
                Path = "miemss_xamarin.Assets.BLS-SODIUM BICARBONATE.pdf",
                Category = "BLS"

            });
            Drugs.Add(new Drug
            {
                Name = "Verapamil  ",
                Details = "Calcium channel blocker.",
                Path = "miemss_xamarin.Assets.BLS-VERAPAMIL.pdf",
                Category = "BLS"

            });

        }

    }
}



