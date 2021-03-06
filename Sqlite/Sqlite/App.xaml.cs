using Sqlite.SQLite.LiteConnection;
using Sqlite.SQLite.StandarDB;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Sqlite
{
	public partial class App : Application
	{
        public static LocalDB DB { get; private set; }

        public App ()
		{
			InitializeComponent();
            Keys.DataBaseName = "prueba.db3";

			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
