using System;
using System.IO;
using Xamarin.Forms;

namespace LegitCheck
{
	public static class ImageHelpers
	{
		public static ImageSource ConvertBase64StringToImageSource(string imageAsBase64String)
		{
			try
			{
				if (imageAsBase64String == null)
				{
					return null;
				}

				var imageByteArray = Convert.FromBase64String(imageAsBase64String);

				return ImageSource.FromStream(() => new MemoryStream(imageByteArray));
			}
			catch (Exception e)
			{
				DebugHelpers.Report(e);
				return null;
			}
		}
	}
}
