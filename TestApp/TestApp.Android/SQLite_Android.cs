using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using TestApp.Droid;
using System.IO;

namespace TestApp.Droid
{
	public class SQLite_Android : ISQLite
	{
		public SQLite_Android() { }
		public string GetDatabasePath(string filename)
		{
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentsPath, filename);
			return path;
		}
	}
}