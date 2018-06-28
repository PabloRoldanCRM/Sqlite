
using DevAzt.FormsX.Storage.SQLite.LiteConnection;
using Sqlite.SQLite.LiteConnection;
using Sqlite.SQLite.StandarDB;
using System;
using System.IO;
using Xamarin.Forms;


[assembly: Dependency(typeof(Sqlite.Droid.LiteConnection.Connection))]
namespace Sqlite.Droid.LiteConnection
{
    public class Connection : IDataBase
    {
        public LocalDB GetDataBase()
        {
            var fileName = Keys.DataBaseName;
           // var internalpath = Android.OS.Environment.ExternalStorageDirectory.Path;
            //var path = Path.Combine(internalpath, fileName);
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            return new LocalDB(path);
        }
    }
}