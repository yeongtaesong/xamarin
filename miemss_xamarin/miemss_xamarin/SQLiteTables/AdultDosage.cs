using System;
using SQLite;

namespace miemss_xamarin.SQLiteTables
{
    public class AdultDosage
    {
        [PrimaryKey, AutoIncrement, Column("DrugCategoryID")]
        public int ID { get; set; }

        [Column("PrimaryDrugID")]
        public int PrimaryDrugID { get; set; }

        [Column("CategoryName")]
        public string CategoryName { get; set; }

        [Column("DosageDescription")]
        public string DosageDescription { get; set; }

        [Column("Dosage")]
        public double Dosage { get; set; }

        [Column("Unit")]
        public string Unit { get; set; }

        [Column("DoseUnit")]
        public string DoseUnit { get; set; }

        [Column("HasCalculator")]
        public bool HasCalculator { get; set; }

        [Column("HasMaxDose")]
        public bool HasMaxDose { get; set; }

        [Column("MaxDose")]
        public double MaxDose { get; set; }
    }
}
