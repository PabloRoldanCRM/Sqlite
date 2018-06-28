

using Sqlite.SQLite.LiteConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sqlite.SQLite.StandarDB
{
    public class LocalDB : DataBase
    {
        public Table<Contact> ContactTable { get; set; }
        public LocalDB(string databasePath, bool storeDateTimeAsTicks = true) : base(databasePath, storeDateTimeAsTicks)
        {
            ContactTable = DBSet<Contact>();
        }

        public static LocalDB Instance
        {
            get {
                var service  = DependencyService.Get<IDataBase>();
                if (service != null)
                {
                    return service.GetDataBase();
                }
                throw new Exeption("No es posible obtener el servicio");

            
            }
        }
    }
}
