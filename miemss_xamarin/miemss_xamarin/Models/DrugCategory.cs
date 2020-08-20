using System;
using SQLite;



namespace miemss_xamarin.Models
{
    public class DrugCategory
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string categoryName { get; set; }
        public int dose { get; set; }
        public int minDose { get; set; }
        public int maxDose { get; set; }

        public DrugCategory()
        {
        }
    }
}
