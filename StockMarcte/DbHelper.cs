using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockMarcte
{
	internal static class DbHelper
	{
		public static SqlCommand cmd;

		private static SqlConnection getConnection()
		{
			try
			{
				var conn = new SqlConnectionStringBuilder
				{
					DataSource = @"DESKTOP-LPLR64V\NEWSQL",
					InitialCatalog = "Bills",
					IntegratedSecurity = true
				};
				return new SqlConnection(conn.ConnectionString);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public static bool ExcuteData(string sql, Action action)
		{
			using (var conntion = getConnection())
			{
				try
				{
					cmd = new SqlCommand(sql, conntion);

					cmd.CommandType = CommandType.StoredProcedure;
					action.Invoke();
					conntion.Open();
					cmd.ExecuteNonQuery();
					conntion.Close();
					return true;
				}
				catch (Exception exception)
				{
					MessageBox.Show($@"{exception}");
					throw;
				}
			}
		}



		public static DataTable GetData(string sql)
		{
			var dt = new DataTable();
			using (var conntion = getConnection())
			{
				SqlDataAdapter adapter = null;
				try
				{
					cmd = new SqlCommand(sql, conntion);

					cmd.CommandType = CommandType.StoredProcedure;
					conntion.Open();
					adapter = new SqlDataAdapter(cmd);
					adapter.Fill(dt);

					conntion.Close();
					return dt;
				}
				catch (Exception e)
				{
					MessageBox.Show($@"{e}");
				}
			}

			return null;
		}

		public static bool DeleteData(string sql, Action action)
		{
			using (var conntion = getConnection())
			{
				try
				{
					cmd = new SqlCommand(sql, conntion);

					cmd.CommandType = CommandType.StoredProcedure;
					action.Invoke();
					conntion.Open();
					cmd.ExecuteNonQuery();
					conntion.Close();
					return true;
				}
				catch (Exception exception)
				{
					MessageBox.Show($@"{exception}");
					throw;
				}
			}
		}
	}
}