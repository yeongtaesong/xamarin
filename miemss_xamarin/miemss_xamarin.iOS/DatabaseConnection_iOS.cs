using System;
using System.IO;
using miemss_xamarin.Interfaces;
using miemss_xamarin.iOS;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_iOS))]
namespace miemss_xamarin.iOS
{
    public class DatabaseConnection_iOS : IDatabaseConnection
    {
        public SQLiteConnection Connection()
        {
            var dbName = "miemss.db";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder);
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }

        public string ConnectionString()
        {
            var dbName = "miemss.db";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder);
            string path = Path.Combine(libraryFolder, dbName);

            return path;
        }

    }
}
