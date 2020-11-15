using System;
namespace miemss_xamarin.Interfaces
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection Connection();

        string ConnectionString();


    }
}
