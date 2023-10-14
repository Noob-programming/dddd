using System;
using System.Collections.Generic;
using System.Data;

namespace itemStock.Logic
{
	public static class DataTableExtion
	{
		public static List<T> ToChangeList<T>
			(this DataTable dt, Func<DataRow, T> selector)
			where T : class
		{

			List<T> daList = new List<T>();

			foreach (DataRow v in dt.Rows)
			{
				T item = selector(v);
				daList.Add(item);
			}

			return daList;
		}
	}
}