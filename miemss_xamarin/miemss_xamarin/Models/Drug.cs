using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

/*You can modify the SQLite database here. Each class is a table. Please refer
 *to SQLite documentation for more information on data types available: 
 *https://www.sqlite.org/docs.html . You may also refer to the Microsoft documentation
 *for specific use of the library: 
 *https://docs.microsoft.com/en-us/xamarin/xamarin-forms/data-cloud/data/databases */

namespace miemss_xamarin.Models
{
    public class Drug
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Path { get; set; }
        public string Category { get; set; }
        public string AdultDosageDescription { get; set; }
        public string PediatricDosageDescription { get; set; }
        public bool HasCalculator { get; set; }
        public bool HasAdultCalculator { get; set; }
        public bool HasPediatricCalculator { get; set; }
        public double AdultDosage { get; set; }
        public double PediatricDosage { get; set; }
        public string DoseUnit { get; set; }
        public string Unit { get; set; }
        public string CategoryList { get; set; }
        public bool HasMinMaxDose { get; set; }
        public int MinDose { get; set; }
        public int MaxDose { get; set; }
    }
}
