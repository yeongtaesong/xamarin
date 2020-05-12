﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

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
        public double AdultDosage { get; set; }
        public double PediatricDosage { get; set; }
        public string DoseUnit { get; set; }
        public string Unit { get; set; }
    }
}
