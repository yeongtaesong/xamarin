using System;
using SQLite;



namespace miemss_xamarin.Models
{
    public class DrugCategory
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string categoryName { get; set; }
        public string DrugName { get; set; }
        public bool IsAdult { get; set; }
        public double dose { get; set; }
        public bool hasMinMaxDose { get; set;}
        public double minDose { get; set; }
        public double maxDose { get; set; }
        public string DoseUnit { get; set; }
        public string Unit { get; set; }

        public DrugCategory()
        {
        }
    }
}
