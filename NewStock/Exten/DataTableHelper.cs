﻿using System;
using System.Collections.Generic;
using System.Data;

namespace NewStock.Exten
{
	public static class DataTableHelper
	{
		public static T ChangeForItem<T>
			(this DataTable soures, Func<DataRow, T> selector)
			where T : class
		{
			foreach (DataRow dr in soures.Rows)
			{
				var item = selector(dr);
				return item;
			}

			return null;
		}

		public static List<T> ChangeList<T>
			(this DataTable soures, Func<DataRow, T> selector)
			where T : class
		{
			var data = new List<T>();
			foreach (DataRow dr in soures.Rows)
			{
				var item = selector(dr);
				data.Add(item);
			}

			return data;
		}
	}
}