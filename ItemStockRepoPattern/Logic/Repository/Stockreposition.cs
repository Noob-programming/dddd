using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class Stockreposition : IRepository<StockModel>
	{
		/// <inheritdoc />
		public StockModel GetByGuid(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<StockModel> GetAll()
		{
			try
			{
				List<StockModel> stocks = new List<StockModel>();
				using (SqlConnection _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Stock_Get", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;


					_connection.Open();

					using (var reader = DbHelper.Command.ExecuteReader())
					{
						while (reader.Read())
						{
							stocks.Add(new StockModel
							{
								ItemGuid = new Guid(reader["itemGuid"].ToString()),
								Status = reader["status"].ToString(),
								Quantity = Convert.ToDecimal(reader["Quintity"].ToString())
							}
							);
						}

						return stocks;
					}
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}

		/// <inheritdoc />
		public bool Save(StockModel item)
		{
			try
			{
				using (SqlConnection _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Item_OnlySave", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;
					SqlParameter[] parameters =
					{
						new SqlParameter
						{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
						}
						,
						new SqlParameter
						{
							ParameterName = "@Guid",
							DbType = DbType.Guid,
							Value = item.ItemGuid
						},
						new SqlParameter
						{
							ParameterName ="@Status",
							DbType = DbType.String,
							Value = item.Status
						},
						new SqlParameter
						{
							ParameterName = "@Quin",
							DbType = DbType.Decimal,
							Value = item.Quantity
						}
					};


					DbHelper.Command.Parameters.AddRange(parameters); _connection.Open();
					DbHelper.Command.ExecuteNonQuery();
					_connection.Close();
					return Convert.ToBoolean(parameters
						.FirstOrDefault(x => x.ParameterName == "@return")?.Value);
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}


		public bool Delete(Guid item)
		{
			try
			{
				using (SqlConnection _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Stock_Delete", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;
					SqlParameter[] parameters =
					{
						new SqlParameter
						{
							ParameterName = "@return",
							DbType = DbType.Int32,
							Direction = ParameterDirection.ReturnValue
						}
						,
						new SqlParameter
						{
							ParameterName = "@Guid",
							DbType = DbType.Guid,
							Value = item
						},

					};


					DbHelper.Command.Parameters.AddRange(parameters); _connection.Open();
					DbHelper.Command.ExecuteNonQuery();
					_connection.Close();
					return Convert.ToBoolean(parameters
						.FirstOrDefault(x => x.ParameterName == "@return")?.Value);
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}
		public DataTable FillLookUp()
		{
			try
			{
				using (SqlConnection _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_Item_GetItemandName", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;
					_connection.Open();
					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(DbHelper.Command);
					adapter.Fill(dt);
					_connection.Close();

					return dt;
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}
	}
}