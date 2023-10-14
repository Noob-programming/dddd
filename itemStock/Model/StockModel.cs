using System;
using System.Collections.Generic;

namespace itemStock.Model
{
	public class StockModel
	{
		public Guid ItemGuid { get; set; }
		public string status { get; set; }
		public int Quintity { get; set; }
		public object Dgv { get; set; }
		public object CbxDisplayName { get; set; }

	}
}