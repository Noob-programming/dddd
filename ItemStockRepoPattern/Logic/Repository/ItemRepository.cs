using ItemStockRepoPattern.Logic.Extension;
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
				using (SqlConnection _connection = DBHelper.GetConnection())
				{
					DBHelper._command = new SqlCommand("TB_item_GET", _connection);
					DBHelper._command.CommandType = CommandType.StoredProcedure;

					SqlParameter param = new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = guid
					};
					DBHelper._command.Parameters.Add(param);
					_connection.Open();
					SqlDataAdapter adapter = new SqlDataAdapter(DBHelper._command);
					DataTable dt = new DataTable();

					adapter.Fill(dt);


					return dt.ChangeForType(x => new ItemModel()
					{
						itemGuid = new Guid(x["itemGuid"].ToString()),
						itemCode = Convert.ToInt32(x["itemcode"].ToString()),
						itemName = x["itemName"].ToString(),
						itemPrice = Convert.ToDecimal(x["itemPrice"].ToString()),
						itemPriceMany = Convert.ToDecimal(x["itemPriceMany"].ToString()),
						itemPriceSingle = Convert.ToDecimal(x["itemPriceSingle"].ToString()),
						parentGuid = new Guid(x["parentGuid"].ToString()),
						ISgroup = Convert.ToBoolean(x["ISGroup"].ToString())

					});
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
				using (SqlConnection _connection = DBHelper.GetConnection())
				{
					DBHelper._command = new SqlCommand("TB_Item_GetParentData", _connection);
					DBHelper._command.CommandType = CommandType.StoredProcedure;
					_connection.Open();
					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(DBHelper._command);
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

		public IEnumerable<ItemModel> GetAll(Guid itemGuid)
		{
			try
			{
				using (SqlConnection _connection = DBHelper.GetConnection())
				{
					DBHelper._command = new SqlCommand("TB_item_GET", _connection);
					DBHelper._command.CommandType = CommandType.StoredProcedure;

					SqlParameter param = new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = itemGuid
					};

					DBHelper._command.Parameters.Add(param);
					_connection.Open();
					SqlDataAdapter adapter = new SqlDataAdapter(DBHelper._command);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					_connection.Close();
					return dt.ChangeList(x => new ItemModel
					{
						itemGuid = new Guid(x["itemGuid"].ToString()),
						itemCode = Convert.ToInt32(x["itemcode"].ToString()),
						itemName = x["itemName"].ToString(),
						itemPrice = Convert.ToDecimal(x["itemPrice"].ToString()),
						itemPriceMany = Convert.ToDecimal(x["itemPriceMany"].ToString()),
						itemPriceSingle = Convert.ToDecimal(x["itemPriceSingle"].ToString()),
						parentGuid = new Guid(x["parentGuid"].ToString()),
						ISgroup = Convert.ToBoolean(x["ISGroup"].ToString())
					});
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
				using (SqlConnection _connection = DBHelper.GetConnection())
				{
					DBHelper._command = new SqlCommand("TB_Item_OnlySave", _connection);
					DBHelper._command.CommandType = CommandType.StoredProcedure;
					SqlParameter[] parameters =
					{
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
						},new SqlParameter
						{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
						}
					};


					DBHelper._command.Parameters.AddRange(parameters); _connection.Open();
					DBHelper._command.ExecuteNonQuery();
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


		public bool Delete(Guid item = default)
		{
			try
			{
				using (var connection = DBHelper.GetConnection())
				{


					DBHelper._command = new SqlCommand("TB_Item_Delete", connection);
					DBHelper._command.CommandType = CommandType.StoredProcedure;

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

					DBHelper._command.Parameters.AddRange(parameters);
					connection.Open();
					DBHelper._command.ExecuteNonQuery();
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