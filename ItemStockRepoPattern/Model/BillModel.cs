using System;

namespace ItemStockRepoPattern.Model
{
	public class BillModel
	{
		public Guid billGuid { get; set; }
		public int BillCode { get; set; }
		public DateTime BillDate { get; set; }
		public string Notes { get; set; }
		public bool BillType { get; set; }
	}
}