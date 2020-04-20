using SQLite;
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
        public double Dosage { get; set; }

    }
}
