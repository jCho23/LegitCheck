namespace LegitCheck
{
	public class ItemModel
	{
		public ItemModel (string brand, string model, ItemType itemType)
		{
			Brand = brand;
			Model = model;
			ItemType = itemType;
		}

		public int Id { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public ItemType ItemType { get; set; }
	}

	public enum ItemType
	{
		Shoe, Wallet, Watch, Sunglasses, Handbag
	}
}
