using System;
using System.Collections.Generic;
using System.Data;

namespace ItemStockRepoPattern.Logic.Extension
{
	public static class ConvertTBToT
	{
		public static T ChangeForType<T>
			(this DataTable sourest, Func<DataRow, T> selector)
			where T : class
		{
			foreach (DataRow dr in sourest.Rows)
			{
				T item = selector(dr);
				return item;
			}

			return null;
		}

		public static List<T> ChangeList<T>
			(this DataTable soures, Func<DataRow, T> selector)

			where T : class
		{
			List<T> data = new List<T>();
			foreach (DataRow dr in soures.Rows)
			{
				T item = selector(dr);
				data.Add(item);

			}
			return data;
		}
	}
}