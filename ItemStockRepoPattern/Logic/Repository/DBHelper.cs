using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public static class DBHelper
	{

		public static SqlCommand _command;


		private static SqlConnection _connection;

		private static SqlConnection Connection()
		{

			var builder = new SqlConnectionStringBuilder
			{
				DataSource = @"DESKTOP-LPLR64V\NEWSQL",
				InitialCatalog = "Bills",
				IntegratedSecurity = true,
			};

			return new SqlConnection(builder.ConnectionString);
		}

		public static SqlConnection GetConnection()
		{
			return Connection();
		}
	}
}