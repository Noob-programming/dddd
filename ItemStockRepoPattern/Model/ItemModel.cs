using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class ItemModel
	{
		[Required, Display(Name = "item guid")]
		public Guid ItemGuid { get; set; } = Guid.Empty;
		[Display(Name = "اسم المادة")]
		public string ItemName { get; set; }

		[Display(Name = "سعر المادة")] public decimal ItemPrice { get; set; }

		[Display(Name = "سعر حبة الواحدة")] public decimal ItemPriceSingle { get; set; }

		[Display(Name = "سعر الجملة")] public decimal ItemPriceMany { get; set; }

		[Display(Name = "التصنيف التابع"), DataType(DataType.Text)]
		public Guid ParentGuid { get; set; }

		[Display(Name = "صنف")] public bool ISgroup { get; set; }

		[Display(Name = "رقم العنصر")] public int ItemCode { get; set; }

	}
}