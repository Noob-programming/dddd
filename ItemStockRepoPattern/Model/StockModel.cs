using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class StockModel
	{
		[Required, Display(Name = "عنوان اللعنصر")]
		public Guid ItemGuid { get; set; }
		[Display(Name = "اسم العنصر")]
		public string itemName { get; set; }

		[Display(Name = "الحالة"), StringLength(10, MinimumLength = 2, ErrorMessage = "is to long make this small > 2")]
		public string Status { get; set; }

		[Display(Name = "الكمية"), Range(0, double.MaxValue), RegularEditMask(@"^\$?\d+(\.(\d{2}))?$")]
		public decimal Quantity { get; set; }
	}
}