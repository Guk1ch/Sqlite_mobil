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
	public partial class StartPage : ContentPage
	{
		public StartPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			lv_task.ItemsSource = App.Database.GetItems();
			base.OnAppearing();
		}
		private async void btn_Add_Clicked(object sender, EventArgs e)
		{
			TaskTimetable selectedTask = new TaskTimetable();
			ItemPage contentPage = new ItemPage();
			contentPage.BindingContext = selectedTask;
			await Navigation.PushAsync(contentPage);

		}

		private async void lv_task_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			TaskTimetable selectedTask = (TaskTimetable)e.SelectedItem;
			ItemPage contentPage = new ItemPage();
			contentPage.BindingContext = selectedTask;
			await Navigation.PushAsync(contentPage);
		}
	}
}