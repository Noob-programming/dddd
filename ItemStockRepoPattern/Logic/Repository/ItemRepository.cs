using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class ItemRepository : IRepository<ItemModel>
	{
		public ItemModel GetByGuid(Guid guid)
		{
			try
			{
				using (SqlConnection _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_item_GET", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;

					SqlParameter param = new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = guid
					};
					DbHelper.Command.Parameters.Add(param);
					_connection.Open();
					using (var reader = DbHelper.Command.ExecuteReader())
					{
						while (reader.Read())
						{
							return new ItemModel
							{
								itemGuid = new Guid(reader["itemGuid"].ToString()),
								itemCode = Convert.ToInt32(reader["itemcode"].ToString()),
								itemName = reader["itemName"].ToString(),
								itemPrice = Convert.ToDecimal(reader["itemPrice"].ToString()),
								itemPriceMany = Convert.ToDecimal(reader["itemPriceMany"].ToString()),
								itemPriceSingle = Convert.ToDecimal(reader["itemPriceSingle"].ToString()),
								parentGuid = new Guid(reader["parentGuid"].ToString()),
								ISgroup = Convert.ToBoolean(reader["ISGroup"].ToString())
							};
						}
					}
				}

				return new ItemModel();
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
					DbHelper.Command = new SqlCommand("TB_Item_GetParentData", _connection);
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

		public IEnumerable<ItemModel> GetAll()
		{
			try
			{
				var list = new List<ItemModel>();

				using (var _connection = DbHelper.GetConnection())
				{
					DbHelper.Command = new SqlCommand("TB_item_GET", _connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;

					_connection.Open();
					using (var reader = DbHelper.Command.ExecuteReader())
					{
						while (reader.Read())
						{
							list.Add(new ItemModel
							{
								itemGuid = new Guid(reader["itemGuid"].ToString()),
								itemCode = Convert.ToInt32(reader["itemcode"].ToString()),
								itemName = reader["itemName"].ToString(),
								itemPrice = Convert.ToDecimal(reader["itemPrice"].ToString()),
								itemPriceMany = Convert.ToDecimal(reader["itemPriceMany"].ToString()),
								itemPriceSingle = Convert.ToDecimal(reader["itemPriceSingle"].ToString()),
								parentGuid = new Guid(reader["parentGuid"].ToString()),
								ISgroup = Convert.ToBoolean(reader["ISGroup"].ToString())
							});
						}
					}
					return list;
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}

		}


		public bool Save(ItemModel item)
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
						},
						new SqlParameter
						{
							ParameterName = "@ItemGuid",
							DbType = DbType.Guid,
							Value = item.itemGuid
						},
						new SqlParameter
						{
							ParameterName = "@ItemCode",
							DbType = DbType.Int32,
							Value = item.itemCode
						},
						new SqlParameter
						{
							ParameterName = "@ItemName",
							DbType = DbType.String,
							Value = item.itemName
						},
						new SqlParameter
						{
							ParameterName = "@ParentGuid",
							DbType = DbType.Guid,
							Value = item.parentGuid
						},
						new SqlParameter
						{
							ParameterName = "@itemPrice",
							DbType = DbType.Decimal,
							Value = item.itemPrice
						},
						new SqlParameter
						{
							ParameterName = "@itemPriceSingle",
							DbType = DbType.Decimal,
							Value = item.itemPriceSingle
						},
						new SqlParameter
						{
							ParameterName = "@itemPriceMany",
							DbType = DbType.Decimal,
							Value = item.itemPriceMany
						},
						new SqlParameter
						{
							ParameterName = "@IsGroup",
							DbType = DbType.Boolean,
							Value = item.ISgroup
						}
					};


					DbHelper.Command.Parameters.AddRange(parameters); _connection.Open();
					DbHelper.Command.ExecuteNonQuery();
					_connection.Close();
					return Convert.ToBoolean(parameters[0]?.Value);
				}
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}


		public bool Delete(Guid item = default)
		{
			try
			{
				using (var connection = DbHelper.GetConnection())
				{


					DbHelper.Command = new SqlCommand("TB_Item_Delete", connection);
					DbHelper.Command.CommandType = CommandType.StoredProcedure;

					SqlParameter[] parameters =
					{
						new SqlParameter()
						{
							ParameterName = "@guid",
							DbType = DbType.Guid,
							Value = item
						},new SqlParameter()
						{
							ParameterName = "@return",
							DbType = DbType.Int32,
							Direction = ParameterDirection.ReturnValue
						}
					};

					DbHelper.Command.Parameters.AddRange(parameters);
					connection.Open();
					DbHelper.Command.ExecuteNonQuery();
					connection.Close();

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
	}
}