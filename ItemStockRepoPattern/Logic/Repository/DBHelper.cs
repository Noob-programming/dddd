using System;
using System.Data;
using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public static class DbHelper
	{

		public static SqlCommand Command;


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


		public static int ExecuteData(string sql, SqlParameter[] parameters)
		{
			try
			{
				using (SqlConnection connection = DbHelper.GetConnection())
				{

					Command = new SqlCommand(sql, connection);
					Command.CommandType = CommandType.StoredProcedure;
					if (parameters != null)
					{
						Command.Parameters.AddRange(parameters);
					}
					connection.Open();
					Command.ExecuteNonQuery();
					connection.Close();
					return (int)Command.Parameters["@return"].Value;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

		}

		public static DataTable GetDataTable(string sql, SqlParameter[] parameters = default)
		{
			try
			{
				using (var connection = GetConnection())
				{

					Command = new SqlCommand(sql, connection);
					Command.CommandType = CommandType.StoredProcedure;

					if (parameters != null)
					{
						Command.Parameters.AddRange(parameters);
					}

					connection.Open();
					var adapter = new SqlDataAdapter(Command);

					var dt = new DataTable();

					adapter.Fill(dt);

					connection.Close();

					return dt;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}