using System;

namespace NewStock.Forms.InterFaces
{
	public interface IItems
	{
		Guid itemGuid { get; set; }
		string itemName { get; set; }
		int itemCode { get; set; }
		decimal itemPrice { get; set; }
		decimal itemPriceSingle { get; set; }
		decimal itemPriceMany { get; set; }
		Guid parentGuid { get; set; }
		bool isGroup { get; set; }
	}
}