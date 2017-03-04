using System;
using System.Dynamic;
namespace LegitCheck
{
	public class VideoModel : MediaModel
	{
		public VideoModel(int itemId, string title, string videoLink)
		{
			ItemId = itemId;
			Title = title;
			VideoLink = videoLink;
		}

		public string VideoLink { get; set; }
	}
}
