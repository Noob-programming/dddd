using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class ItemRepository : IRepository<ItemModel>
	{
		public ItemModel GetByGuid(Guid guid)
		{
			try
			{
				SqlParameter[] param =
					{
						new SqlParameter() {
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = guid
					}
				};
				return DbHelper.GetDataTable("TB_item_GET", param).ChangeForType(
					reader => new ItemModel
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
				return DbHelper.GetDataTable("TB_Item_GetParentData");
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

				return
				DbHelper.GetDataTable("TB_item_GET").
					ChangeList(reader =>
					new ItemModel
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

				return Convert.ToBoolean(DbHelper.ExecuteData("TB_Item_OnlySave", parameters));
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
				SqlParameter[] parameters =
				{
					new SqlParameter()
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = item
					},
					new SqlParameter()
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};
				return Convert.ToBoolean(DbHelper.ExecuteData("TB_Item_Delete", parameters));
			}

			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}
	}
}