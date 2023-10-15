using System;
using System.Data.SqlClient;

namespace NewStock.Logic
{
	public static class DbHelper
	{
		public static SqlCommand Command;

		private static SqlConnection Connection()
		{

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
			{
				DataSource = @"DESKTOP-LPLR64V\NEWSQL",
				InitialCatalog = "Bills",
				IntegratedSecurity = true
			};

			return new SqlConnection(builder.ConnectionString);
		}

		public static void ExcuteData(string sql, Action action)
		{

		}

	}
}