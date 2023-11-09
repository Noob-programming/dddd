using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class ItemModel
	{
		[Required]
		[Display(Name = "item guid")]
		public Guid itemGuid { get; set; }
		[Required]
		[Display(Name = "اسم المادة")]
		public string itemName { get; set; }
		[Display(Name = "سعر المادة")]
		public decimal itemPrice { get; set; }
		[Display(Name = "سعر حبة الواحدة")]

		public decimal itemPriceSingle { get; set; }
		public decimal itemPriceMany { get; set; }
		public Guid parentGuid { get; set; }
		public bool ISgroup { get; set; }
		public int itemCode { get; set; }
	}
}