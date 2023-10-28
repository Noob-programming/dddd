using System;

namespace ItemStockRepoPattern.Model
{
	public class StockModel
	{
		public Guid ItemGuid { get; set; }
		public string Status { get; set; }
		public decimal Quantity { get; set; }
	}
}