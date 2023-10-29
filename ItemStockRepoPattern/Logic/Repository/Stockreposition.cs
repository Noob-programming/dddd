using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ItemStockRepoPattern.Logic.Repository
{
	public class Stockreposition : IRepository<StockModel>
	{

		public StockModel GetByGuid(Guid guid)
		{
			try
			{
				var parameter = new[]
				{
					new SqlParameter
					{
						ParameterName = "@guid",
						DbType = DbType.Guid,
						Value = guid
					},
					new SqlParameter("@return", SqlDbType.Int)
					{
						Direction = ParameterDirection.ReturnValue
					}
				};

				var res = DbHelper.GetDataTable("TB_Stock_Get", parameter);
				return res.ChangeForType(dataRow => new StockModel
				{
					ItemGuid = new Guid(dataRow["itemGuid"].ToString()),
					Quantity = Convert.ToDecimal(dataRow["Quintity"].ToString()),
					Status = dataRow["status"].ToString()
				});
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

		}

		public IEnumerable<StockModel> GetAll()
		{
			try
			{
				var res = DbHelper.GetDataTable("TB_Stock_Get");
				var stocks = res.ChangeList(dataRow => new StockModel
				{
					ItemGuid = new Guid(dataRow["itemGuid"].ToString()),
					Quantity = Convert.ToDecimal(dataRow["Quintity"].ToString()),
					Status = dataRow["status"].ToString()
				});
				return stocks;
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}

		public DataTable FillLook()
		{
			try
			{
				return DbHelper.GetDataTable("TB_Item_GetItemandName");
			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}


		public bool Save(StockModel item)
		{
			try
			{
				SqlParameter[] parameters =
				{
					new SqlParameter
					{
						ParameterName = "@Guid",
						DbType = DbType.Guid,
						Value = item.ItemGuid
					},
					new SqlParameter
					{
						ParameterName = "@Status",
						DbType = DbType.String,
						Value = item.Status
					},
					new SqlParameter
					{
						ParameterName = "@Quin",
						DbType = DbType.Decimal,
						Value = item.Quantity
					},
					new SqlParameter("@return", SqlDbType.Int)
					{
						Direction = ParameterDirection.ReturnValue
					}
				};

				var returnCode = DbHelper.ExecuteData("TB_Stock_Save", parameters);

				return Convert.ToBoolean(returnCode);
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
						ParameterName = "@Guid",
						DbType = DbType.Guid,
						Value = item
					}
				};
				var r = DbHelper.ExecuteData("TB_Stock_Delete", parameters);
				return Convert.ToBoolean(r);

			}
			catch (Exception e)
			{
				System.Windows.Forms.MessageBox.Show($@"{e}");
				throw;
			}
		}
	}
}
