using miemss_xamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miemss_xamarin.Data
{
    public class LocalDatabase
    {

        public IList<Drug> Drugs { get; private set; }

        //Allows the database to start up without delaying app launch
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public LocalDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

       public async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Drug).Name))
                {
                    /*SQLite database may still be in the phone, this ensure table is removed and allow for 
                     * DB to update if changes are made on DrugData.cs*/
                    Database.DropTableAsync<Drug>().Wait();

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Drug)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }

        //upon initialization, items are added to the database
        public async void InitializeDatabase()
        {
            int count = await App.Database.GetDrugCount();
            if (count == 0)
            {
                App.Database.AddItems();
            }
        }
        //Get number of Drugs in database
        public async Task<int> GetDrugCount()
        {
           int count = await Database.Table<Drug>().CountAsync();
            return count;
        }
        //Returns all items from database 
        public Task<List<Drug>> GetItemsAsync()
        {
            return Database.Table<Drug>().ToListAsync();
        }

        //Return search results from user input
        public Task<List<Drug>> GetItemAsync(string query)
        {
            string searchNoSpaces = query.Replace(" ", "%");
            return Database.QueryAsync<Drug>("select * from Drug where Name LIKE ?", searchNoSpaces + "%");
        }

        //Get all items from a selected category "ALS" or "BLS"
        public Task<List<Drug>> GetItemsByCategory(string category)
        {
            return Database.QueryAsync<Drug>("select * from Drug where Category = ?", category);
        }

        //Get single item from a category "ALS" or "BLS"
        public Task<List<Drug>> GetItemByCategory(string query, string category)
        {
            string searchNoSpaces = query.Replace(" ", "%");
            return Database.QueryAsync<Drug>("select * from Drug where Category = ? AND Name LIKE ?", category, searchNoSpaces + "%");
        }

        //After query, item should always be saved
        public Task<int> SaveItemAsync(Drug drug)
        {
            if (drug.ID != 0)
            {
                return Database.UpdateAsync(drug);
            }
            else
            {
                return Database.InsertAsync(drug);
            }
        }

        //Not used in project but useful for future development
        public Task<int> DeleteItemAsync(Drug drug)
        {
            return Database.DeleteAsync(drug);
        }

        //Items added from DrugData
        public void AddItems()
        {
            Drugs = DrugData.Drugs;

            foreach(Drug drug in Drugs)
            {
                SaveItemAsync(drug);
            }
        }
    }
}
