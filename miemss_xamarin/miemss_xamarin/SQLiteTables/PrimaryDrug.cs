using System;
using SQLite;

namespace miemss_xamarin.SQLiteTables
{ 
    [Table("PrimaryDrug")]
    public class PrimaryDrug
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Details")]
        public string Details { get; set; }

        [Column("Path")]
        public string Path { get; set; }

        [Column("Category")]
        public string Category { get; set; }

    }
}
