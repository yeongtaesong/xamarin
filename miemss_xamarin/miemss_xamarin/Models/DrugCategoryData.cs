using System;
using System.Collections.Generic;

namespace miemss_xamarin.Models
{
    public static class DrugCategoryData
    {
        public static IList<DrugCategory> DrugCategories { get; private set; }

        static DrugCategoryData()
        {
            DrugCategories = new List<DrugCategory>();

            DrugCategories.Add(new DrugCategory
            {
                DrugName = "Adenosine",
                IsAdult = false,
                categoryName = "initial",
                hasMinMaxDose = true,
                dose = 0.01,
                DoseUnit = "mg/kg",
                Unit = "mg",
                minDose = 0.01,
                maxDose = 6
            });

            DrugCategories.Add(new DrugCategory
            {
                DrugName = "Adenosine",
                IsAdult = false,
                categoryName = "repeat",
                hasMinMaxDose = true,
                dose = 0.01,
                DoseUnit = "mg/kg",
                Unit = "mg",
                minDose = 0.02,
                maxDose = 6
            });


        }
    }
}
