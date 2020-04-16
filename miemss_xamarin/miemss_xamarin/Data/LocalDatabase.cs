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

        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public LocalDatabase()
        {

            InitializeAsync().SafeFireAndForget(false);
            AddItems();


        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Drug).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Drug)).ConfigureAwait(false);
                    initialized = true;
                }
            }

        }

        //...
        public Task<List<Drug>> GetItemsAsync()
        {
            return Database.Table<Drug>().ToListAsync();
        }

        public Task<Drug> GetItemAsync(int id)
        {
            return Database.Table<Drug>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

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

        public Task<int> DeleteItemAsync(Drug drug)
        {
            return Database.DeleteAsync(drug);
        }

        public void AddItems()

        {
            //Currently very inefficient, but prevents item from being duplicated. Find more efficient method?
            Database.DropTableAsync<Drug>().Wait();
            Database.CreateTableAsync<Drug>().Wait();

            Drugs = DrugData.Drugs;

            foreach(Drug drug in Drugs)
            {
                SaveItemAsync(drug);
            }


        }
    }
}
