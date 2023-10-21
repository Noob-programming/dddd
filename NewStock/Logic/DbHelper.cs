using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewStock.Logic
{
	public static class DbHelper
	{
		public static SqlCommand Command;
		public static SqlParameter Parameters;
		private static SqlConnection Connection()
		{

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
			{
				DataSource = @"DESKTOP-LPLR64V\NEWSQL",
				InitialCatalog = "Bills",
				IntegratedSecurity = true,
			};

			return new SqlConnection(builder.ConnectionString);
		}

		public static bool ExcuteData(string sql, Action action)
		{
			try
			{
				using (var conntion = Connection())
				{
					Command = new SqlCommand(sql, conntion);
					Parameters = new SqlParameter
					{
						Direction = ParameterDirection.ReturnValue
					};
					Command.CommandType = CommandType.StoredProcedure;

					action.Invoke();

					conntion.Open();
					Command.ExecuteNonQuery();

					conntion.Close();
					return Convert.ToBoolean(Parameters.Value);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				throw;
			}
		}

		public static DataTable GetData(string sql, Action action)
		{
			var dt = new DataTable();
			using (var conntion = Connection())
			{
				SqlDataAdapter adapter = null;
				try
				{
					Command = new SqlCommand(sql, conntion);

					Command.CommandType = CommandType.StoredProcedure;
					Parameters = new SqlParameter
					{
						Direction = ParameterDirection.ReturnValue
					};

					action.Invoke();

					conntion.Open();

					adapter = new SqlDataAdapter(Command);
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

	}
}