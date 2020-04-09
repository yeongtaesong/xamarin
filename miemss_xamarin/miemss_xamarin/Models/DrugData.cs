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
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Activated Charcoal (Without Sorbitol) ",
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Aspirin",
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Epinephri	",
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Epinephrine Auto-Injector",
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Naloxone",
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Nitroglycerin ",
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Oral Glucose ",
                Details = "coming soon"
            });

            Drugs.Add(new Drug
            {
                Name = "Oxygen 	 ",
                Details = "coming soon"
            });


        }

    }
}



