using System;

namespace NewStock.Model
{
	public class StockModel
	{
		public Guid itemGuid { get; set; }
		public decimal quintity { get; set; }
		public string status { get; set; }

	}
}