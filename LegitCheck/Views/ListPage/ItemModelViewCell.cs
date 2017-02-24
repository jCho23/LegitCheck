using System;
using Xamarin.Forms;
namespace LegitCheck
{
	public class ItemModelViewCell : ViewCell
	{
		public ItemModelViewCell()
		{
			var itemImage = new Image();
			itemImage.SetBinding(Image.SourceProperty, nameof(ItemModel.ImageSource));
			itemImage.HorizontalOptions = LayoutOptions.CenterAndExpand;
			itemImage.VerticalOptions = LayoutOptions.CenterAndExpand;

			var imageGrid = new Grid();
			imageGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) });
			imageGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

			imageGrid.Children.Add(itemImage, 0, 0);

			View = imageGrid;
		}
	}
}
