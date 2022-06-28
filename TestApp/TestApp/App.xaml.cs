using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestApp.Pages;
using System.IO;

namespace TestApp
{
	public partial class App : Application
	{
		public const string DATABASE_NAME = "TaskTimetable";
		public static TaskRepository database; 
		public static TaskRepository Database
		{
			get 
			{
				if (database == null)
				{
					database = new TaskRepository(
						Path.Combine(
							Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
				}
				return database;
			}
		}
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new StartPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
