using System;

namespace NewStock.Model
{
	public class BillModel
	{
		public Guid billGuid { get; set; }
		public string notes { get; set; }
		public int Billcode { get; set; }
		public DateTime billdate { get; set; }
		public bool billType { get; set; }
	}
}