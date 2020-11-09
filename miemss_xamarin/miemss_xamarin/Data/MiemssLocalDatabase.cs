using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using miemss_xamarin.SQLiteTables;
using SQLite;
using Xamarin.Forms;


namespace miemss_xamarin.Data
{
    public class MiemssLocalDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public MiemssLocalDatabase(string dbPath)
        {
            try
            {
                _database = new SQLiteAsyncConnection(dbPath);

                _database.CreateTableAsync<PrimaryDrug>().Wait();
                _database.CreateTableAsync<ChildDosage>().Wait();
                _database.CreateTableAsync<AdultDosage>().Wait();

            }
            catch (Exception ex)
            {

            }
        }

        public Task<List<PrimaryDrug>> GetPrimaryDrugs()
        {
            return _database.Table<PrimaryDrug>().ToListAsync();
        }

        public Task<List<ChildDosage>> GetChildDosages()
        {
            return _database.Table<ChildDosage>().ToListAsync();
        }

        /// <summary>
        /// Return corresponding dosages from ChildDosage table.
        /// </summary>
        /// <param name="drug"></param>
        /// <returns></returns>
        public Task<List<ChildDosage>> GetChildDosages(PrimaryDrug drug)
        {
            return _database.Table<ChildDosage>().Where(d => d.PrimaryDrugID == drug.ID).ToListAsync();
        }

        /// <summary>
        /// Return corresponding dosages from AdultDosage table.
        /// </summary>
        /// <param name="drug"></param>
        /// <returns></returns>
        public Task<List<AdultDosage>> GetAdultDosages(PrimaryDrug drug)
        {
            return _database.Table<AdultDosage>().Where(d => d.PrimaryDrugID == drug.ID).ToListAsync();
        }

        public Task<List<PrimaryDrug>> GetDrugsByCategory(string category)
        {
            return _database.Table<PrimaryDrug>().Where(t => t.Category == category).ToListAsync();
        }
    }
}
