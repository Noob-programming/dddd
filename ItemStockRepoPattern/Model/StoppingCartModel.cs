using System;

namespace ItemStockRepoPattern.Model
{
	public class StoppingCartModel
	{
		public Guid SalesOrderId { get; set; }
		public Guid ItemGuid { get; set; }
		public Guid BillGuid { get; set; }
		public int StoppingOrderId { get; set; }
		public decimal Prices { get; set; }
		public decimal Total { get; set; }
		public decimal Quantity { get; set; }
	}
}