using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Logic.Interfaces;
using ItemStockRepoPattern.Model;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class ItemRepository : IRepository<ItemModel>, IFillLookItem, IMax
	{
		public object FillLookItem()
		{
			try
			{
				return DbHelper.GetDataTable("TB_Item_GetParentData").ChangeList(x => new ItemModel
				{
					ItemGuid = new Guid(x["itemguid"].ToString()),
					ItemName = x["itemName"].ToString(),
					ParentGuid = new Guid(x["parentGuid"].ToString())
				});
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				throw;
			}
		}

		public int GetMaxId()
		{
			try
			{
				var p = new SqlParameter
				{
					ParameterName = "@return",
					DbType = DbType.Int32,
					Direction = ParameterDirection.ReturnValue
				};

				return DbHelper.GetLengthenTable("TB_Item_GETMAX", p);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public ItemModel GetByGuid(Guid guid)
		{
			try
			{
				SqlParameter[] param =
				{
					new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = guid
					}
				};

				return DbHelper.GetDataTable("TB_item_GET", param).ChangeForType(
					reader => new ItemModel
					{
						ItemGuid = new Guid(reader["itemGuid"].ToString()),
						ItemCode = Convert.ToInt32(reader["itemcode"].ToString()),
						ItemName = reader["itemName"].ToString(),
						ItemPrice = Convert.ToDecimal(reader["itemPrice"].ToString()),
						ItemPriceMany = Convert.ToDecimal(reader["itemPriceMany"].ToString()),
						ItemPriceSingle = Convert.ToDecimal(reader["itemPriceSingle"].ToString()),
						ParentGuid = new Guid(reader["parentGuid"].ToString()),
						ISgroup = Convert.ToBoolean(reader["ISGroup"].ToString())
					});
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				throw;
			}
		}

		public IEnumerable<ItemModel> GetAll()
		{
			try
			{
				return
					DbHelper.GetDataTable("TB_item_GET").ChangeList(reader =>
						new ItemModel
						{
							ItemGuid = new Guid(reader["itemGuid"].ToString()),
							ItemCode = Convert.ToInt32(reader["itemcode"].ToString()),
							ItemName = reader["itemName"].ToString(),
							ItemPrice = Convert.ToDecimal(reader["itemPrice"].ToString()),
							ItemPriceMany = Convert.ToDecimal(reader["itemPriceMany"].ToString()),
							ItemPriceSingle = Convert.ToDecimal(reader["itemPriceSingle"].ToString()),
							ParentGuid = new Guid(reader["parentGuid"].ToString()),
							ISgroup = Convert.ToBoolean(reader["ISGroup"].ToString())
						});
			}

			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				throw;
			}
		}

		public int Save(ItemModel item)
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
						Value = item.ItemGuid
					},
					new SqlParameter
					{
						ParameterName = "@ItemCode",
						DbType = DbType.Int32,
						Value = item.ItemCode
					},
					new SqlParameter
					{
						ParameterName = "@ItemName",
						DbType = DbType.String,
						Value = item.ItemName
					},
					new SqlParameter
					{
						ParameterName = "@ParentGuid",
						DbType = DbType.Guid,
						Value = item.ParentGuid
					},
					new SqlParameter
					{
						ParameterName = "@itemPrice",
						DbType = DbType.Decimal,
						Value = item.ItemPrice
					},
					new SqlParameter
					{
						ParameterName = "@itemPriceSingle",
						DbType = DbType.Decimal,
						Value = item.ItemPriceSingle
					},
					new SqlParameter
					{
						ParameterName = "@itemPriceMany",
						DbType = DbType.Decimal,
						Value = item.ItemPriceMany
					},
					new SqlParameter
					{
						ParameterName = "@IsGroup",
						DbType = DbType.Boolean,
						Value = item.ISgroup
					}
				};

				return DbHelper.ExecuteData("TB_Item_OnlySave", parameters);
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				throw;
			}
		}

		public int Delete(Guid item = default)
		{
			try
			{
				SqlParameter[] parameters =
				{
					new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = item
					},
					new SqlParameter
					{
						ParameterName = "@return",
						DbType = DbType.Int32,
						Direction = ParameterDirection.ReturnValue
					}
				};
				return DbHelper.ExecuteData("TB_Item_Delete", parameters);
			}

			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
				throw;
			}
		}
	}
}