using System;

namespace NewStock.Model
{
	public class BillItemModel
	{

		public Guid BillitemGuid { get; set; }
		public int BillitemID { get; set; }
		public Guid BillGuid { get; set; }
		public Guid ItemGuid { get; set; }
		public decimal Quantity { get; set; }
		public decimal Price { get; set; }
		public decimal Total { get; set; }
	}
}
