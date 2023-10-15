using System;

namespace NewStock.Model
{
	public class ItemModel
	{
		public Guid itemGuid { get; set; }
		public string itemName { get; set; }
		public int itemCode { get; set; }
		public decimal itemPrice { get; set; }
		public decimal itemPriceSingle { get; set; }
		public decimal itemPriceMany { get; set; }
		public Guid parentGuid { get; set; }
		public bool isGroup { get; set; }
	}
}