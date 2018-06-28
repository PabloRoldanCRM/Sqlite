using Sqlite.SQLite.StandarDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sqlite
{
	public partial class MainPage : ContentPage
	{
        public static LocalDB DB { get; private set; }
        public MainPage()
		{
			InitializeComponent();
            MainPage.DB = LocalDB.Instance;
            btnSave.Clicked += (s, e) => {
                MainPage.DB.ContactTable.Add(new Contact() {
                    Name = eName.Text,
                    Email = eEmail.Text
                });
                DisplayAlert("Contact","Saved","OK");
                MainPage.DB.SaveChanges();
            };
            btnRetrieve.Clicked += (s, e) => {

                Navigation.PushAsync(new ViewRegister());
            };
        }
	}
}
