using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace LegitCheck
{
	public class ListPage : ContentPage
	{
		public ListPage()
		{
			StackLayout stackLayout = new StackLayout();
			stackLayout.VerticalOptions = LayoutOptions.Start;

			var searchBar = new SearchBar();
			searchBar.BackgroundColor = Color.FromHex("0abab5");
			searchBar.TextColor = Color.FromHex("FF69B4");
			stackLayout.Children.Add(searchBar);

			var listViewItemSource = new List<ItemModel>();

			var kithItemModel = new ItemModel();
			kithItemModel.ImageSource = "Kith";
			kithItemModel.Title = "Kith";
			kithItemModel.Description = "This is a Kith shoe";

			var jordanItemModel = new ItemModel();
			jordanItemModel.ImageSource = "WhiteJ";
			jordanItemModel.Title = "White Cement J's";
			jordanItemModel.Description = "This is a Jordan Shoe";

			listViewItemSource.Add(kithItemModel);
			listViewItemSource.Add(jordanItemModel);

			var itemListView = new ListView();
			itemListView.ItemTemplate = new DataTemplate(typeof(ItemModelViewCell));
			itemListView.ItemsSource = listViewItemSource;
			itemListView.RowHeight = 200;
			itemListView.SeparatorVisibility = SeparatorVisibility.None;

			stackLayout.Children.Add(itemListView);

			Title = "LegitCheck";
			//NavigationPage.SetTitleIcon(this, "imageName");

			Content = stackLayout;

		
		
		}
	}
}
