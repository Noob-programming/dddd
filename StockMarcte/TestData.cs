﻿namespace StockMarcte
{
	public static class TestData
	{
		public static bool TestGuid(this object InData, object OutData)
		{
			return InData.Equals(OutData);
		}
	}
}