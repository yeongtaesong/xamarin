using System;
using miemss_xamarin.Models;

namespace miemss_xamarin.ViewModel
{
    public class DrugCalculatorViewModel : Drug
    {
        Drug Drug { get; set; }

        private bool _HasMinMaxDose;

        public DrugCalculatorViewModel(Drug drug)
        {
            Drug = drug;
            Name = drug.Name;
            Details = drug.Details;
            Path = drug.Path;
            Category = drug.Category;
            AdultDosageDescription = drug.PediatricDosageDescription;
            PediatricDosageDescription = drug.PediatricDosageDescription;
            HasCalculator = drug.HasCalculator;
            HasAdultCalculator = drug.HasCalculator;
            HasPediatricCalculator = drug.HasPediatricCalculator;
            AdultDosage = drug.AdultDosage;
            PediatricDosage = drug.PediatricDosage;
            DoseUnit = drug.DoseUnit;
            Unit = drug.Unit;
        }

        
    }
}
