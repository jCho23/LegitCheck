using System;

using Xamarin.Forms;

namespace LegitCheck
{
	public class App : Application
	{
		public App()
		{

			ListPage welcomePage = new  ListPage();

			MainPage = new NavigationPage(welcomePage)
			{
				BarBackgroundColor = Color.FromHex("000000"),
				BarTextColor = Color.FromHex("FF69B4"),
				                       
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
