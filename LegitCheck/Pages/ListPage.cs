using System;
using System.Diagnostics;
using Xamarin.Forms;
namespace LegitCheck
{
	public class ListPage : ContentPage
	{
		public ListPage()
		{
			StackLayout stackLayout = new StackLayout();
			stackLayout.VerticalOptions = LayoutOptions.Center;

			Title = "LegitCheck";

			Content = stackLayout;

			var infoToolbarButton = new ToolbarItem();
			infoToolbarButton.Text = "i";

			ToolbarItems.Add(infoToolbarButton);
		
		}
	}
}
