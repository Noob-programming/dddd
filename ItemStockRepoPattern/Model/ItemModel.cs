using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class ItemModel
	{
		[Required]
		[Display(Name = "item guid")]
		public Guid itemGuid { get; set; } = Guid.Empty;
		[Display(Name = "اسم المادة")]
		public string itemName { get; set; }

		[Display(Name = "سعر المادة")] public decimal itemPrice { get; set; }

		[Display(Name = "سعر حبة الواحدة")] public decimal itemPriceSingle { get; set; }

		[Display(Name = "سعر الجملة")] public decimal itemPriceMany { get; set; }

		[Display(Name = "التصنيف التابع")] public Guid parentGuid { get; set; } = Guid.Empty;

		[Display(Name = "صنف")] public bool ISgroup { get; set; }

		[Display(Name = "رقم العنصر")] public int itemCode { get; set; }

	}
}