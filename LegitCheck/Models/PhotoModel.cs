using System;
using System.IO;
using Xamarin.Forms;

namespace LegitCheck
{
	public class PhotoModel : MediaModel
	{
		public PhotoModel(int itemId, string imageAsBase64String, string title)
		{
			ItemId = itemId;
			ImageAsBase64String = imageAsBase64String;
			Title = title;
		}

		public ImageSource Image => ImageHelpers.ConvertBase64StringToImageSource(ImageAsBase64String);
		public string ImageAsBase64String { get; set; }
	}
}
