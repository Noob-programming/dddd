using System;
using System.Data;

namespace NewStock.Exten
{
	public static class DataTableHelper
	{
		public static T changeForItem<T>(this DataTable soures, Func<DataRow, T> selector)
		where T : class
		{
			foreach (DataRow dr in soures.Rows)
			{
				T item = selector(dr);
				return item;
			}

			return null;
		}
	}
}