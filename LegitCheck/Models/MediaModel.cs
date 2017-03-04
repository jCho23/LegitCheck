using System;
namespace LegitCheck
{
	public abstract class MediaModel
	{
		public int Id { get; set; }
		public int ItemId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
