using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.Data.Helpers;
using DevExpress.XtraEditors.Controls;

namespace itemStock.Logic
{
	public static class DBHelper
	{
		public static SqlCommand Command { get; private set; }

		private static SqlConnection GetConnection()
		{
			try
			{
				SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
				{
					DataSource = Properties.Settings.Default.DataSource,
					InitialCatalog = Properties.Settings.Default.DataBaseName,
					IntegratedSecurity = Properties.Settings.Default.Security
				};
				return new SqlConnection(builder.ConnectionString);
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
			}

			return null;

		}


		public static bool ExcuteData(string spName, Action action)
		{

			using (var connection = GetConnection())
			{
				try
				{
					Command = new SqlCommand(spName, connection);
					Command.CommandType = CommandType.StoredProcedure;
					//execute method that contain parameter
					action.Invoke();
					connection.Open();
					Command.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception e)
				{
					MessageBox.Show($@"{e}");
					return false;
				}
				finally
				{
					connection.Close();
				}

			}
		}

		public static DataTable GetData(string spName, Action action)
		{
			DataTable dt = new DataTable();
			using (var connection = GetConnection())
			{
				SqlDataAdapter adapter = null;
				try
				{
					Command = new SqlCommand(spName, connection);
					Command.CommandType = CommandType.StoredProcedure;
					//execute method that contain parameter
					action.Invoke();
					connection.Open();

					adapter = new SqlDataAdapter(Command);
					adapter.Fill(dt);
					adapter.Dispose();

					connection.Close();
					return dt;
				}
				catch (Exception e)
				{

					MessageBox.Show($@"{e}");

				}
				finally
				{
					adapter?.Dispose();
					connection.Close();
				}
			}

			return dt;
		}

		public static List<string> FillComboBoxWithSPResult(string spName, Action action)
			
		{
			List<string> itemList = new List<string>();
			using (var connection = GetConnection())
			{
				
				SqlDataReader adapter = null;
				try
				{
					Command = new SqlCommand(spName, connection);
					Command.CommandType = CommandType.StoredProcedure;

					// Execute the method that contains parameter setup
					action.Invoke();

					connection.Open();

					adapter = Command.ExecuteReader();
					
					while (adapter.Read())
					{
						// Assuming you want to display the "Status" column in the ComboBox
						itemList.Add(adapter["Status"].ToString());
					}

					adapter.Dispose();
					return itemList;
				}
				catch (Exception e)
				{
					MessageBox.Show($@"{e}");
				}
				finally
				{
					adapter?.Dispose();
					connection.Close();
				}
			}


			return itemList;
		}

		
	}
}