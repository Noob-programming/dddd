using System;
using System.Collections.Generic;
using System.Data;

namespace StockMarcte
{
	public static class BillTable
	{
		public static List<T> ToBillList<T>
			(this DataTable dt, Func<DataRow, T> selector)
			where T : class
		{
			var daList = new List<T>();

			foreach (DataRow v in dt.Rows)
			{
				var item = selector(v);
				daList.Add(item);
			}


			return daList;
		}
	}
}