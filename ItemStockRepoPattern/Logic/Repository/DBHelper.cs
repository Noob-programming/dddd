using System;
using System.Data;
using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public static class DbHelper
	{
		private static SqlCommand _command;


		private static SqlConnection Connection()
		{
			var builder = new SqlConnectionStringBuilder
			{
				DataSource = @"DESKTOP-LPLR64V\NEWSQL",
				InitialCatalog = "Bills",
				IntegratedSecurity = true
			};

			return new SqlConnection(builder.ConnectionString);
		}

		private static SqlConnection GetConnection()
		{
			return Connection();
		}


		public static int ExecuteData(string sql, SqlParameter[] parameters)
		{
			try
			{
				using (var connection = GetConnection())
				{
					_command = new SqlCommand(sql, connection);
					_command.CommandType = CommandType.StoredProcedure;
					if (parameters != null) _command.Parameters.AddRange(parameters);
					connection.Open();
					_command.ExecuteNonQuery();
					connection.Close();
					return (int)_command.Parameters["@return"].Value;
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
					_command = new SqlCommand(sql, connection);
					_command.CommandType = CommandType.StoredProcedure;

					if (parameters != null) _command.Parameters.AddRange(parameters);

					connection.Open();
					var adapter = new SqlDataAdapter(_command);

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

		public static int GetLengthenTable(string sql, SqlParameter p)
		{
			try
			{
				using (var connection = GetConnection())
				{
					_command = new SqlCommand(sql, connection);
					_command.CommandType = CommandType.StoredProcedure;
					_command.Parameters.Add(p);
					connection.Open();
					_command.ExecuteNonQuery();
					connection.Close();
					return (int)_command.Parameters["@return"].Value;
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