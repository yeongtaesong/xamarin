using System;
using System.ComponentModel;
using System.Windows.Input;
using miemss_xamarin.Models;

namespace miemss_xamarin.ViewModel
{
    public class DrugCalculatorViewModel : Drug, INotifyPropertyChanged
    {
        Drug Drug { get; set; }
        public static DrugCalculatorViewModel Shared;
        public ICommand CalculateDosageCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public DrugCalculatorViewModel(Drug drug)
        {
            SetValues(drug);
        }

        private void SetValues(Drug drug)
        {
            Drug = drug;
            Name = drug.Name;
            Details = drug.Details;
            Path = drug.Path;
            Category = drug.Category;
            AdultDosageDescription = drug.AdultDosageDescription;
            PediatricDosageDescription = drug.PediatricDosageDescription;
            HasCalculator = drug.HasCalculator;
            HasAdultCalculator = drug.HasAdultCalculator; 
            HasPediatricCalculator = drug.HasPediatricCalculator;
            AdultDosage = drug.AdultDosage;
            PediatricDosage = drug.PediatricDosage;
            DoseUnit = drug.DoseUnit;
            Unit = drug.Unit;
            CategoryList = drug.CategoryList;
            HasMinMaxChildDose = drug.HasMinMaxChildDose;
            HasMinMaxAdultDose = drug.HasMinMaxAdultDose;
            AdultMaxDose = drug.AdultMaxDose;
            ChildMaxDose = drug.ChildMaxDose;
            AdultMinDose = drug.AdultMinDose;
            ChildMinDose = drug.ChildMinDose;
        }
    }
}
