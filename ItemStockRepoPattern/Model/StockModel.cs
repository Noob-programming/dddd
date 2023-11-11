using System;
using System.ComponentModel.DataAnnotations;

namespace ItemStockRepoPattern.Model
{
	public class StockModel
	{
		[Required]
		[Display(Name = "عنوان اللعنصر")]
		public Guid ItemGuid { get; set; }

		[Display(Name = "status")] public string Status { get; set; }

		[Display(Name = "الكمية")] public decimal Quantity { get; set; }
	}
}