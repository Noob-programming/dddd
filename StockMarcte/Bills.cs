using System;

namespace StockMarcte
{
	public class Bills
	{
		public Guid Billguid { get; set; }
		public int billcode { get; set; }
		public DateTime DateTime { get; set; }
		public string notes { get; set; }

		public bool billtye { get; set; }
	}
}