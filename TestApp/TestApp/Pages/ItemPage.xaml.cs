using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemPage : ContentPage
	{
		public ItemPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			var _task = (TaskTimetable)BindingContext;
			if (!String.IsNullOrEmpty(_task.Name)) 
			{
				App.Database.SaveItem(_task);
			}
			this.Navigation.PopAsync();
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			var _task = (TaskTimetable)BindingContext;
			App.Database.DeleteItem(_task.Id);
			this.Navigation.PopAsync();
		}

		private void Button_Clicked_2(object sender, EventArgs e)
		{
			this.Navigation.PopAsync();
		}
	}
}